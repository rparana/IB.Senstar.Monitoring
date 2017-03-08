using IB.IniFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IB.SM.Communicator.Service
{
    public partial class Service1 : ServiceBase
    {
        enum tipoConexao
        {
            Servidor,
            Cliente,
            Indefinido
        }

        enum tipoAcao
        {
            New,
            Delete,
            Update
        }

        List<string> list_Client = new List<string>();
        List<string> list_Server = new List<string>();
        private int eventId;
        private int PORT = 11844;
        private byte[] _buffer = new byte[1024];
        public List<SocketT2h> __ClientSockets { get; set; }
        Timer timer1;
        List<string> _names = new List<string>();
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Service1()
        {
            InitializeComponent();
            __ClientSockets = new List<SocketT2h>();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("IB Senstar Communicator"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "IB Senstar Communicator", "IB Service");
            }
            eventLog1.Source = "IB Senstar Communicator";
            eventLog1.Log = "IB Service";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Serviço Iniciado.");
            eventId = 0;
            SetupServer();
        }

        private void SetupServer()
        {
            eventLog1.WriteEntry("Aguardando Conexão...", EventLogEntryType.Information, eventId++);
            PORT = AtualizaPorta();
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private int AtualizaPorta()
        {
            int retorno = 11844;
            string str = String.Empty;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (Path.GetDirectoryName(executable));
            INIFile INI = new INIFile(Path.Combine(path, "IBConfig.ini"));
            str = INI.IniReadValue("Communicator", "port");

            if (!String.IsNullOrEmpty(str))
            {
                retorno = Convert.ToInt16(str);
            }
            return retorno;

        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = _serverSocket.EndAccept(ar);
            __ClientSockets.Add(new SocketT2h(socket));
            list_Client.Add(socket.RemoteEndPoint.ToString());

            eventLog1.WriteEntry("Cliente conectado.\n" + socket.RemoteEndPoint.ToString() +
                "\nNúmero de conexões: " + __ClientSockets.Count.ToString(), EventLogEntryType.Information, eventId++);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {

            Socket socket = (Socket)ar.AsyncState;
            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch (Exception)
                {
                    // cliente fecha a conexão
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (__ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            list_Client.Remove(socket.RemoteEndPoint.ToString());
                            list_Server.Remove(socket.RemoteEndPoint.ToString());
                            __ClientSockets.RemoveAt(i);
                            eventLog1.WriteEntry("Cliente desconectado.\n" + socket.RemoteEndPoint.ToString() +
                                "\nNúmero de conexões: " + __ClientSockets.Count.ToString(), EventLogEntryType.Information, eventId++);
                        }
                    }
                    return;
                }

                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    string text = Encoding.ASCII.GetString(dataBuf);

                    if (text.IndexOf("@@SRV", 0, text.Length) >= 0)
                    {
                        for (int i = 0; i < list_Client.Count; i++)
                        {
                            string t = list_Client[i].ToString();
                            if (t == socket.RemoteEndPoint.ToString())
                            {
                                list_Client.Remove(t);
                                list_Server.Add(t);
                            }
                        }
                    }
                    else
                    {
                        eventLog1.WriteEntry("Texto recebido(" + socket.RemoteEndPoint.ToString() + "): " + text, EventLogEntryType.Information, eventId++);

                        TrataMSG(text);
                    }
                    string reponse = string.Empty;

                    //for (int i = 0; i < __ClientSockets.Count; i++)
                    //{
                    //    if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i]._Socket.RemoteEndPoint.ToString()))
                    //    {
                    //        rich_Text.AppendText("\n" + __ClientSockets[i]._Name + ": " + text);
                    //    }
                    //}



                    if (text == "bye")
                    {
                        return;
                    }
                    reponse = "servidor recebeu: " + text;
                    Sendata(socket, reponse);
                }
                else
                {
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (__ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            list_Client.Remove(socket.RemoteEndPoint.ToString());
                            list_Server.Remove(socket.RemoteEndPoint.ToString());
                            __ClientSockets.RemoveAt(i);
                            eventLog1.WriteEntry("Cliente desconectado.\n" + socket.RemoteEndPoint.ToString() +
                                "\nNúmero de conexões: " + __ClientSockets.Count.ToString(), EventLogEntryType.Information, eventId++);
                        }
                    }
                }
            }
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        private void TrataMSG(string text)
        {
            String[] substrings;

            substrings = text.Split(("\n").ToCharArray());
            foreach (string msg in substrings)
            {
                tipoConexao con = tipoConexao.Indefinido;

                if (msg.IndexOf("SRV", 0, msg.Length) > -1 && msg != "@@SRV")
                {
                    con = tipoConexao.Servidor;
                }
                if (msg.IndexOf("CLI", 0, msg.Length) > -1 && msg != "@@CLI")
                {
                    con = tipoConexao.Servidor;
                }

                switch (con)
                {
                    case tipoConexao.Servidor:
                        TrataMSGServer(msg);
                        break;
                    case tipoConexao.Cliente:
                        break;
                    default:
                        break;

                }
            }
        }

        private void TrataMSGServer(string text)
        {
            //Formato de Mensagem Recebida do servidor
            //SRV|Ação|Tipo|ID
            //Ex:
            //SRV|New|Evt|0

            for (int i = 0; i < list_Client.Count; i++)
            {
                string t = list_Client[i].ToString();
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    if (__ClientSockets[j]._Socket.RemoteEndPoint.ToString() == t)
                    {
                        Sendata(__ClientSockets[j]._Socket, text);
                    }
                }
            }

            //String[] substrings;

            //substrings = text.Split(("|").ToCharArray());

            //if (substrings[1] == "New")
            //{
            //    if (substrings[2] == "Evt")
            //    {
            //        InformaCliente(tipoAcao.New, Convert.ToInt32(substrings[3]));
            //    }
            //}

        }

        private void InformaCliente(tipoAcao act, int ID)
        {
            for (int i = 0; i < list_Client.Count; i++)
            {
                string t = list_Client[i].ToString();
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    if (__ClientSockets[j]._Socket.RemoteEndPoint.ToString() == t)
                    {
                        Sendata(__ClientSockets[j]._Socket, ID.ToString());
                    }
                }
            }
        }

        void Sendata(Socket socket, string noidung)
        {
            byte[] data = Encoding.ASCII.GetBytes(noidung);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        protected override void OnStop()
        {
            // cliente fecha a conexão
            for (int i = 0; i < __ClientSockets.Count; i++)
            {
                __ClientSockets.RemoveAt(i);
            }
            eventLog1.WriteEntry("Serviço Parado.");
        }
    }
}

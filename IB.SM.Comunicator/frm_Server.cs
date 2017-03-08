using IB.IniFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace IB.SM.Communicator
{
    public partial class frm_Server : Form
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

        private int PORT = 11844;
        private byte[] _buffer = new byte[1024];
        public List<SocketT2h> __ClientSockets { get; set; }
        List<string> _names = new List<string>();
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public frm_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            __ClientSockets = new List<SocketT2h>();
        }

        private void frm_Server_Load(object sender, EventArgs e)
        {
            SetupServer();
        }
        private void SetupServer()
        {
            lb_stt.Text = "Aguardando Conexão...";
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
            list_Client.Items.Add(socket.RemoteEndPoint.ToString());

            lb_soluong.Text = "Número de conexões: " + __ClientSockets.Count.ToString();
            lb_stt.Text = "Cliente conectado...";
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
                            list_Client.Items.Remove(socket.RemoteEndPoint.ToString());
                            list_Server.Items.Remove(socket.RemoteEndPoint.ToString());
                            __ClientSockets.RemoveAt(i);
                            lb_soluong.Text = "Número de conexões: " + __ClientSockets.Count.ToString();
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
                        for (int i = 0; i < list_Client.Items.Count; i++)
                        {
                            string t = list_Client.Items[i].ToString();
                            if (t == socket.RemoteEndPoint.ToString())
                            {
                                list_Client.Items.Remove(t);
                                list_Server.Items.Add(t);
                            }
                        }
                    }
                    else
                    {
                        lb_stt.Text = "Texto recebido(" + socket.RemoteEndPoint.ToString() + "): " + text;

                        TrataMSG(text);
                    }
                    string reponse = string.Empty;

                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i]._Socket.RemoteEndPoint.ToString()))
                        {
                            rich_Text.AppendText("\n" + __ClientSockets[i]._Name + ": " + text);
                        }
                    }



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
                            list_Client.Items.Remove(socket.RemoteEndPoint.ToString());
                            list_Server.Items.Remove(socket.RemoteEndPoint.ToString());
                            __ClientSockets.RemoveAt(i);
                            lb_soluong.Text = "Número de clientes conectados: " + __ClientSockets.Count.ToString();
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

            for (int i = 0; i < list_Client.Items.Count; i++)
            {
                string t = list_Client.Items[i].ToString();
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
            for (int i = 0; i < list_Client.Items.Count; i++)
            {
                string t = list_Client.Items[i].ToString();
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    if(__ClientSockets[j]._Socket.RemoteEndPoint.ToString()==t)
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_Client.SelectedItems.Count; i++)
            {
                string t = list_Client.SelectedItems[i].ToString();
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    {
                        Sendata(__ClientSockets[j]._Socket, txt_Text.Text);
                    }
                }
            }
            for (int i = 0; i < list_Server.SelectedItems.Count; i++)
            {
                string t = list_Server.SelectedItems[i].ToString();
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    {
                        Sendata(__ClientSockets[j]._Socket, txt_Text.Text);
                    }
                }
            }
            rich_Text.AppendText("\nServidor: " + txt_Text.Text);
        }
    }
}

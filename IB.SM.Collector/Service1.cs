using IB.IniFile;
using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using ServicosWin;
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

namespace IB.SM.Collector
{
    public partial class Service1 : ServiceBase
    {
        private IUtil util { get; set; }
        private IConfigController configController { get; set; }
        private IEventsController evController { get; set; }
        private bool firstConfig;
        private Model.Entities.ConfigSys conf { get; set; }
        private bool erro = false;

        private int eventId;
        Timer timerConnect, timerRestartNM, timer1;
        string path = "";
        private int PORT = 11844;
        private int tickReserServiceNM = 60000;
        private int timeoutMilliseconds = 10000;
        private string serviceNameNM = "Network Manager 1";
        private IPAddress ServerComm = IPAddress.Loopback;
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receivedBuf = new byte[1024];
        string receivedMSG;
        private FileInfo[] files;
        private int attempts = 0;

        public Service1()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("IB Senstar Collector"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "IB Senstar Collector", "IB Service");
            }
            eventLog1.Source = "IB Senstar Collector";
            eventLog1.Log = "IB Service";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Serviço Iniciado.");
            eventId = 0;
            try
            {
                util = new Util();
                configController = new ConfigController();
                evController = new EventsController();
                firstConfig = !util.databaseExist();
                if (firstConfig)
                {
                    eventLog1.WriteEntry("Não foi localizado as configurações iniciais. Configure o sistema e tente iniciar o serviço novamente.", EventLogEntryType.Error, eventId++);
                    eventLog1.WriteEntry("Serviço Parado.");
                    Environment.Exit(0);
                }

                CarregaConfig();
            }
            catch (Exception e)
            {
                eventLog1.WriteEntry("Erro ao iniciar Serviço: \n" + e.Message, EventLogEntryType.Error, eventId++);
                eventLog1.WriteEntry("Serviço Parado.");
                Environment.Exit(0);

            }
            // Set up a timer to trigger every minute.
            timerConnect = new Timer(new TimerCallback(timerConnect_Tick), null, 5000, 5000);

            // Set up a timer to trigger every minute.
            timerRestartNM = new Timer(new TimerCallback(timerRestartNM_Tick), null, tickReserServiceNM, tickReserServiceNM);

            // Set up a timer to trigger every minute.
            timer1 = new Timer(new TimerCallback(timer1_Tick), null, 5000, 1000);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Serviço Parado.");
        }

        private void CarregaConfig()
        {
            conf = new Model.Entities.ConfigSys();
            conf = configController.ListConfig();
            if (conf == null)
            {
                conf = new Model.Entities.ConfigSys();
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (Path.GetDirectoryName(executable));
                conf.CaminhoLogs = path;
                conf.CaminhoLogsSalvos = Path.Combine(path, "BKP");
                conf.SalvarDepoisdeLer = true;
            }
            timeoutMilliseconds = AtualizaTimeout();
            tickReserServiceNM = AtualizaTick();
            serviceNameNM = AtualizaNomeServiceNM();
            AtualizaServidorComm();
        }

        private int AtualizaTimeout()
        {
            int retorno = 10000;
            string str = String.Empty;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (Path.GetDirectoryName(executable));
            INIFile INI = new INIFile(Path.Combine(path, "IBConfig.ini"));
            str = INI.IniReadValue("ServiceNM", "timeout");

            if (IsNumeric(str))
            {
                retorno = Convert.ToInt32(str) * 1000;
            }

            return retorno;
        }

        private string AtualizaNomeServiceNM()
        {
            string retorno = serviceNameNM;
            string str = String.Empty;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (Path.GetDirectoryName(executable));
            INIFile INI = new INIFile(Path.Combine(path, "IBConfig.ini"));
            str = INI.IniReadValue("ServiceNM", "nome");

            if (!String.IsNullOrEmpty(str))
            {
                retorno = str;
            }

            return retorno;
        }

        private int AtualizaTick()
        {
            int retorno = 60000;
            string str = String.Empty;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (Path.GetDirectoryName(executable));
            INIFile INI = new INIFile(Path.Combine(path, "IBConfig.ini"));
            str = INI.IniReadValue("ServiceNM", "intervalo");

            if(IsNumeric(str))
            {
                retorno = Convert.ToInt32(str) * 1000;
            }

            return retorno;
        }

        private IPAddress AtualizaServidorComm()
        {
            IPAddress retorno = IPAddress.Loopback;

            string str = String.Empty;
            string strPort = String.Empty;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (Path.GetDirectoryName(executable));
            INIFile INI = new INIFile(Path.Combine(path, "IBConfig.ini"));
            str = INI.IniReadValue("Communicator", "address");
            strPort = INI.IniReadValue("Communicator", "port");

            if(IsNumeric(strPort))
            {
                PORT = Convert.ToInt32(strPort);
            }

            if (!String.IsNullOrEmpty(str))
            {
                retorno = IPAddress.Parse(str);
            }

            ServerComm = retorno;

            return retorno;
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

        private async void timerRestartNM_Tick(object sender)
        {
            try
            {
                eventLog1.WriteEntry("Iniciando reinicio do Serviço NM.", EventLogEntryType.Information, eventId++);
                await Servicos.RestartService(serviceNameNM, timeoutMilliseconds);
                eventLog1.WriteEntry("O Serviço NM foi reiniciado.", EventLogEntryType.Information, eventId++);
            }
            catch (Exception e)
            {
                //Console.Clear();
                eventLog1.WriteEntry("Ocorreu um erro ao tentar reiniciar o Serviço NM.\n" + e.Message, EventLogEntryType.Error, eventId++);
            }
        }

        private void timerConnect_Tick(object sender)
        {

            if (!_clientSocket.Connected)
            {
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    attempts++;
                    _clientSocket.Connect(ServerComm, PORT);
                    _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                    byte[] buffer = Encoding.ASCII.GetBytes("@@SRV");
                    _clientSocket.Send(buffer);
                    eventLog1.WriteEntry("Efetuada Conexão com servidor de Comunicação (" + ServerComm.ToString() + ")");
                }
                catch (SocketException)
                {
                    //Console.Clear();
                    eventLog1.WriteEntry("Tentativas de Conexão com servidor de Comunicação (" + ServerComm.ToString() + "): " + attempts.ToString());
                }
            }
            else
            {
                attempts = 0;
            }

        }

        private void timer1_Tick(object sender)
        {
            if (eventId >40000)
            {
                eventId = 0;
            }
            string log = "";
            // TODO: Insert monitoring activities here.
            List<SenstarEvents> se = new List<SenstarEvents>();
            files = evController.listFiles(conf.CaminhoLogs);
            if(files.Count()>0)
            {
                if (!erro)
                {
                    eventLog1.WriteEntry("Iniciando coleta de dados. \n" + path, EventLogEntryType.Information, eventId++);
                }
                try
                {
                    foreach (FileInfo file in files)
                    {
                            string eventos = "Eventos Gravados: \n Arquivo: " + file.Name + "\n";
                        
                            se = evController.readRecordLogs(file.FullName, true, conf.SalvarDepoisdeLer, conf.CaminhoLogsSalvos);
                        if(se.Count>0)
                        {
                            EnviaEventos(se);
                        }
                        foreach(SenstarEvents e in se)
                        {
                            eventos += "ID: " + e.ID + " | Central: " + e.Central.ToString() +
                                " | Lado: " + e.Lado + " | Distancia: " + e.Distancia.ToString() + "\n";
                            string texto = "SRV|New|Evt|" + e.ID.ToString();
                            //SendMSG(texto);
                        }
                            eventLog1.WriteEntry(eventos, EventLogEntryType.Information, eventId++);
                    }
                    erro = false;
                }
                catch (Exception e)
                {
                    if (!erro)
                    {
                        eventLog1.WriteEntry("Erro ao coletar dados: \n" + e.Message, EventLogEntryType.Error, eventId++);
                        erro = true;
                    }
                }
            }
        }

        private void EnviaEventos(List<SenstarEvents> se)
        {
            if (_clientSocket.Connected)
            {
                foreach (SenstarEvents e in se)
                {
                    string texto = "SRV|New|Evt|" + e.ID.ToString() + "\n";
                    byte[] buffer = Encoding.ASCII.GetBytes(texto);
                    _clientSocket.Send(buffer);
                    eventLog1.WriteEntry("Mensagem enviada ao Servidor de Comunicação2: \n" + texto, EventLogEntryType.Information, eventId++);
                    //SendMSG(texto);
                }
            }
        }

        private void SendMSG(string text)
        {
            if (_clientSocket.Connected)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(text);
                _clientSocket.Send(buffer);
                eventLog1.WriteEntry("Mensagem enviada ao Servidor de Comunicação: \n" + text, EventLogEntryType.Information, eventId++);
            }

        }

        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received;
            try
            {
                received = socket.EndReceive(ar);
            }
            catch (Exception)
            {
                // cliente fecha a conexão
                _clientSocket.Close();
                eventLog1.WriteEntry("Encerrada conexão com o servidor de Comunicação.", EventLogEntryType.Information, eventId++);
                return;
            }
            if (received != 0)
            {
                byte[] dataBuf = new byte[received];
                Array.Copy(receivedBuf, dataBuf, received);
                receivedMSG = (Encoding.ASCII.GetString(dataBuf));
                eventLog1.WriteEntry("Mensagem recebida do Servidor de Comunicação: \n" + receivedMSG, EventLogEntryType.Information, eventId++);
                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            }
        }

        /// <summary>
        /// Se todos os caracters forem digitos então é numerico
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static bool IsNumeric(string data)
        {
            bool isnumeric = true;
            char[] datachars = data.ToCharArray();

            foreach (var datachar in datachars)
                isnumeric = isnumeric ? char.IsDigit(datachar) : isnumeric;


            return isnumeric;
        }

    }
}

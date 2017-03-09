//22/02/2017
//  Criado lista com pontos de disparo.
//  Alterado imgMap_Paint para desenhar os pontos da lista de disparos
//  Alterado AtualizaZonasMapa para incluir os disparos na lista de pontos com disparo

using IB.IniFile;
using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.AlarmView
{
    public partial class FrmEventos : Form
    {
        #region Variaveis globais

        private string mensagem;
        bool blink = false;
        private int PORT = 11844;
        private IPAddress ServerComm = IPAddress.Loopback;
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receivedBuf = new byte[1024];
        string receivedMSG;
        private int attempts = 0;
        private BindingSource bs = new BindingSource();
        delegate void SetTextCallback(string texto);

        private IEventsController EvController { get; set; }
        private List<ViewEvents> dt = new List<ViewEvents>();

        List<PointOnZone> alarmPoints = new List<PointOnZone>();
        List<int> alarmZonesID = new List<int>();

        #endregion

        private void notificaçãoVisualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notificaçãoVisualToolStripMenuItem.Checked = !notificaçãoVisualToolStripMenuItem.Checked;
        }


        public FrmEventos()
        {
            InitializeComponent();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(this.Thread_Conectar));
            th.Start();
            ResetaAlarmes();
            EvController = new EventsController();
            CarregaEventos(50);
            //viewEventsBindingSource.Sort = "Data_Hora";
            AtualizaServidorComm();
        }

        private void ResetaAlarmes()
        {
            for (int i = 9; i <= 25; i++)
            {
                FieldInfo fld = typeof(FrmEventos).GetField("z" + i.ToString(),
                    BindingFlags.NonPublic | BindingFlags.Instance);
                if (fld != null)
                {
                    fld.SetValue(this, false);
                }
            }
            for (int i = 129; i <= 146; i++)
            {
                FieldInfo fld = typeof(FrmEventos).GetField("z" + i.ToString(),
                    BindingFlags.NonPublic | BindingFlags.Instance);
                if (fld != null)
                {
                    fld.SetValue(this, false);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                ReconheceAlarmesSelecionados();
        }

        private void ReconheceAlarmesSelecionados()
        {
            List<ViewEvents> ve = new List<ViewEvents>();
            foreach (DataGridViewRow dataGridViewRow in dtvEventos.SelectedRows)
            {
                int intRowID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                
                ve.Add((ViewEvents)dataGridViewRow.DataBoundItem);
                //evController.ReconheceEvento(ve.ID, "Em Desenvolvimento");
            }
            FrmReconhecer frm = new FrmReconhecer();
            frm.dt = ve;
            DialogResult retorno = frm.ShowDialog();
            if (retorno == DialogResult.OK)
            {
                CarregaEventos(50);
            }
        }

        //Desenha no MAPA
        private void imgMap_Paint(object sender, PaintEventArgs e)
        {
            alarmZonesID.Clear();
            if (!blink)
            {
                Pen zonePen = new Pen(Color.Yellow, 5);
                Pen pointPen = new Pen(Color.Red, 5);
                //PointOnZone poz = new PointOnZone { ini = 145, fim = 195, dist = 170, x1 = 799, y1 = 201, x2 = 913, y2 = 186 };
                foreach(PointOnZone p in alarmPoints)
                {
                    if (!alarmZonesID.Exists(x => x == p.zoneID))
                    {
                        alarmZonesID.Add(p.zoneID);
                        e.Graphics.DrawLine(zonePen, p.x1, p.y1, p.x2, p.y2);
                    }
                    e.Graphics.DrawEllipse(pointPen, p.xp - 3, p.yp - 3, 6, 6);
                }

                blink = true;
            }
            else if (blink)
            {
                blink = false;
            }
        }

        private void CarregaEventos(int top)
        {
            try
            {
                dt = EvController.ListTop(top).ToList();
                bs.DataSource = dt;

                //viewEventsBindingSource.DataSource = dt;
                dtvEventos.DataSource = bs;
                ResetaAlarmes();
                AtualizaZonasMapa(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AtualizaZonasMapa(List<ViewEvents> eventos)
        {
            Zone za = new Zone();
            alarmPoints.Clear();
            foreach (ViewEvents ve in eventos)
            {
                if (ve.PoM)
                {
                    za = EvController.findZonebyID(ve.IDZona);
                    if(za!=null)
                    {
                        alarmPoints.Add(new PointOnZone { zoneID = za.NumeroZona, dist = double.Parse(ve.Distancia), ini = za.Inicio, fim = za.Fim, x1 = za.x1, y1 = za.y1, x2 = za.x2, y2 = za.y2 });
                    }
                }

            }
        }

        private void timerConnect_Tick(object sender, EventArgs e)
        {
            imgMap.Invalidate();

        }

        private async void Thread_Conectar()
        {
            
            while (true)
            {
                if (!_clientSocket.Connected)
                {
                    _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        attempts++;
                        _clientSocket.Connect(ServerComm, PORT);
                        _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                        //if (this.txtTexto.InvokeRequired)
                        //{
                        //    SetTextCallback d = new SetTextCallback(DefinirTexto);
                        //    this.Invoke(d, new object[] { texto + " (Invoke)" });
                        //}
                        //else
                        //{
                        //    this.txtTexto.Text = texto + " (No Invoke)";
                        //}
                        mensagem = "Conectado";
                    }
                    catch (SocketException)
                    {
                        //Console.Clear();
                        mensagem = "Tentativas de Conexão com servidor de Comunicação (" + ServerComm.ToString() + "): " + attempts.ToString();
                    }

                    try
                    {
                        tssStatusConexao.Text = mensagem;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    attempts = 0;
                }

                await Task.Delay(5000);
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
                return;
            }
            if (received != 0)
            {
                byte[] dataBuf = new byte[received];
                Array.Copy(receivedBuf, dataBuf, received);
                receivedMSG = (Encoding.ASCII.GetString(dataBuf));
                TrataMSG(receivedMSG);
                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            }
        }

        private void TrataMSG(string msg)
        {
            String[] substrings;
            string strTemp = msg;
            strTemp = strTemp.Replace("\n", "");
            if (strTemp.IndexOf("SRV", 0, strTemp.Length) >= 0)
            {
                strTemp = strTemp.Replace("SRV|", "|");
                strTemp = strTemp.Remove(0, 1);
                substrings = strTemp.Split(("|").ToCharArray());
                for (int i = 0; i < substrings.Count(); i++)
                {
                    if (substrings[i] == "New")
                    {
                        if (substrings[i + 1] == "Evt")
                        {
                            if (IsNumeric(substrings[i + 2]))
                            {
                                NovoEvento(int.Parse(substrings[i + 2]));
                            }
                        }
                    }
                }
            }
        }

        private void NovoEvento(int id)
        {
            try
            {
                ViewEvents v = new ViewEvents();
                v = EvController.BuscaporID(id);
                if (v != null)
                {
                    dt.Add(v);

                    bs.DataSource = dt.OrderByDescending(t => t.Data_Hora);
                    dtvEventos.DataSource = bs;
                    AtualizaZonasMapa(dt);
                    if (notificaçãoVisualToolStripMenuItem.Checked)
                    {
                        foreach (Form f in Application.OpenForms)
                        {
                            RestoreFromMinimized(f);
                        }
                        Application.OpenForms[0].TopLevel = true;
                        Application.OpenForms[0].TopMost = true;

                        Application.OpenForms[0].Show();
                        Application.OpenForms[0].Activate();
                        Application.OpenForms[0].Focus();
                        Application.OpenForms[0].TopMost = false;
                        this.BringToFront();
                        this.Show();
                        this.Activate();
                        this.Focus();
                        //Application.OpenForms[0].TopLevel = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);


        private struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public Rectangle rcNormalPosition;
        }

        public void RestoreFromMinimized(Form form)
        {
            const int WPF_RESTORETOMAXIMIZED = 0x2;
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            placement.length = Marshal.SizeOf(placement);
            GetWindowPlacement(form.Handle, ref placement);

            if ((placement.flags & WPF_RESTORETOMAXIMIZED) == WPF_RESTORETOMAXIMIZED)
                form.WindowState = FormWindowState.Maximized;
            else
                form.WindowState = FormWindowState.Normal;
        }

        private void AtualizaServidorComm()
        {

            string ip = String.Empty;
            string porta = String.Empty;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            INIFile INI = new INIFile(System.IO.Path.Combine(path, "IBConfig.ini"));
            ip = INI.IniReadValue("Communicator", "address");
            porta = INI.IniReadValue("Communicator", "port");

            if (!String.IsNullOrEmpty(porta))
            {
                this.PORT = Convert.ToInt16(porta);
            }
            if (!String.IsNullOrEmpty(ip))
            {
                this.ServerComm = IPAddress.Parse(ip);
            }

        }

        private void dtvEventos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dtvEventos.SelectedRows.Count >0)
            {
                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuReconhecer = new ToolStripMenuItem("Reconhecer");
                //Assign event handlers
                mnuReconhecer.Click += new EventHandler(toolStripButton1_Click);
                //Add to main context menu
                mnu.Items.AddRange(new ToolStripItem[] { mnuReconhecer });
                //Assign to datagridview
                dtvEventos.ContextMenuStrip = mnu;

            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorios frm = new FrmRelatorios();
            frm.Show();
        }

        private void SendMSG(string text)
        {
            if (_clientSocket.Connected)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(text);
                _clientSocket.Send(buffer);
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

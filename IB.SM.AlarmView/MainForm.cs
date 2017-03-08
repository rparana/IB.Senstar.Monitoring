using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.AlarmView
{
    public partial class MainForm : Form
    {
        private IUtil util { get; set; }
        private bool firstConfig;

        public int UserID;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private bool LoadConfig()
        {
            bool retorno = false;
            util = new Util();
            retorno = util.databaseExist();

            return retorno;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (!LoadConfig())
            {
                MessageBox.Show("Configure o banco de dados antes de iniciar o software.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            this.Visible = false;
            frmLogin newForm = await Task.Run(() => new frmLogin());
            if (newForm.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
            UserID = Instancia.instanciaU.ID;
            tSSLblUsr.Text = "Usuário Logado: " + Instancia.instanciaU.Nome;
            this.Visible = true;
            eventosToolStripMenuItem.PerformClick();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void efetuarLogoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin newForm = await Task.Run(() => new frmLogin());
            Instancia.instanciaU = new Usuario();
            Instancia.instanciaP = new Permissao();

            this.Visible = false;
            if (newForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            UserID = Instancia.instanciaU.ID;
            tSSLblUsr.Text = "Usuário Logado: " + Instancia.instanciaU.Nome;
            this.Visible = true;
        }


        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Instancia.instanciaU.Alterasenha)
            {
                frmAlteraSenha formSenha = new frmAlteraSenha();

                formSenha.Text = "Alterar Senha";
                formSenha._necessitaSenha = true;
                //formSenha._senhaAntiga = txtPassword.Text;
                formSenha._user = Instancia.instanciaU;
                formSenha.ShowDialog();

            }

        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            frmEventos frm = new frmEventos();
            // Maximiza o formulário filho
            frm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            // Define quem o pai desta janela
            frm.MdiParent = this;
            // exibe o formulário
            if (!AppFunc.VerificaFormAberto(frm.Name))
                frm.Show();
        }
    }
}

using IB.SM.Business;
using System;
using IB.IniFile;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;

namespace IB.SM.Config
{
    public partial class FrmConfig : Form
    {
        private IUtil util { get; set; }
        private IConfigController configController { get; set; }
        private IUserController uController { get; set; }
        private bool firstConfig;
        string erro = "Nada";
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void criarDadosIniciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = InputBox("Para confirmar a operação digite \"Confirmar\"", "Confirme a operação", String.Empty);
            if (s.Equals("Confirmar"))
            {
                CriarDadosIniciais();
                MessageBox.Show("Dados Inicias criados com sucesso.");
            }
        }

        private void CriarDadosIniciais()
        {
            try
            {
                erro = "Chegou Util";
                util.firstConfig();
                erro = "Passou Util";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            if (s == string.Empty)
                return "";
            else
                return s;
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            

            try
            {
                util = new Util();
                configController = new ConfigController();
                uController = new UserController();
                firstConfig = !util.databaseExist();
                erro = "Passou1" + firstConfig.ToString();
                CarregaConfig();
                erro = "Passou2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Config " + erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregaConfig()
        {
            if (firstConfig)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Não foram encontrada as configurações iniciais do sistema!\nDeseja efetuar a configuração inicial agora?", "Configure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        CriarDadosIniciais();
                    }
                    else
                    {
                        Application.Exit();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }

            }
            erro = "111";
            ConfigSys c = configController.ListConfig();
            erro = "113";
            if (c != null)
            {
                erro = "c existe";
                txtID.Text = c.ID.ToString();
                txtFolder01.Text = c.CaminhoLogs;
                txtFolder02.Text = c.CaminhoLogsSalvos;
                chkMoveAfter.Checked = c.SalvarDepoisdeLer;
            }
            else
            {
                erro = "c nulo";

                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (Path.GetDirectoryName(executable));
                txtFolder01.Text = path;
                txtFolder02.Text = Path.Combine(path, "DB");
                chkMoveAfter.Checked = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFolder01_Click(object sender, EventArgs e)
        {
            txtFolder01.Text = Folder(txtFolder01.Text);
        }

        private void btnFolder02_Click(object sender, EventArgs e)
        {
            txtFolder02.Text = Folder(txtFolder02.Text);
        }

        private string Folder(string path)
        {
            folderBrowserDialog1.Description = "Selecione a pasta.";
            folderBrowserDialog1.SelectedPath = path;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }

            return path;
        }

        private void chkMoveAfter_Click(object sender, EventArgs e)
        {
            txtFolder02.Enabled = chkMoveAfter.Checked;
            btnFolder02.Enabled = chkMoveAfter.Checked;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFolder01.Text))
            {
                try
                {
                    Model.Entities.ConfigSys c = PreencheConfig();
                    c = configController.SaveConfig(c);
                    txtID.Text = c.ID.ToString();
                    MessageBox.Show("Configuração salva com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o caminho de coleta dos Logs", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Model.Entities.ConfigSys PreencheConfig()
        {
            Model.Entities.ConfigSys retorno = new Model.Entities.ConfigSys();
            try
            {
                retorno = configController.ListConfig();
                if (retorno == null)
                    retorno = new Model.Entities.ConfigSys();

                retorno.CaminhoLogs = txtFolder01.Text;
                retorno.CaminhoLogsSalvos = txtFolder02.Text;
                retorno.SalvarDepoisdeLer = chkMoveAfter.Checked;
                retorno.Ultimoupdate = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }

        private void redefinirSenhaAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = InputBox("Para confirmar a operação digite e senha de segurança", "Senha de segurança", String.Empty);
            if (s.Equals("Sup0rt3IBtech@844"))
            {
                Usuario u = uController.BuscaporLogin("Admin");
                if (u != null)
                {
                    u.Senha = util.encrypt("IBtech@844");
                    uController.Salvar(u);
                    MessageBox.Show("Senha redefinida com sucesso.");
                }
            }
            else
            {
                MessageBox.Show("Senha incorreta");
            }
        }
    }
}

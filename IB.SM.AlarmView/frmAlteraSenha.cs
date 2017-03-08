using IB.SM.Business;
using IB.SM.Exceptions;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.AlarmView
{
    public partial class frmAlteraSenha : Form
    {
        #region Variaveis

        public Usuario _user { get; set; }
        public string _senhaAntiga { get; set; }
        public bool _necessitaSenha { get; set; }

        private IUserController _uController { get; set; }
        private IUtil _utilController { get; set; }

        #endregion

        #region Controles

        #region frmAlteraSenha

        public frmAlteraSenha()
        {
            InitializeComponent();
            this._user = new Usuario();
            this._senhaAntiga = string.Empty;
            this._necessitaSenha = false;
        }

        private void frmAlteraSenha_Load(object sender, EventArgs e)
        {
            this._uController = new UserController();
            this._utilController = new Util();
            Limpa();
            ArrumaForm();
            if (_necessitaSenha && txtSenhaAtual.Text == string.Empty)
            {
                txtSenhaAtual.Focus();
            }
            else
            {
                txtSenha1.Focus();
            }
        }

        #endregion

        #region Leave - Enter / Para campos padroes.

        private void MudaCor_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Empty;
        }

        private void MudaCor_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.FromArgb(255,255,192);
        }

        #endregion

        #region btnOK

        private async void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.WhenAll( AlteraSenha());
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpa();
            }
        }

        #endregion

        #endregion

        #region Funções

        #region Limpa

        private void Limpa()
        {
            txtSenha1.Text = String.Empty;
            txtSenha2.Text = String.Empty;
            if (_necessitaSenha && txtSenhaAtual.Text == string.Empty)
            {
                txtSenhaAtual.Focus();
            }
            else
            {
                txtSenha1.Focus();
            }
        }

        #endregion

        #region ArrumaForm

        private void ArrumaForm()
        {
            if (!_necessitaSenha)
            {
                lblSenhaAtual.Visible = false;
                txtSenhaAtual.Visible = false;
                lblSenha1.Location = new Point(24, 16);
                txtSenha1.Location = new Point(27, 32);
                lblSenha2.Location = new Point(24, 59);
                txtSenha2.Location = new Point(27, 75);
                chkAlterar.Location = new Point(27, 100);
                chkAlterar.Visible = true;
                btnOk.Location = new Point(12, 124);
                btnCancel.Location = new Point(103, 124);
                this.ClientSize = new Size(205, 179);
            }
            txtSenhaAtual.Text = _senhaAntiga;
        }

        #endregion

        #region AlteraSenha

        private async Task AlteraSenha()
        {
            string senha = string.Empty;
            string pwd;
            try
            {
                if (string.IsNullOrEmpty(txtSenha1.Text.Trim()))
                {
                    throw new SenhaNaoPodeSerVazio();
                }
                if (txtSenha1.Text.Trim() != txtSenha2.Text.Trim())
                {
                    throw new SenhaDiferentedaConfirmacao();
                }

                if (txtSenha1.Text.Equals(txtSenhaAtual.Text))
                {
                    throw new SenhaNaoPodeSerIgualAntiga();
                }

                Usuario us = null;

                pwd = _utilController.encrypt(txtSenhaAtual.Text);

                us = _uController.ValidaLogin(_user.Login, pwd);

                senha = _utilController.encrypt(txtSenha1.Text);

                us.Senha = senha;
                us.Dataexpirar = DateTime.Now.AddDays(60);
                us.Ultimoupdate = DateTime.Now;

                await Task.Run(()=> _uController.Salvar(us));
                MessageBox.Show("Senha alterada com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #endregion
    }
}

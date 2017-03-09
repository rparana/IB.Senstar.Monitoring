using IB.SM.Business;
using IB.SM.Exceptions;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IB.SM.AlarmView
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Util utilController = new Util();
            string Pwd = utilController.encrypt(txtPassword.Text);
            UserController usrController = new UserController();
            GroupController grController = new GroupController();
            Usuario usr = new Usuario();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                usr = usrController.ValidaLogin(txtUser.Text, Pwd);
                if (!AlteraSenha(usr))
                {
                    return;
                }
                usr.Grupo = grController.BuscarporID(usr.Grupo.ID, true);
                Instancia.instanciaU = usr;
                Instancia.instanciaP = usr.Grupo.Permissao;
                if (!Instancia.instanciaP.AlarmViewAccess)
                {
                    throw new UsuariosemAcessoSistema();
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.SelectionStart = 0;
                txtUser.SelectionLength = txtUser.Text.Length;
            }
        }

        private void txtPassword_Enter(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.SelectionStart = 0;
                txtPassword.SelectionLength = txtPassword.Text.Length;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private bool AlteraSenha(Usuario us)
        {
            int dias = 0;
            bool necessitaAlterar = false;
            bool retorno = true;
            try
            {
                DialogResult resultado;

                if (us.Senhaexpira)
                {
                    TimeSpan t_diferenca;
                    if (DateTime.Now >= us.Dataexpirar)
                    {
                        necessitaAlterar = true;
                    }
                    else
                    {
                        t_diferenca = us.Dataexpirar.Subtract(DateTime.Now);
                        dias = t_diferenca.Days;
                        if(dias <=15)
                            necessitaAlterar = true;
                    }
                }
                if (necessitaAlterar)
                {
                    retorno = false;
                    if (dias <= 0)
                        resultado = MessageBox.Show("Sua Senha Expirou. Deseja alterá-la agora?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        resultado = MessageBox.Show(string.Format("Sua senha expira em {0} dias. Deseja alterá-la agora", dias), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        FrmAlteraSenha formSenha = new FrmAlteraSenha();

                        formSenha.Text = "Alterar Senha";
                        formSenha._necessitaSenha = true;
                        formSenha._senhaAntiga = txtPassword.Text;
                        formSenha._user = us;

                        if (formSenha.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            retorno = true;
                        }
                    }
                    else if (dias > 0)
                    {
                        retorno = true;
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }

}

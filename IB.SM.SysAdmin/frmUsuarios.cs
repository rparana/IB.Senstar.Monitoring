using IB.SM.Business;
using IB.SM.Exceptions;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.SysAdmin
{
    public partial class frmUsuarios : Form
    {
        private IUserController ucController { get; set; }
        private IGroupController grController { get; set; }
        private IUtil util { get; set; }

        private static string senhaDefault = "SenhANãoAlterada";

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            ucController = new UserController();
            grController = new GroupController();
            util = new Util();
            this.Limpa_Form();
            CarregaTreeView();
            CarregaCombos();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvDados_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strNome = this.tvDados.SelectedNode.Text.ToString();
            carregaDadosTextBox(strNome);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (!String.IsNullOrEmpty(txtNome.Text))
            {
                try
                {
                    Usuario usr = PreencheUsuario();
                    if (usr.ID != 0)
                        result = MessageBox.Show("Deseja alterar o registro selecionado ? ", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                        return;

                    usr = ucController.Salvar(usr);
                    txtID.Text = usr.ID.ToString();
                    MessageBox.Show("Registros inseridos com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome do Grupo", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtID.Text != null))
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado ? ", "Excluir", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        Usuario usr = ucController.BuscarporID(Convert.ToInt16(txtID.Text), true);
                        ucController.Excluir(usr);
                        MessageBox.Show("Registro excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpar.PerformClick();
                        CarregaTreeView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o Usuário.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpa_Form();
            txtNome.Focus();
        }

        #region KeyPress - KeyDown - Leave - Enter / Para campos padroes.

        private void ChangeFocus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void ChangeFocus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }

        private void MudaCor_Leave(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ((ComboBox)sender).BackColor = Color.Empty;
            }
            else if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.Empty;
            }
            else if (sender is DateTimePicker)
            {
                ((DateTimePicker)sender).BackColor = Color.Empty;
            }
        }

        private void MudaCor_Enter(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ((ComboBox)sender).BackColor = Color.FromArgb(255, 255, 192);
            }
            else if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Color.FromArgb(255, 255, 192);
            }
            else if (sender is DateTimePicker)
            {
                ((DateTimePicker)sender).BackColor = Color.FromArgb(255, 255, 192);
            }
        }

        #endregion

        #region Função HabilitaDesabilitaCampos

        private void HabilitaDesabilitaCampos(Control container, bool value)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl.Controls.Count > 0)
                    HabilitaDesabilitaCampos(ctrl, value);
                ctrl.Enabled = value;
            }
        }

        #endregion

        #region Função PreencheUsuario

        private Usuario PreencheUsuario()
        {
            Usuario retorno = new Usuario();
            try
            {

                if (!String.IsNullOrEmpty(txtID.Text))
                {
                    retorno = ucController.BuscarporID(Convert.ToInt16(txtID.Text), true);
                }

                retorno.Nome = txtNome.Text;
                retorno.Descricao = txtDescricao.Text;
                retorno.Login = txtUsuario.Text;

                if (ValidaSenha())
                    retorno.Senha = util.encrypt(txtSenha1.Text);

                retorno.Alterasenha = chkPodeAlterar.Checked;
                retorno.Senhaexpira = chkSenhaExpira.Checked;

                if (chkAlterarSenha.Checked)
                    retorno.Dataexpirar = DateTime.Now.AddDays(-1);
                else
                    retorno.Dataexpirar = DateTime.Now.AddDays(60);

                retorno.Ativo = Convert.ToBoolean(cmbStatus.SelectedValue);
                retorno.Ultimoupdate = DateTime.Now;
                retorno.Grupo_ID = Convert.ToInt16(cmbGrupo.SelectedValue);
                retorno.Grupo = grController.BuscarporID(Convert.ToInt16(cmbGrupo.SelectedValue));



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;

        }

        #endregion

        #region Função ValidaSenha

        private bool ValidaSenha()
        {
            bool retorno = false;

            if (txtSenha1.Text != senhaDefault)
            {
                if (txtSenha1.Text.Equals(txtSenha2.Text))
                    retorno = true;
                else
                    throw new SenhaDiferentedaConfirmacao();
            }
            if (String.IsNullOrEmpty(txtSenha1.Text))
            {
                throw new SenhaNaoPodeSerVazio();
            }
            return retorno;
        }

        #endregion

        #region Função Limpar Form

        private void Limpa_Form()
        {
            Limpa_Form(true);
        }

        private void Limpa_Form(bool tudo)
        {
            AppFunc.ResetFields(this);
            CarregaTreeView();
            CarregaCombos();
            chkAlterarSenha.Checked = false;
            chkPodeAlterar.Checked = true;
            chkSenhaExpira.Checked = true;
        }

        #endregion

        #region Função CarregaTreeView

        private void CarregaTreeView()
        {
            tvDados.Nodes.Clear();
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                usuarios = ucController.ListarTodos().ToList();
                foreach (Usuario u in usuarios)
                {
                    tvDados.Nodes.Add(u.Login);
                }
                foreach (TreeNode n in tvDados.Nodes)
                {
                    if (n.Text == txtUsuario.Text)
                    {
                        tvDados.SelectedNode = n;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Função CarregaCombos

        private void CarregaCombos()
        {
            //Carregar Combo do Status do Cliente
            ArrayList Status = new ArrayList();
            Status.Add(new CriaLista("Ativo", "true"));
            Status.Add(new CriaLista("Inativo", "false"));
            cmbStatus.DataSource = Status;
            cmbStatus.DisplayMember = "Display";
            cmbStatus.ValueMember = "Value";

            try
            {
                cmbGrupo.DataSource = grController.ListarTodos().ToList();
                cmbGrupo.ValueMember = "ID";
                cmbGrupo.DisplayMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        #region Função carregaDadosTextBox

        private void carregaDadosTextBox(string strLogin)
        {
            try
            {
                Usuario usr = ucController.BuscaporLogin(strLogin, true);
                ValidaPermissoes(usr);
                if (usr != null)
                {
                    txtID.Text = usr.ID.ToString();
                    txtNome.Text = usr.Nome;
                    txtDescricao.Text = usr.Descricao;
                    txtUsuario.Text = usr.Login;

                    chkSenhaExpira.Checked = usr.Senhaexpira;
                    chkPodeAlterar.Checked = usr.Alterasenha;


                    chkAlterarSenha.Checked = (usr.Dataexpirar < DateTime.Now);

                    txtSenha1.Text = senhaDefault;

                    txtSenha2.Text = senhaDefault;

                    if (usr.Grupo != null)
                    {
                        cmbGrupo.SelectedValue = usr.Grupo.ID;
                    }
                    else
                    {
                        cmbGrupo.SelectedValue = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        #region Função ValidaPermissoes

        private void ValidaPermissoes(Usuario usr)
        {
            try
            {
                if (!Instancia.instanciaP.FindUser)
                    return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        private void chkAlterarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlterarSenha.Checked)
            {
                chkPodeAlterar.Checked = true;
                chkSenhaExpira.Checked = true;
            }
        }

        private void chkSenhaExpira_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenhaExpira.Checked)
            {
                chkPodeAlterar.Checked = true;
            }
            else
            {
                chkAlterarSenha.Checked = false;
            }

        }

        private void chkPodeAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPodeAlterar.Checked)
            {
                chkSenhaExpira.Checked = false;
                chkAlterarSenha.Checked = false;
            }
        }
    }
}

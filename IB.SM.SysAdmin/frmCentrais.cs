using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace IB.SM.SysAdmin
{
    public partial class frmCentrais : Form
    {
        bool allowSpace = false;
        private ICentralController ctController { get; set; }

        public frmCentrais()
        {
            InitializeComponent();
        }

        private void frmCentrais_Load(object sender, EventArgs e)
        {
            ctController = new CentralController();
            this.Limpa_Form();
            CarregaTreeView();
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
                    Central ct = PreencheCentral();
                    if (ct.ID != 0)
                        result = MessageBox.Show("Deseja alterar o registro selecionado ? ", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                        return;

                    ct = ctController.Salvar(ct);
                    txtID.Text = ct.ID.ToString();
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
                        Central ct = ctController.BuscarporID(Convert.ToInt16(txtID.Text), true);
                        ctController.Excluir(ct);
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
                MessageBox.Show("Selecione a Central.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpa_Form();
            txtEnd.Focus();
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

        private void txtEnd_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            //    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            //    {
            //     // Let the edit control handle control and alt key combinations
            //    }
            else if (this.allowSpace && e.KeyChar == ' ')
            {

            }
            else
            {
                // Swallow this invalid key and beep
                e.Handled = true;
                //    MessageBeep();
            }
        }

        private void txtEnd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEnd.Text))
                txtEnd.Text = "0";
        }
        #region Funções

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

        #region Função PreencheCentral

        private Central PreencheCentral()
        {
            Central retorno = new Central();
            try
            {

                if (!String.IsNullOrEmpty(txtID.Text))
                {
                    retorno = ctController.BuscarporID(Convert.ToInt16(txtID.Text), true);
                }

                retorno.Nome = txtNome.Text;
                retorno.Descricao = txtDescricao.Text;
                retorno.Endereco = String.IsNullOrEmpty(txtEnd.Text) ? 0 : Convert.ToInt16(txtEnd.Text);
                retorno.Ultimoupdate = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Central", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtEnd.Text = "0";
        }

        #endregion

        #region Função CarregaTreeView

        private void CarregaTreeView()
        {
            tvDados.Nodes.Clear();
            try
            {
                List<Central> centrais = new List<Central>();

                centrais = ctController.ListarTodos().ToList();
                foreach (Central c in centrais)
                {
                    tvDados.Nodes.Add(c.Nome);
                }
                foreach (TreeNode n in tvDados.Nodes)
                {
                    if (n.Text == txtNome.Text)
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

        #region Função carregaDadosTextBox

        private void carregaDadosTextBox(string strNome)
        {
            try
            {
                Central ct = ctController.BuscaporNome(strNome, true);
                ValidaPermissoes(ct);
                if (ct != null)
                {
                    txtID.Text = ct.ID.ToString();
                    txtEnd.Text = ct.Endereco.ToString();
                    txtNome.Text = ct.Nome;
                    txtDescricao.Text = ct.Descricao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        #region Função ValidaPermissoes

        private void ValidaPermissoes(Central obj)
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

#endregion
    }
}

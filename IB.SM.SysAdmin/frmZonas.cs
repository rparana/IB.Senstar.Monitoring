using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.SysAdmin
{
    public partial class frmZonas : Form
    {
        bool allowSpace = false;
        private IZonesController znController { get; set; }
        private ICentralController ctController { get; set; }

        public frmZonas()
        {
            InitializeComponent();
        }

        private void frmZonas_Load(object sender, EventArgs e)
        {
            ctController = new CentralController();
            znController = new ZonesController();
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
                    Zone zn = PreencheZona();
                    if (zn.ID != 0)
                        result = MessageBox.Show("Deseja alterar o registro selecionado ? ", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                        return;

                    zn = znController.Salvar(zn,true);
                    txtID.Text = zn.ID.ToString();
                    MessageBox.Show("Registros Salvo com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome da Zona", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        Zone zn = znController.BuscarporID(Convert.ToInt16(txtID.Text), true);
                        znController.Excluir(zn);
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
                MessageBox.Show("Selecione a Zona.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void numeric_OnKeyPress(object sender, KeyPressEventArgs e)
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

        private void numeric_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(((TextBox)sender).Text))
                ((TextBox)sender).Text = "0";
        }
 
       #endregion

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

        #region Função PreencheZona

        private Zone PreencheZona()
        {
            Zone retorno = new Zone();
            try
            {

                if (!String.IsNullOrEmpty(txtID.Text))
                {
                    retorno = znController.BuscarporID(Convert.ToInt16(txtID.Text), true);
                }

                retorno.Nome = txtNome.Text;
                retorno.NumeroZona = String.IsNullOrEmpty(txtEnd.Text) ? 0 : Convert.ToInt16(txtEnd.Text);
                retorno.NumeroZonaCentral = String.IsNullOrEmpty(txtNumCentral.Text) ? 0 : Convert.ToInt16(txtNumCentral.Text);
                retorno.Central_ID = Convert.ToInt16(cmbCentral.SelectedValue);
                retorno.Central = ctController.BuscarporID(Convert.ToInt16(cmbCentral.SelectedValue));
                retorno.Lado = cmbLado.SelectedValue.ToString();
                retorno.Inicio = Convert.ToInt16(txtIni.Text);
                retorno.Fim = Convert.ToInt16(txtFim.Text);
                retorno.Ultimoupdate = DateTime.Now;
                retorno.x1 = float.Parse(txtx1.Text);
                retorno.y1 = float.Parse(txty1.Text);
                retorno.x2 = float.Parse(txtx2.Text);
                retorno.y2 = float.Parse(txty2.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Zonas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtNumCentral.Text = "0";
            txtEnd.Text = "0";
            txtIni.Text = "0";
            txtFim.Text = "0";
            txtx1.Text = "0";
            txty1.Text = "0";
            txtx2.Text = "0";
            txty2.Text = "0";
        }

        #endregion

        #region Função CarregaTreeView

        private void CarregaTreeView()
        {
            tvDados.Nodes.Clear();
            try
            {
                List<Zone> zonas = new List<Zone>();

                zonas = znController.ListarTodos().ToList();
                foreach (Zone c in zonas)
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
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        #region Função CarregaCombos

        private void CarregaCombos()
        {
            //Carregar Combo do Status do Cliente
            ArrayList Status = new ArrayList();
            Status.Add(new CriaLista("Lado A", "A"));
            Status.Add(new CriaLista("Lado B", "B"));
            cmbLado.DataSource = Status;
            cmbLado.DisplayMember = "Display";
            cmbLado.ValueMember = "Value";

            try
            {
                cmbCentral.DataSource = ctController.ListarTodos().ToList();
                cmbCentral.ValueMember = "ID";
                cmbCentral.DisplayMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        #region Função carregaDadosTextBox

        private void carregaDadosTextBox(string strNome)
        {
            try
            {
                Zone zn = znController.BuscaporNome(strNome, true);
                ValidaPermissoes(zn);
                if (zn != null)
                {
                    txtID.Text = zn.ID.ToString();
                    txtEnd.Text = zn.NumeroZona.ToString();
                    txtNumCentral.Text = zn.NumeroZonaCentral.ToString();
                    txtNome.Text = zn.Nome;
                    txtIni.Text = zn.Inicio.ToString();
                    txtFim.Text = zn.Fim.ToString();
                    txtx1.Text = zn.x1.ToString();
                    txty1.Text = zn.y1.ToString();
                    txtx2.Text = zn.x2.ToString();
                    txty2.Text = zn.y2.ToString();
                    if (!String.IsNullOrEmpty(zn.Lado))
                    {
                        cmbLado.SelectedValue = zn.Lado;
                    }
                    else
                    {
                        cmbLado.SelectedValue = "A";
                    }

                    if(zn.Central!=null)
                    {
                        cmbCentral.SelectedValue = zn.Central.ID;
                    }
                    else
                    {
                        cmbCentral.SelectedIndex = 0;
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

        private void ValidaPermissoes(Zone obj)
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

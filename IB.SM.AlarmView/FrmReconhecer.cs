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
    public partial class FrmReconhecer : Form
    {

        private IEventsController evController { get; set; }
        public List<ViewEvents> dt = new List<ViewEvents>();
        public ViewEvents ve = new ViewEvents();
        private int indexVE = 0;
        private DialogResult retornoForm = DialogResult.Cancel;

        public FrmReconhecer()
        {
            InitializeComponent();
        }

        private void FrmReconhecer_Load(object sender, EventArgs e)
        {
            evController = new EventsController();
            CarregaEventos();
        }

        private void CarregaEventos()
        {
            if (dt.Count <= 0)
            {
                this.Close();
                return;
            }

            lblDThr.Text = dt[indexVE].Data_Hora.ToString();
            lblCentral.Text = dt[indexVE].Central;
            lblLado.Text = dt[indexVE].Lado;
            lblDist.Text = dt[indexVE].Distancia;
            lblZona.Text = dt[indexVE].Zona;

            lblQtde.Text = (indexVE + 1).ToString() + "/" + dt.Count.ToString();

            EnableDisableButtons();
        }

        private void EnableDisableButtons()
        {
            btnPrev.Enabled = (indexVE > 0);
            btnNext.Enabled = (indexVE < (dt.Count - 1));
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            indexVE = 0;
            CarregaEventos();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            indexVE--;
            CarregaEventos();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            indexVE++;
            CarregaEventos();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            indexVE = dt.Count - 1;
            CarregaEventos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesc.Text.Trim()))
            {
                MessageBox.Show("É necessário informar alguma descrição.", "Reconhecimento de Alarme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                evController.ReconheceEvento(dt[indexVE].ID, txtDesc.Text);
                dt.Remove(dt[indexVE]);
                txtDesc.Text = String.Empty;
                if (indexVE >(dt.Count-1))
                {
                    indexVE--;
                }
                retornoForm = DialogResult.OK;
                CarregaEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmReconhecer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = retornoForm;
        }
    }
}

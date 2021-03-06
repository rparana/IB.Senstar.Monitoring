﻿using IB.SM.Business;
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

namespace IB.SM.AlarmView
{
    public partial class FrmRelatorios : Form
    {
        private ICentralController ctController { get; set; }
        private IZonesController znController { get; set; }
        private IEventsController evController { get; set; }
        private List<ReportViewer> rvList = new List<ReportViewer>();

        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            ArrayList TipoRel = new ArrayList();
            TipoRel.Add(new CriaLista("Relatório de Eventos Reconhecidos.", "0"));
            TipoRel.Add(new CriaLista("Relatório de Eventos (Todos).", "1"));
            cmbTipoRel.DataSource = TipoRel;
            cmbTipoRel.DisplayMember = "Display";
            cmbTipoRel.ValueMember = "Value";

            string dtIni = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " 00:00:00";
            string dtFim = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " 23:59:59";
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpInicio.Value = DateTime.Parse(dtIni);
            dtpFim.Value = DateTime.Parse(dtFim);

            znController = new ZonesController();
            ctController = new CentralController();
            evController = new EventsController();

            this.Limpa_Form();
            CarregaCentrais();
        }

        #region Função Limpar Form

        private void Limpa_Form()
        {
            Limpa_Form(true);
        }

        private void Limpa_Form(bool tudo)
        {
            AppFunc.ResetFields(this);
            CarregaCentrais();
        }

        #endregion

        #region Função CarregaTreeView

        private void CarregaCentrais()
        {
            clbCentrais.Items.Clear();
            try
            {
                List<Central> centrais = new List<Central>();

                centrais = ctController.ListarTodos().ToList();
                foreach (Central c in centrais)
                {
                    clbCentrais.Items.Add(c.Nome);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void clbCentrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bool selected = false;
            //string curItem = ((CheckedListBox)sender).SelectedItem.ToString();
            //foreach (object itemChecked in clbCentrais.CheckedItems)
            //{
            //    if (curItem == itemChecked)
            //    {
            //        selected = true;
            //    }
            //}
            //AtualizaZonas(curItem, selected);
            //if (!selected)
            //    chkTodos1.Checked = false;
        }

        private void AtualizaZonas(string strCentral, bool _checked)
        {
            try
            {
                Central central = ctController.BuscaporNome(strCentral, true);
                List<Zone> zonas = new List<Zone>();

                if (central != null)
                {
                    zonas = central.Zonas.ToList();
                }
                foreach (Zone c in zonas)
                {
                    if (_checked)
                    {
                        if (clbZonas.FindString(c.Nome) < 0)
                        {
                            clbZonas.Items.Add(c.Nome, chkTodos2.Checked);
                        }
                    }
                    else
                    {
                        clbZonas.Items.Remove(c.Nome);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void chkTodos1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkTodos2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkTodos1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbCentrais.Items.Count; i++)
            {
                clbCentrais.SetItemChecked(i, chkTodos1.Checked);
                //AtualizaZonas(clbCentrais.Items[i].ToString(), chkTodos1.Checked);
            }
        }

        private void chkTodos2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbZonas.Items.Count; i++)
            {
                clbZonas.SetItemChecked(i, chkTodos2.Checked);
            }
        }

        private void clbZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void clbZonas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool selected = (e.NewValue == CheckState.Checked);
            string curItem = ((CheckedListBox)sender).Items[e.Index].ToString();
            if (!selected)
                chkTodos2.Checked = false;
        }

        private void clbCentrais_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool selected = (e.NewValue == CheckState.Checked);
            string curItem = ((CheckedListBox)sender).Items[e.Index].ToString();
            //foreach (object itemChecked in clbCentrais.CheckedItems)
            //{
            //    if (curItem == itemChecked)
            //    {
            //        selected = true;
            //    }
            //}
            AtualizaZonas(curItem, selected);
            if (!selected)
                chkTodos1.Checked = false;

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    PreparaRelatorio();
                    FrmReport frm = new FrmReport();
                    frm.rvList = rvList;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PreparaRelatorio()
        {
            List<Zone> lz = new List<Zone>();
            Zone zn = new Zone();
            switch (cmbTipoRel.SelectedValue)
            {
                case "0":
                default:
                    lz = new List<Zone>();

                    foreach (object itemChecked in clbZonas.CheckedItems)
                    {
                        zn = znController.BuscaporNome(itemChecked.ToString(), true);
                        lz.Add(zn);
                    }

                    rvList = evController.GeraRelatorio(0, dtpInicio.Value, dtpFim.Value, lz);
                    break;
                case "1":
                    lz = new List<Zone>();

                    foreach (object itemChecked in clbZonas.CheckedItems)
                    {
                        zn = znController.BuscaporNome(itemChecked.ToString(), true);
                        lz.Add(zn);
                    }

                    rvList = evController.GeraRelatorio(1, dtpInicio.Value, dtpFim.Value, lz);
                    break;
            }
        }

        private bool ValidaCampos()
        {
            bool retorno = true;

            if (dtpInicio.Value > dtpFim.Value)
            {

                retorno = false;
                throw new Exception("A data final não pode ser menor que a data inicial! Verifique.");
            }

            if (clbCentrais.CheckedItems.Count <= 0)
            {
                retorno = false;
                throw new Exception("Nenhuma central selecionada! Verifique.");
            }

            if (clbZonas.CheckedItems.Count <= 0)
            {
                retorno = false;
                throw new Exception("Nenhuma zona selecionada! Verifique.");
            }

            return retorno;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

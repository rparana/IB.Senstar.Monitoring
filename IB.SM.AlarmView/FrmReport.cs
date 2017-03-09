using IB.SM.Model.Entities;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReport : Form
    {
        public List<Model.Entities.ReportViewer> rvList = new List<Model.Entities.ReportViewer>();
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("ReportView", rvList);
            this.rptv1.LocalReport.DataSources.Clear();
            rptv1.LocalReport.ReportEmbeddedResource = "IB.SM.AlarmView.Relatórios.RelatorioReconhecimento.rdlc";
            rptv1.LocalReport.DataSources.Add(rds);
            rds.Value = rvList;
            rptv1.SetDisplayMode(DisplayMode.PrintLayout);
            
            rptv1.ZoomMode = ZoomMode.Percent;
            rptv1.ZoomPercent = 100;
            rptv1.LocalReport.Refresh();
            this.rptv1.RefreshReport();
        }
    }
}

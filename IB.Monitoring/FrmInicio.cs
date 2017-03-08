using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.Monitoring
{
    public partial class FrmInicio : Form
    {

        private FileInfo[] files;

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread trd = new Thread(new ThreadStart(this.ThreadTarefa));
            trd.IsBackground = true;
            trd.Start();


        }
        private void ThreadTarefa()
        {
            IEventsController ec = new EventsController();

            LogFile filelog = new LogFile();
            files = ec.listFiles(@"D:\rparana\Profile\OneDrive\IB Tecnologia\Clientes\Beau Rivage\Desenvolvimento\Logs");
            List<SenstarEvents> se = new List<SenstarEvents>();
            foreach (FileInfo file in files)
            {
                if (!ec.alreadyread(file.Name, file.Length))
                {
                    se = ec.readRecordLogs(file.FullName, true, true, Path.Combine(Path.GetDirectoryName(file.FullName), "IB"),prb01);
                    filelog = ec.recordFileRead(file.Name, file.Length);
                }
            }
            //dtv1.DataSource = se;
            lblTotal.Text = se.Count().ToString();
        }

        private void btnFolder01_Click(object sender, EventArgs e)
        {
            string folder = String.Empty;
            DialogResult result = fBD01.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolder01.Text = fBD01.SelectedPath;

                AtualizarLista();
            }
        }

        private void AtualizarLista()
        {
            IEventsController ec = new EventsController();

            if (txtFolder01.Text != String.Empty)
            {
                LogFile filelog = new LogFile();
                files = ec.listFiles(txtFolder01.Text);
                lstFiles.DataSource = files;
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            string path;
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = (System.IO.Path.GetDirectoryName(executable));
            txtFolder01.Text = path;
            fBD01.SelectedPath = path;
            AtualizarLista();
        }

        private void chkMoveAfter_CheckedChanged(object sender, EventArgs e)
        {
            btnFolder02.Enabled = chkMoveAfter.Checked;

        }

        private void btnFolder02_Click(object sender, EventArgs e)
        {
            DialogResult result = fBD01.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolder02.Text = fBD01.SelectedPath;

            }
        }
    }
}

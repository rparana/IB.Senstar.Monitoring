using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace IB.SM.Testes
{
    public partial class Form1 : Form
    {
        bool blink = false;
        public Form1()
        {
            InitializeComponent();
        }

        protected void Client_Closing(object sender, CancelEventArgs e)

        {

            System.Environment.Exit(System.Environment.ExitCode);

        }

        // Start Button
        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // Stop Button
        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            // Clear
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Make sure timer is started
            if (timer1.Enabled)
            {
                if (!blink)
                {
                    e.Graphics.FillRectangle(Brushes.Red, new Rectangle(10, 10, 100, 100));
                    blink = true;
                }
                else if (blink)
                {
                    blink = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Fire "Paint" event
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

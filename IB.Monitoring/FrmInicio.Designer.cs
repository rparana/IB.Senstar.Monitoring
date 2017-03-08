namespace IB.Monitoring
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.prb01 = new System.Windows.Forms.ProgressBar();
            this.bgW01 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.senstarEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fBD01 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFolder01 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkMoveAfter = new System.Windows.Forms.CheckBox();
            this.btnFolder02 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolder02 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.senstarEventsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Testar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(467, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 25);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prb01
            // 
            this.prb01.Location = new System.Drawing.Point(197, 406);
            this.prb01.Name = "prb01";
            this.prb01.Size = new System.Drawing.Size(207, 23);
            this.prb01.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // senstarEventsBindingSource
            // 
            this.senstarEventsBindingSource.DataSource = typeof(IB.SM.Model.Entities.SenstarEvents);
            // 
            // txtFolder01
            // 
            this.txtFolder01.Enabled = false;
            this.txtFolder01.Location = new System.Drawing.Point(6, 36);
            this.txtFolder01.Name = "txtFolder01";
            this.txtFolder01.Size = new System.Drawing.Size(267, 20);
            this.txtFolder01.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMoveAfter);
            this.groupBox1.Controls.Add(this.lstFiles);
            this.groupBox1.Controls.Add(this.txtFolder02);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFolder01);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFolder02);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnFolder01);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos de Log";
            // 
            // btnFolder01
            // 
            this.btnFolder01.Location = new System.Drawing.Point(279, 36);
            this.btnFolder01.Name = "btnFolder01";
            this.btnFolder01.Size = new System.Drawing.Size(26, 20);
            this.btnFolder01.TabIndex = 1;
            this.btnFolder01.Text = "...";
            this.btnFolder01.UseVisualStyleBackColor = true;
            this.btnFolder01.Click += new System.EventHandler(this.btnFolder01_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFolder01_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.CheckOnClick = true;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(6, 62);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(331, 184);
            this.lstFiles.TabIndex = 7;
            // 
            // chkMoveAfter
            // 
            this.chkMoveAfter.AutoSize = true;
            this.chkMoveAfter.Location = new System.Drawing.Point(6, 252);
            this.chkMoveAfter.Name = "chkMoveAfter";
            this.chkMoveAfter.Size = new System.Drawing.Size(113, 17);
            this.chkMoveAfter.TabIndex = 7;
            this.chkMoveAfter.Text = "Mover após leitura";
            this.chkMoveAfter.UseVisualStyleBackColor = true;
            this.chkMoveAfter.CheckedChanged += new System.EventHandler(this.chkMoveAfter_CheckedChanged);
            // 
            // btnFolder02
            // 
            this.btnFolder02.Location = new System.Drawing.Point(311, 288);
            this.btnFolder02.Name = "btnFolder02";
            this.btnFolder02.Size = new System.Drawing.Size(26, 20);
            this.btnFolder02.TabIndex = 1;
            this.btnFolder02.Text = "...";
            this.btnFolder02.UseVisualStyleBackColor = true;
            this.btnFolder02.Click += new System.EventHandler(this.btnFolder02_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destino";
            // 
            // txtFolder02
            // 
            this.txtFolder02.Enabled = false;
            this.txtFolder02.Location = new System.Drawing.Point(6, 288);
            this.txtFolder02.Name = "txtFolder02";
            this.txtFolder02.Size = new System.Drawing.Size(299, 20);
            this.txtFolder02.TabIndex = 5;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prb01);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmInicio";
            this.Text = "Coletor de Logs";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.senstarEventsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource senstarEventsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.ComponentModel.BackgroundWorker bgW01;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar prb01;
        private System.Windows.Forms.FolderBrowserDialog fBD01;
        private System.Windows.Forms.TextBox txtFolder01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFolder01;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox lstFiles;
        private System.Windows.Forms.CheckBox chkMoveAfter;
        private System.Windows.Forms.TextBox txtFolder02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFolder02;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


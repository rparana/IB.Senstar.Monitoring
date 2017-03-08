namespace IB.SM.AlarmView
{
    partial class FrmReconhecer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReconhecer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDist = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblZona = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCentral = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDThr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDist);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.lblQtde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.lblZona);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCentral);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDThr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Alarme";
            // 
            // lblDist
            // 
            this.lblDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDist.Location = new System.Drawing.Point(294, 70);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(51, 23);
            this.lblDist.TabIndex = 7;
            this.lblDist.Text = "lblDist";
            this.lblDist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dist.:";
            // 
            // lblLado
            // 
            this.lblLado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLado.Location = new System.Drawing.Point(234, 70);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(51, 23);
            this.lblLado.TabIndex = 5;
            this.lblLado.Text = "lblLado";
            this.lblLado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lado:";
            // 
            // btnLast
            // 
            this.btnLast.Image = global::IB.SM.AlarmView.Properties.Resources.resultset_last;
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLast.Location = new System.Drawing.Point(319, 19);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(26, 22);
            this.btnLast.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnLast, "Último");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(6, 159);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(339, 124);
            this.txtDesc.TabIndex = 11;
            // 
            // lblQtde
            // 
            this.lblQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQtde.Location = new System.Drawing.Point(235, 19);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(51, 22);
            this.lblQtde.TabIndex = 16;
            this.lblQtde.Text = "lblQtde";
            this.lblQtde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nota:";
            // 
            // btnNext
            // 
            this.btnNext.Image = global::IB.SM.AlarmView.Properties.Resources.resultset_next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(292, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 22);
            this.btnNext.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnNext, "Próximo");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblZona
            // 
            this.lblZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZona.Location = new System.Drawing.Point(6, 111);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(339, 23);
            this.lblZona.TabIndex = 9;
            this.lblZona.Text = "lblZona";
            this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::IB.SM.AlarmView.Properties.Resources.resultset_previous;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(203, 19);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(26, 22);
            this.btnPrev.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnPrev, "Anterior");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = global::IB.SM.AlarmView.Properties.Resources.resultset_first;
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirst.Location = new System.Drawing.Point(176, 19);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(26, 22);
            this.btnFirst.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnFirst, "Primeiro");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zona:";
            // 
            // lblCentral
            // 
            this.lblCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentral.Location = new System.Drawing.Point(6, 70);
            this.lblCentral.Name = "lblCentral";
            this.lblCentral.Size = new System.Drawing.Size(219, 23);
            this.lblCentral.TabIndex = 3;
            this.lblCentral.Text = "lblCentral";
            this.lblCentral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Central:";
            // 
            // lblDThr
            // 
            this.lblDThr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDThr.Location = new System.Drawing.Point(6, 29);
            this.lblDThr.Name = "lblDThr";
            this.lblDThr.Size = new System.Drawing.Size(117, 23);
            this.lblDThr.TabIndex = 1;
            this.lblDThr.Text = "lblDThr";
            this.lblDThr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data / Hora:";
            // 
            // btnSair
            // 
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(188, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(175, 28);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Fechar";
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(12, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 28);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Reconhecer";
            this.toolTip1.SetToolTip(this.btnSalvar, "Reconhecer");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmReconhecer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 345);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReconhecer";
            this.Text = "Reconhecimento de Alarmes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReconhecer_FormClosing);
            this.Load += new System.EventHandler(this.FrmReconhecer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDThr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCentral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}
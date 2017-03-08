namespace IB.SM.SysAdmin
{
    partial class frmZonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZonas));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumCentral = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCentral = new System.Windows.Forms.ComboBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tvDados = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txty1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = global::IB.SM.SysAdmin.Properties.Resources.Exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(376, 244);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 28);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::IB.SM.SysAdmin.Properties.Resources.trash_can_delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(255, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 28);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::IB.SM.SysAdmin.Properties.Resources.Appedit;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(134, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 28);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::IB.SM.SysAdmin.Properties.Resources.Plus_Box_Green;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(12, 244);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 28);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.groupBox1);
            this.pnlDados.Controls.Add(this.txtFim);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.txtIni);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.cmbLado);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.txtNumCentral);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.cmbCentral);
            this.pnlDados.Controls.Add(this.txtEnd);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtID);
            this.pnlDados.Controls.Add(this.lblUsuario);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Location = new System.Drawing.Point(234, 12);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(257, 226);
            this.pnlDados.TabIndex = 0;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(188, 137);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(59, 20);
            this.txtFim.TabIndex = 14;
            this.txtFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txtFim.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Término (m)";
            // 
            // txtIni
            // 
            this.txtIni.Location = new System.Drawing.Point(123, 137);
            this.txtIni.Name = "txtIni";
            this.txtIni.Size = new System.Drawing.Size(59, 20);
            this.txtIni.TabIndex = 12;
            this.txtIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txtIni.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inicio (m)";
            // 
            // cmbLado
            // 
            this.cmbLado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLado.FormattingEnabled = true;
            this.cmbLado.ItemHeight = 13;
            this.cmbLado.Location = new System.Drawing.Point(9, 136);
            this.cmbLado.MaxLength = 150;
            this.cmbLado.Name = "cmbLado";
            this.cmbLado.Size = new System.Drawing.Size(108, 21);
            this.cmbLado.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lado";
            // 
            // txtNumCentral
            // 
            this.txtNumCentral.Location = new System.Drawing.Point(167, 96);
            this.txtNumCentral.Name = "txtNumCentral";
            this.txtNumCentral.Size = new System.Drawing.Size(80, 20);
            this.txtNumCentral.TabIndex = 8;
            this.txtNumCentral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txtNumCentral.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zona na Central";
            // 
            // cmbCentral
            // 
            this.cmbCentral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCentral.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCentral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentral.FormattingEnabled = true;
            this.cmbCentral.ItemHeight = 13;
            this.cmbCentral.Location = new System.Drawing.Point(9, 96);
            this.cmbCentral.MaxLength = 150;
            this.cmbCentral.Name = "cmbCentral";
            this.cmbCentral.Size = new System.Drawing.Size(152, 21);
            this.cmbCentral.TabIndex = 6;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(9, 19);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(52, 20);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txtEnd.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zona Nº";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(158, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Central";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tvDados);
            this.pnlList.Location = new System.Drawing.Point(12, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(216, 226);
            this.pnlList.TabIndex = 19;
            // 
            // tvDados
            // 
            this.tvDados.ImageIndex = 0;
            this.tvDados.ImageList = this.imageList1;
            this.tvDados.Location = new System.Drawing.Point(3, 3);
            this.tvDados.Name = "tvDados";
            this.tvDados.SelectedImageIndex = 1;
            this.tvDados.Size = new System.Drawing.Size(210, 218);
            this.tvDados.TabIndex = 20;
            this.tvDados.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDados_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "zone.png");
            this.imageList1.Images.SetKeyName(1, "check.png");
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(58, 31);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(43, 20);
            this.txty1.TabIndex = 18;
            this.txty1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txty1.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "y1";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(9, 31);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(43, 20);
            this.txtx1.TabIndex = 16;
            this.txtx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txtx1.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "x1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txty2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtx2);
            this.groupBox1.Controls.Add(this.txty1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtx1);
            this.groupBox1.Location = new System.Drawing.Point(9, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 58);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posição no Mapa (Avançado)";
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(156, 31);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(43, 20);
            this.txty2.TabIndex = 22;
            this.txty2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txty2.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "x2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "y2";
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(107, 31);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(43, 20);
            this.txtx2.TabIndex = 20;
            this.txtx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_OnKeyPress);
            this.txtx2.Leave += new System.EventHandler(this.numeric_Leave);
            // 
            // frmZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 282);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmZonas";
            this.Text = "Zonas";
            this.Load += new System.EventHandler(this.frmZonas_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TreeView tvDados;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbLado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumCentral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCentral;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtx1;
    }
}
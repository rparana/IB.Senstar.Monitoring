namespace IB.SM.Config
{
    partial class frmDbConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDbConfig));
            this.pnlSQLCE = new System.Windows.Forms.Panel();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtSQLCEPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFolder01 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSQLServer = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.cmbSQLDB = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cmbSQLServer = new System.Windows.Forms.ComboBox();
            this.rbtSQLAut = new System.Windows.Forms.RadioButton();
            this.rbtWinAut = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.btnRefreshSQLSRV = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSQLCE.SuspendLayout();
            this.pnlSQLServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSQLCE
            // 
            this.pnlSQLCE.BackColor = System.Drawing.Color.Transparent;
            this.pnlSQLCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSQLCE.Controls.Add(this.textBox2);
            this.pnlSQLCE.Controls.Add(this.textBox1);
            this.pnlSQLCE.Controls.Add(this.label3);
            this.pnlSQLCE.Controls.Add(this.txtSQLCEPath);
            this.pnlSQLCE.Controls.Add(this.label1);
            this.pnlSQLCE.Controls.Add(this.label2);
            this.pnlSQLCE.Controls.Add(this.btnFolder01);
            this.pnlSQLCE.Controls.Add(this.button1);
            this.pnlSQLCE.Location = new System.Drawing.Point(12, 52);
            this.pnlSQLCE.Name = "pnlSQLCE";
            this.pnlSQLCE.Size = new System.Drawing.Size(347, 189);
            this.pnlSQLCE.TabIndex = 0;
            // 
            // cmbProvider
            // 
            this.cmbProvider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.ItemHeight = 13;
            this.cmbProvider.Location = new System.Drawing.Point(12, 25);
            this.cmbProvider.MaxLength = 150;
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(238, 21);
            this.cmbProvider.TabIndex = 28;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(9, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(28, 13);
            this.lblGrupo.TabIndex = 27;
            this.lblGrupo.Text = "Tipo";
            // 
            // txtSQLCEPath
            // 
            this.txtSQLCEPath.Enabled = false;
            this.txtSQLCEPath.Location = new System.Drawing.Point(6, 20);
            this.txtSQLCEPath.Name = "txtSQLCEPath";
            this.txtSQLCEPath.Size = new System.Drawing.Size(299, 20);
            this.txtSQLCEPath.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Caminho";
            // 
            // btnFolder01
            // 
            this.btnFolder01.Location = new System.Drawing.Point(311, 20);
            this.btnFolder01.Name = "btnFolder01";
            this.btnFolder01.Size = new System.Drawing.Size(26, 20);
            this.btnFolder01.TabIndex = 29;
            this.btnFolder01.Text = "...";
            this.btnFolder01.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlSQLServer
            // 
            this.pnlSQLServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSQLServer.Controls.Add(this.textBox5);
            this.pnlSQLServer.Controls.Add(this.textBox4);
            this.pnlSQLServer.Controls.Add(this.button9);
            this.pnlSQLServer.Controls.Add(this.cmbSQLDB);
            this.pnlSQLServer.Controls.Add(this.label34);
            this.pnlSQLServer.Controls.Add(this.cmbSQLServer);
            this.pnlSQLServer.Controls.Add(this.rbtSQLAut);
            this.pnlSQLServer.Controls.Add(this.rbtWinAut);
            this.pnlSQLServer.Controls.Add(this.label30);
            this.pnlSQLServer.Controls.Add(this.button10);
            this.pnlSQLServer.Controls.Add(this.label32);
            this.pnlSQLServer.Controls.Add(this.btnRefreshSQLSRV);
            this.pnlSQLServer.Controls.Add(this.label33);
            this.pnlSQLServer.Location = new System.Drawing.Point(412, 57);
            this.pnlSQLServer.Name = "pnlSQLServer";
            this.pnlSQLServer.Size = new System.Drawing.Size(377, 184);
            this.pnlSQLServer.TabIndex = 29;
            this.pnlSQLServer.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(314, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 23);
            this.button9.TabIndex = 20;
            this.button9.TabStop = false;
            this.button9.Text = "Novo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // cmbSQLDB
            // 
            this.cmbSQLDB.FormattingEnabled = true;
            this.cmbSQLDB.Location = new System.Drawing.Point(8, 64);
            this.cmbSQLDB.Name = "cmbSQLDB";
            this.cmbSQLDB.Size = new System.Drawing.Size(299, 21);
            this.cmbSQLDB.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(5, 48);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(184, 13);
            this.label34.TabIndex = 18;
            this.label34.Text = "Selecione ou digite o nome do Banco";
            // 
            // cmbSQLServer
            // 
            this.cmbSQLServer.FormattingEnabled = true;
            this.cmbSQLServer.Location = new System.Drawing.Point(8, 20);
            this.cmbSQLServer.Name = "cmbSQLServer";
            this.cmbSQLServer.Size = new System.Drawing.Size(299, 21);
            this.cmbSQLServer.TabIndex = 17;
            // 
            // rbtSQLAut
            // 
            this.rbtSQLAut.AutoSize = true;
            this.rbtSQLAut.Location = new System.Drawing.Point(188, 90);
            this.rbtSQLAut.Name = "rbtSQLAut";
            this.rbtSQLAut.Size = new System.Drawing.Size(185, 17);
            this.rbtSQLAut.TabIndex = 22;
            this.rbtSQLAut.Text = "Usar autenticação do SQL Server";
            this.rbtSQLAut.UseVisualStyleBackColor = true;
            // 
            // rbtWinAut
            // 
            this.rbtWinAut.AutoSize = true;
            this.rbtWinAut.Checked = true;
            this.rbtWinAut.Location = new System.Drawing.Point(8, 91);
            this.rbtWinAut.Name = "rbtWinAut";
            this.rbtWinAut.Size = new System.Drawing.Size(174, 17);
            this.rbtWinAut.TabIndex = 21;
            this.rbtWinAut.TabStop = true;
            this.rbtWinAut.Text = "Usar autenticação do Windows";
            this.rbtWinAut.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(5, 109);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "Usuário";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(9, 151);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(173, 23);
            this.button10.TabIndex = 25;
            this.button10.TabStop = false;
            this.button10.Text = "Testar conexão";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(148, 109);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 13);
            this.label32.TabIndex = 10;
            this.label32.Text = "Senha";
            // 
            // btnRefreshSQLSRV
            // 
            this.btnRefreshSQLSRV.Location = new System.Drawing.Point(313, 20);
            this.btnRefreshSQLSRV.Name = "btnRefreshSQLSRV";
            this.btnRefreshSQLSRV.Size = new System.Drawing.Size(59, 23);
            this.btnRefreshSQLSRV.TabIndex = 18;
            this.btnRefreshSQLSRV.TabStop = false;
            this.btnRefreshSQLSRV.Text = "Atualizar";
            this.btnRefreshSQLSRV.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(5, 4);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "Servidor";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Confirme a Senha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 25;
            this.button1.TabStop = false;
            this.button1.Text = "Testar conexão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmDbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 483);
            this.Controls.Add(this.pnlSQLServer);
            this.Controls.Add(this.pnlSQLCE);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.lblGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDbConfig";
            this.Text = "Configuração de Banco de Dados";
            this.pnlSQLCE.ResumeLayout(false);
            this.pnlSQLCE.PerformLayout();
            this.pnlSQLServer.ResumeLayout(false);
            this.pnlSQLServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSQLCE;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtSQLCEPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFolder01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSQLServer;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox cmbSQLDB;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cmbSQLServer;
        private System.Windows.Forms.RadioButton rbtSQLAut;
        private System.Windows.Forms.RadioButton rbtWinAut;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnRefreshSQLSRV;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}
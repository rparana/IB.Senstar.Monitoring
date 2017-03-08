namespace IB.SM.Config
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkMoveAfter = new System.Windows.Forms.CheckBox();
            this.txtFolder02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolder01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFolder02 = new System.Windows.Forms.Button();
            this.btnFolder01 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarDadosIniciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefinirSenhaAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.chkMoveAfter);
            this.groupBox1.Controls.Add(this.txtFolder02);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFolder01);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFolder02);
            this.groupBox1.Controls.Add(this.btnFolder01);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos de Log";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(260, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 7;
            this.txtID.Visible = false;
            // 
            // chkMoveAfter
            // 
            this.chkMoveAfter.AutoSize = true;
            this.chkMoveAfter.Location = new System.Drawing.Point(9, 73);
            this.chkMoveAfter.Name = "chkMoveAfter";
            this.chkMoveAfter.Size = new System.Drawing.Size(113, 17);
            this.chkMoveAfter.TabIndex = 3;
            this.chkMoveAfter.Text = "Mover após leitura";
            this.chkMoveAfter.UseVisualStyleBackColor = true;
            this.chkMoveAfter.Click += new System.EventHandler(this.chkMoveAfter_Click);
            // 
            // txtFolder02
            // 
            this.txtFolder02.Location = new System.Drawing.Point(9, 119);
            this.txtFolder02.Name = "txtFolder02";
            this.txtFolder02.Size = new System.Drawing.Size(299, 20);
            this.txtFolder02.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destino dos logs após coleta";
            // 
            // txtFolder01
            // 
            this.txtFolder01.Location = new System.Drawing.Point(9, 47);
            this.txtFolder01.Name = "txtFolder01";
            this.txtFolder01.Size = new System.Drawing.Size(299, 20);
            this.txtFolder01.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local dos arquivos de log";
            // 
            // btnFolder02
            // 
            this.btnFolder02.Location = new System.Drawing.Point(314, 119);
            this.btnFolder02.Name = "btnFolder02";
            this.btnFolder02.Size = new System.Drawing.Size(26, 20);
            this.btnFolder02.TabIndex = 6;
            this.btnFolder02.Text = "...";
            this.btnFolder02.UseVisualStyleBackColor = true;
            this.btnFolder02.Click += new System.EventHandler(this.btnFolder02_Click);
            // 
            // btnFolder01
            // 
            this.btnFolder01.Location = new System.Drawing.Point(314, 47);
            this.btnFolder01.Name = "btnFolder01";
            this.btnFolder01.Size = new System.Drawing.Size(26, 20);
            this.btnFolder01.TabIndex = 2;
            this.btnFolder01.Text = "...";
            this.btnFolder01.UseVisualStyleBackColor = true;
            this.btnFolder01.Click += new System.EventHandler(this.btnFolder01_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(168, 36);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(193, 197);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(168, 36);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarDadosIniciaisToolStripMenuItem,
            this.redefinirSenhaAdminToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // criarDadosIniciaisToolStripMenuItem
            // 
            this.criarDadosIniciaisToolStripMenuItem.Name = "criarDadosIniciaisToolStripMenuItem";
            this.criarDadosIniciaisToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.criarDadosIniciaisToolStripMenuItem.Text = "Criar dados iniciais";
            this.criarDadosIniciaisToolStripMenuItem.Click += new System.EventHandler(this.criarDadosIniciaisToolStripMenuItem_Click);
            // 
            // redefinirSenhaAdminToolStripMenuItem
            // 
            this.redefinirSenhaAdminToolStripMenuItem.Name = "redefinirSenhaAdminToolStripMenuItem";
            this.redefinirSenhaAdminToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.redefinirSenhaAdminToolStripMenuItem.Text = "Redefinir Senha Admin";
            this.redefinirSenhaAdminToolStripMenuItem.Click += new System.EventHandler(this.redefinirSenhaAdminToolStripMenuItem_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 245);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMoveAfter;
        private System.Windows.Forms.TextBox txtFolder02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolder01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFolder02;
        private System.Windows.Forms.Button btnFolder01;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarDadosIniciaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redefinirSenhaAdminToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtID;
    }
}


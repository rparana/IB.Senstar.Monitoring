namespace IB.SM.SysAdmin
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposPermissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.efetuarLogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intrusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLblUsr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGrupos = new System.Windows.Forms.ToolStripButton();
            this.btnUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoToolStripMenuItem,
            this.intrusãoToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gruposPermissõesToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.toolStripSeparator1,
            this.alterarSenhaToolStripMenuItem,
            this.toolStripSeparator2,
            this.efetuarLogoffToolStripMenuItem,
            this.toolStripSeparator3,
            this.fecharToolStripMenuItem});
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.acessoToolStripMenuItem.Text = "Acesso";
            // 
            // gruposPermissõesToolStripMenuItem
            // 
            this.gruposPermissõesToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.GroupLock2;
            this.gruposPermissõesToolStripMenuItem.Name = "gruposPermissõesToolStripMenuItem";
            this.gruposPermissõesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gruposPermissõesToolStripMenuItem.Text = "Grupos / Permissões";
            this.gruposPermissõesToolStripMenuItem.Click += new System.EventHandler(this.gruposPermissõesToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.User;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.change_password;
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // efetuarLogoffToolStripMenuItem
            // 
            this.efetuarLogoffToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.lock__1_;
            this.efetuarLogoffToolStripMenuItem.Name = "efetuarLogoffToolStripMenuItem";
            this.efetuarLogoffToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.efetuarLogoffToolStripMenuItem.Text = "Efetuar logoff";
            this.efetuarLogoffToolStripMenuItem.Click += new System.EventHandler(this.efetuarLogoffToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.logout;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // intrusãoToolStripMenuItem
            // 
            this.intrusãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centraisToolStripMenuItem,
            this.zonasToolStripMenuItem,
            this.mapasToolStripMenuItem});
            this.intrusãoToolStripMenuItem.Name = "intrusãoToolStripMenuItem";
            this.intrusãoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.intrusãoToolStripMenuItem.Text = "Intrusão";
            // 
            // centraisToolStripMenuItem
            // 
            this.centraisToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.sensor2;
            this.centraisToolStripMenuItem.Name = "centraisToolStripMenuItem";
            this.centraisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.centraisToolStripMenuItem.Text = "Centrais";
            this.centraisToolStripMenuItem.Click += new System.EventHandler(this.centraisToolStripMenuItem_Click);
            // 
            // zonasToolStripMenuItem
            // 
            this.zonasToolStripMenuItem.Image = global::IB.SM.SysAdmin.Properties.Resources.zone;
            this.zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            this.zonasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zonasToolStripMenuItem.Text = "Zonas";
            this.zonasToolStripMenuItem.Click += new System.EventHandler(this.zonasToolStripMenuItem_Click);
            // 
            // mapasToolStripMenuItem
            // 
            this.mapasToolStripMenuItem.Name = "mapasToolStripMenuItem";
            this.mapasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.mapasToolStripMenuItem.Text = "Mapas";
            this.mapasToolStripMenuItem.Click += new System.EventHandler(this.mapasToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // configurarSistemaToolStripMenuItem
            // 
            this.configurarSistemaToolStripMenuItem.Name = "configurarSistemaToolStripMenuItem";
            this.configurarSistemaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.configurarSistemaToolStripMenuItem.Text = "Configurar Sistema";
            this.configurarSistemaToolStripMenuItem.Click += new System.EventHandler(this.configurarSistemaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLblUsr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSLblUsr
            // 
            this.tSSLblUsr.Name = "tSSLblUsr";
            this.tSSLblUsr.Size = new System.Drawing.Size(96, 17);
            this.tSSLblUsr.Text = "Usuário Logado: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrupos,
            this.btnUser,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGrupos
            // 
            this.btnGrupos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGrupos.Image = global::IB.SM.SysAdmin.Properties.Resources.GroupLock2;
            this.btnGrupos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(23, 22);
            this.btnGrupos.Text = "Grupos / Permissões";
            this.btnGrupos.Click += new System.EventHandler(this.gruposPermissõesToolStripMenuItem_Click);
            // 
            // btnUser
            // 
            this.btnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUser.Image = global::IB.SM.SysAdmin.Properties.Resources.User;
            this.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(23, 22);
            this.btnUser.Text = "Usuários";
            this.btnUser.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::IB.SM.SysAdmin.Properties.Resources.sensor2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Centrais";
            this.toolStripButton1.Click += new System.EventHandler(this.centraisToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::IB.SM.SysAdmin.Properties.Resources.zone;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Zonas";
            this.toolStripButton2.Click += new System.EventHandler(this.zonasToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 470);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "IB Senstar (Administração de Sistema)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposPermissõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem efetuarLogoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intrusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLblUsr;
        private System.Windows.Forms.ToolStripButton btnGrupos;
        private System.Windows.Forms.ToolStripButton btnUser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
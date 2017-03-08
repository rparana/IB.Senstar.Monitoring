namespace IB.SM.SysAdmin
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.pnlDados = new System.Windows.Forms.Panel();
            this.chkSenhaExpira = new System.Windows.Forms.CheckBox();
            this.chkPodeAlterar = new System.Windows.Forms.CheckBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkAlterarSenha = new System.Windows.Forms.CheckBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tvDados = new System.Windows.Forms.TreeView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlDados.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.chkSenhaExpira);
            this.pnlDados.Controls.Add(this.chkPodeAlterar);
            this.pnlDados.Controls.Add(this.cmbStatus);
            this.pnlDados.Controls.Add(this.cmbGrupo);
            this.pnlDados.Controls.Add(this.lblGrupo);
            this.pnlDados.Controls.Add(this.lblStatus);
            this.pnlDados.Controls.Add(this.chkAlterarSenha);
            this.pnlDados.Controls.Add(this.txtSenha2);
            this.pnlDados.Controls.Add(this.lblSenha2);
            this.pnlDados.Controls.Add(this.txtSenha1);
            this.pnlDados.Controls.Add(this.lblSenha1);
            this.pnlDados.Controls.Add(this.txtUsuario);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtID);
            this.pnlDados.Controls.Add(this.txtDescricao);
            this.pnlDados.Controls.Add(this.lblUsuario);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Location = new System.Drawing.Point(234, 12);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(257, 308);
            this.pnlDados.TabIndex = 0;
            // 
            // chkSenhaExpira
            // 
            this.chkSenhaExpira.AutoSize = true;
            this.chkSenhaExpira.Location = new System.Drawing.Point(9, 211);
            this.chkSenhaExpira.Name = "chkSenhaExpira";
            this.chkSenhaExpira.Size = new System.Drawing.Size(89, 17);
            this.chkSenhaExpira.TabIndex = 13;
            this.chkSenhaExpira.Text = "Senha Expira";
            this.chkSenhaExpira.UseVisualStyleBackColor = true;
            this.chkSenhaExpira.CheckedChanged += new System.EventHandler(this.chkSenhaExpira_CheckedChanged);
            // 
            // chkPodeAlterar
            // 
            this.chkPodeAlterar.AutoSize = true;
            this.chkPodeAlterar.Checked = true;
            this.chkPodeAlterar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPodeAlterar.Location = new System.Drawing.Point(9, 234);
            this.chkPodeAlterar.Name = "chkPodeAlterar";
            this.chkPodeAlterar.Size = new System.Drawing.Size(115, 17);
            this.chkPodeAlterar.TabIndex = 15;
            this.chkPodeAlterar.Text = "Pode alterar senha";
            this.chkPodeAlterar.UseVisualStyleBackColor = true;
            this.chkPodeAlterar.CheckedChanged += new System.EventHandler(this.chkPodeAlterar_CheckedChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(9, 19);
            this.cmbStatus.MaxLength = 150;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(113, 21);
            this.cmbStatus.TabIndex = 15;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.ItemHeight = 13;
            this.cmbGrupo.Location = new System.Drawing.Point(9, 273);
            this.cmbGrupo.MaxLength = 150;
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(238, 21);
            this.cmbGrupo.TabIndex = 26;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(6, 257);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 16;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // chkAlterarSenha
            // 
            this.chkAlterarSenha.AutoSize = true;
            this.chkAlterarSenha.Location = new System.Drawing.Point(113, 211);
            this.chkAlterarSenha.Name = "chkAlterarSenha";
            this.chkAlterarSenha.Size = new System.Drawing.Size(144, 17);
            this.chkAlterarSenha.TabIndex = 14;
            this.chkAlterarSenha.Text = "Alterar no Próximo Logon";
            this.chkAlterarSenha.UseVisualStyleBackColor = true;
            this.chkAlterarSenha.CheckedChanged += new System.EventHandler(this.chkAlterarSenha_CheckedChanged);
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(134, 189);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(113, 20);
            this.txtSenha2.TabIndex = 12;
            this.txtSenha2.Text = "SenhANãoAlterada";
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(131, 173);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(89, 13);
            this.lblSenha2.TabIndex = 11;
            this.lblSenha2.Text = "Confirme a senha";
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(9, 189);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '*';
            this.txtSenha1.Size = new System.Drawing.Size(113, 20);
            this.txtSenha1.TabIndex = 10;
            this.txtSenha1.Text = "SenhANãoAlterada";
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.Location = new System.Drawing.Point(6, 173);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(38, 13);
            this.lblSenha1.TabIndex = 9;
            this.lblSenha1.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 150);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuário";
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(9, 97);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(238, 34);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tvDados);
            this.pnlList.Location = new System.Drawing.Point(12, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(216, 308);
            this.pnlList.TabIndex = 22;
            // 
            // tvDados
            // 
            this.tvDados.ImageIndex = 0;
            this.tvDados.ImageList = this.imageList1;
            this.tvDados.Location = new System.Drawing.Point(3, 3);
            this.tvDados.Name = "tvDados";
            this.tvDados.SelectedImageIndex = 1;
            this.tvDados.Size = new System.Drawing.Size(210, 302);
            this.tvDados.TabIndex = 23;
            this.tvDados.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDados_AfterSelect);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::IB.SM.SysAdmin.Properties.Resources.Exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(376, 326);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 28);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::IB.SM.SysAdmin.Properties.Resources.trash_can_delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(255, 326);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 28);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::IB.SM.SysAdmin.Properties.Resources.Appedit;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(134, 326);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 28);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::IB.SM.SysAdmin.Properties.Resources.Plus_Box_Green;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(12, 326);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 28);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User.png");
            this.imageList1.Images.SetKeyName(1, "check.png");
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 365);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TreeView tvDados;
        private System.Windows.Forms.CheckBox chkPodeAlterar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkAlterarSenha;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSenhaExpira;
        private System.Windows.Forms.ImageList imageList1;
    }
}
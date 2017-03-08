namespace IB.SM.SysAdmin
{
    partial class frmAlteraSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlteraSenha));
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkAlterar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(27, 120);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(136, 20);
            this.txtSenha2.TabIndex = 5;
            this.txtSenha2.Enter += new System.EventHandler(this.MudaCor_Enter);
            this.txtSenha2.Leave += new System.EventHandler(this.MudaCor_Leave);
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(24, 104);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(116, 13);
            this.lblSenha2.TabIndex = 4;
            this.lblSenha2.Text = "Confirme a nova senha";
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(27, 75);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '*';
            this.txtSenha1.Size = new System.Drawing.Size(136, 20);
            this.txtSenha1.TabIndex = 3;
            this.txtSenha1.Enter += new System.EventHandler(this.MudaCor_Enter);
            this.txtSenha1.Leave += new System.EventHandler(this.MudaCor_Leave);
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.Location = new System.Drawing.Point(24, 59);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(65, 13);
            this.lblSenha1.TabIndex = 2;
            this.lblSenha1.Text = "Nova senha";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenhaAtual.Location = new System.Drawing.Point(27, 32);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(136, 20);
            this.txtSenhaAtual.TabIndex = 1;
            this.txtSenhaAtual.Enter += new System.EventHandler(this.MudaCor_Enter);
            this.txtSenhaAtual.Leave += new System.EventHandler(this.MudaCor_Leave);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(24, 16);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(65, 13);
            this.lblSenhaAtual.TabIndex = 0;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Confirmar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(103, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkAlterar
            // 
            this.chkAlterar.AutoSize = true;
            this.chkAlterar.Location = new System.Drawing.Point(27, 100);
            this.chkAlterar.Name = "chkAlterar";
            this.chkAlterar.Size = new System.Drawing.Size(135, 17);
            this.chkAlterar.TabIndex = 8;
            this.chkAlterar.Text = "Alterar no próximo login";
            this.chkAlterar.UseVisualStyleBackColor = true;
            this.chkAlterar.Visible = false;
            // 
            // frmAlteraSenha
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(189, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.lblSenhaAtual);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.lblSenha1);
            this.Controls.Add(this.chkAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlteraSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlteraSenha";
            this.Load += new System.EventHandler(this.frmAlteraSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAlterar;
    }
}
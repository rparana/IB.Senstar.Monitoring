namespace IB.SM.AlarmView
{
    partial class FrmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTodos1 = new System.Windows.Forms.CheckBox();
            this.clbCentrais = new System.Windows.Forms.CheckedListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTodos2 = new System.Windows.Forms.CheckBox();
            this.clbZonas = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTipoRel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTodos1);
            this.groupBox1.Controls.Add(this.clbCentrais);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Centrais";
            // 
            // chkTodos1
            // 
            this.chkTodos1.AutoSize = true;
            this.chkTodos1.Location = new System.Drawing.Point(6, 19);
            this.chkTodos1.Name = "chkTodos1";
            this.chkTodos1.Size = new System.Drawing.Size(56, 17);
            this.chkTodos1.TabIndex = 0;
            this.chkTodos1.Text = "Todos";
            this.chkTodos1.UseVisualStyleBackColor = true;
            this.chkTodos1.CheckedChanged += new System.EventHandler(this.chkTodos1_CheckedChanged);
            this.chkTodos1.Click += new System.EventHandler(this.chkTodos1_Click);
            // 
            // clbCentrais
            // 
            this.clbCentrais.CheckOnClick = true;
            this.clbCentrais.FormattingEnabled = true;
            this.clbCentrais.Location = new System.Drawing.Point(6, 40);
            this.clbCentrais.Name = "clbCentrais";
            this.clbCentrais.Size = new System.Drawing.Size(214, 139);
            this.clbCentrais.TabIndex = 14;
            this.clbCentrais.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCentrais_ItemCheck);
            this.clbCentrais.SelectedIndexChanged += new System.EventHandler(this.clbCentrais_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sensor2.png");
            this.imageList1.Images.SetKeyName(1, "check.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTodos2);
            this.groupBox2.Controls.Add(this.clbZonas);
            this.groupBox2.Location = new System.Drawing.Point(244, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zonas";
            // 
            // chkTodos2
            // 
            this.chkTodos2.AutoSize = true;
            this.chkTodos2.Location = new System.Drawing.Point(6, 19);
            this.chkTodos2.Name = "chkTodos2";
            this.chkTodos2.Size = new System.Drawing.Size(56, 17);
            this.chkTodos2.TabIndex = 15;
            this.chkTodos2.Text = "Todos";
            this.chkTodos2.UseVisualStyleBackColor = true;
            this.chkTodos2.CheckedChanged += new System.EventHandler(this.chkTodos2_CheckedChanged);
            this.chkTodos2.Click += new System.EventHandler(this.chkTodos2_Click);
            // 
            // clbZonas
            // 
            this.clbZonas.CheckOnClick = true;
            this.clbZonas.FormattingEnabled = true;
            this.clbZonas.Location = new System.Drawing.Point(6, 40);
            this.clbZonas.Name = "clbZonas";
            this.clbZonas.Size = new System.Drawing.Size(286, 139);
            this.clbZonas.TabIndex = 14;
            this.clbZonas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbZonas_ItemCheck);
            this.clbZonas.SelectedIndexChanged += new System.EventHandler(this.clbZonas_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTipoRel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpFim);
            this.groupBox3.Controls.Add(this.dtpInicio);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data / Hora";
            // 
            // cmbTipoRel
            // 
            this.cmbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRel.FormattingEnabled = true;
            this.cmbTipoRel.Items.AddRange(new object[] {
            "Relatório de Reconhecimento."});
            this.cmbTipoRel.Location = new System.Drawing.Point(312, 31);
            this.cmbTipoRel.Name = "cmbTipoRel";
            this.cmbTipoRel.Size = new System.Drawing.Size(212, 21);
            this.cmbTipoRel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de relatório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(159, 32);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(147, 20);
            this.dtpFim.TabIndex = 3;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(6, 32);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(147, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(12, 275);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(241, 39);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(301, 275);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(241, 39);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(554, 326);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorios";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckedListBox clbCentrais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbZonas;
        private System.Windows.Forms.CheckBox chkTodos1;
        private System.Windows.Forms.CheckBox chkTodos2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cmbTipoRel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnFechar;
    }
}
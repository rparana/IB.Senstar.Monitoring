namespace IB.SM.AlarmView
{
    partial class FrmEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventos));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtvEventos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imgMap = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaçãoVisualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMap)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatusConexao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatusConexao
            // 
            this.tssStatusConexao.Name = "tssStatusConexao";
            this.tssStatusConexao.Size = new System.Drawing.Size(0, 17);
            // 
            // dtvEventos
            // 
            this.dtvEventos.AllowUserToAddRows = false;
            this.dtvEventos.AllowUserToDeleteRows = false;
            this.dtvEventos.AllowUserToResizeColumns = false;
            this.dtvEventos.AllowUserToResizeRows = false;
            this.dtvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvEventos.AutoGenerateColumns = false;
            this.dtvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.centralDataGridViewTextBoxColumn,
            this.ladoDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.distanciaDataGridViewTextBoxColumn});
            this.dtvEventos.DataSource = this.viewEventsBindingSource;
            this.dtvEventos.Location = new System.Drawing.Point(3, 3);
            this.dtvEventos.Name = "dtvEventos";
            this.dtvEventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvEventos.ShowEditingIcon = false;
            this.dtvEventos.Size = new System.Drawing.Size(1033, 111);
            this.dtvEventos.TabIndex = 1;
            this.dtvEventos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtvEventos_CellMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "Data_Hora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "Data/Hora";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            // 
            // centralDataGridViewTextBoxColumn
            // 
            this.centralDataGridViewTextBoxColumn.DataPropertyName = "Central";
            this.centralDataGridViewTextBoxColumn.HeaderText = "Central";
            this.centralDataGridViewTextBoxColumn.Name = "centralDataGridViewTextBoxColumn";
            this.centralDataGridViewTextBoxColumn.Width = 150;
            // 
            // ladoDataGridViewTextBoxColumn
            // 
            this.ladoDataGridViewTextBoxColumn.DataPropertyName = "Lado";
            this.ladoDataGridViewTextBoxColumn.HeaderText = "Lado";
            this.ladoDataGridViewTextBoxColumn.Name = "ladoDataGridViewTextBoxColumn";
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            this.zonaDataGridViewTextBoxColumn.Width = 250;
            // 
            // distanciaDataGridViewTextBoxColumn
            // 
            this.distanciaDataGridViewTextBoxColumn.DataPropertyName = "Distancia";
            this.distanciaDataGridViewTextBoxColumn.HeaderText = "Distancia da central";
            this.distanciaDataGridViewTextBoxColumn.Name = "distanciaDataGridViewTextBoxColumn";
            this.distanciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // viewEventsBindingSource
            // 
            this.viewEventsBindingSource.DataSource = typeof(IB.SM.Model.Entities.ViewEvents);
            // 
            // timerBlink
            // 
            this.timerBlink.Enabled = true;
            this.timerBlink.Interval = 300;
            this.timerBlink.Tick += new System.EventHandler(this.timerConnect_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.imgMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtvEventos);
            this.splitContainer1.Size = new System.Drawing.Size(1039, 455);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 3;
            // 
            // imgMap
            // 
            this.imgMap.Image = global::IB.SM.AlarmView.Properties.Resources.IBT_CPBR_PR_SEG_PE_001_REV03_page_001__1_;
            this.imgMap.Location = new System.Drawing.Point(0, 3);
            this.imgMap.Name = "imgMap";
            this.imgMap.Size = new System.Drawing.Size(1984, 1403);
            this.imgMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgMap.TabIndex = 0;
            this.imgMap.TabStop = false;
            this.imgMap.Paint += new System.Windows.Forms.PaintEventHandler(this.imgMap_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1039, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::IB.SM.AlarmView.Properties.Resources.check;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Reconhecer Alarme";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.eventosToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 23);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificaçãoVisualToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // notificaçãoVisualToolStripMenuItem
            // 
            this.notificaçãoVisualToolStripMenuItem.Checked = true;
            this.notificaçãoVisualToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notificaçãoVisualToolStripMenuItem.Name = "notificaçãoVisualToolStripMenuItem";
            this.notificaçãoVisualToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.notificaçãoVisualToolStripMenuItem.Text = "Notificação Visual";
            this.notificaçãoVisualToolStripMenuItem.Click += new System.EventHandler(this.notificaçãoVisualToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEventos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEventsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMap)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatusConexao;
        private System.Windows.Forms.DataGridView dtvEventos;
        private System.Windows.Forms.BindingSource viewEventsBindingSource;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox imgMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificaçãoVisualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}
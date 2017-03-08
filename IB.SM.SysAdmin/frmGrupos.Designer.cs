namespace IB.SM.SysAdmin
{
    partial class frmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupos));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPermissoes = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkAcConfig = new System.Windows.Forms.CheckBox();
            this.chkAcADM = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkSilenciarEventos = new System.Windows.Forms.CheckBox();
            this.chkImportarEventos = new System.Windows.Forms.CheckBox();
            this.chkReconhecerEventos = new System.Windows.Forms.CheckBox();
            this.chkLimparEventos = new System.Windows.Forms.CheckBox();
            this.chkAcEvViewer = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chkPesquisarGrupos = new System.Windows.Forms.CheckBox();
            this.chkExcluirGrupos = new System.Windows.Forms.CheckBox();
            this.chkEditarGrupos = new System.Windows.Forms.CheckBox();
            this.chkCriarGrupos = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkPesquisarUsuarios = new System.Windows.Forms.CheckBox();
            this.chkExcluirUsuarios = new System.Windows.Forms.CheckBox();
            this.chkEditarUsuarios = new System.Windows.Forms.CheckBox();
            this.chkCriarUsuarios = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chkPesquisarCentrais = new System.Windows.Forms.CheckBox();
            this.chkExcluirCentrais = new System.Windows.Forms.CheckBox();
            this.chkEditarCentrais = new System.Windows.Forms.CheckBox();
            this.chkCriarCentrais = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chkPesquisarZonas = new System.Windows.Forms.CheckBox();
            this.chkExcluirZonas = new System.Windows.Forms.CheckBox();
            this.chkEditarZonas = new System.Windows.Forms.CheckBox();
            this.chkCriarZonas = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.chkPesquisarMapas = new System.Windows.Forms.CheckBox();
            this.chkExcluirMapas = new System.Windows.Forms.CheckBox();
            this.chkEditarMapas = new System.Windows.Forms.CheckBox();
            this.chkCriarMapas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tvDados = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlDados = new System.Windows.Forms.Panel();
            this.txtIDPermissao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tabPermissoes.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(10, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nome";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 62);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(238, 44);
            this.txtDescricao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // tabPermissoes
            // 
            this.tabPermissoes.Controls.Add(this.tabPage3);
            this.tabPermissoes.Controls.Add(this.tabPage4);
            this.tabPermissoes.Controls.Add(this.tabPage5);
            this.tabPermissoes.Controls.Add(this.tabPage6);
            this.tabPermissoes.Controls.Add(this.tabPage7);
            this.tabPermissoes.Controls.Add(this.tabPage8);
            this.tabPermissoes.Controls.Add(this.tabPage9);
            this.tabPermissoes.Location = new System.Drawing.Point(10, 127);
            this.tabPermissoes.Multiline = true;
            this.tabPermissoes.Name = "tabPermissoes";
            this.tabPermissoes.SelectedIndex = 0;
            this.tabPermissoes.Size = new System.Drawing.Size(245, 144);
            this.tabPermissoes.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkAcConfig);
            this.tabPage3.Controls.Add(this.chkAcADM);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(237, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Adm. Sistema";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkAcConfig
            // 
            this.chkAcConfig.AutoSize = true;
            this.chkAcConfig.Location = new System.Drawing.Point(17, 56);
            this.chkAcConfig.Name = "chkAcConfig";
            this.chkAcConfig.Size = new System.Drawing.Size(99, 17);
            this.chkAcConfig.TabIndex = 1;
            this.chkAcConfig.Text = "Config. Sistema";
            this.chkAcConfig.UseVisualStyleBackColor = true;
            // 
            // chkAcADM
            // 
            this.chkAcADM.AutoSize = true;
            this.chkAcADM.Location = new System.Drawing.Point(17, 17);
            this.chkAcADM.Name = "chkAcADM";
            this.chkAcADM.Size = new System.Drawing.Size(128, 17);
            this.chkAcADM.TabIndex = 0;
            this.chkAcADM.Text = "Acesso Adm. Sistema";
            this.chkAcADM.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkSilenciarEventos);
            this.tabPage4.Controls.Add(this.chkImportarEventos);
            this.tabPage4.Controls.Add(this.chkReconhecerEventos);
            this.tabPage4.Controls.Add(this.chkLimparEventos);
            this.tabPage4.Controls.Add(this.chkAcEvViewer);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(237, 100);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Ev. Viewer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkSilenciarEventos
            // 
            this.chkSilenciarEventos.AutoSize = true;
            this.chkSilenciarEventos.Location = new System.Drawing.Point(131, 18);
            this.chkSilenciarEventos.Name = "chkSilenciarEventos";
            this.chkSilenciarEventos.Size = new System.Drawing.Size(108, 17);
            this.chkSilenciarEventos.TabIndex = 5;
            this.chkSilenciarEventos.Text = "Silenciar Eventos";
            this.chkSilenciarEventos.UseVisualStyleBackColor = true;
            // 
            // chkImportarEventos
            // 
            this.chkImportarEventos.AutoSize = true;
            this.chkImportarEventos.Location = new System.Drawing.Point(131, 41);
            this.chkImportarEventos.Name = "chkImportarEventos";
            this.chkImportarEventos.Size = new System.Drawing.Size(106, 17);
            this.chkImportarEventos.TabIndex = 4;
            this.chkImportarEventos.Text = "Importar Eventos";
            this.chkImportarEventos.UseVisualStyleBackColor = true;
            // 
            // chkReconhecerEventos
            // 
            this.chkReconhecerEventos.AutoSize = true;
            this.chkReconhecerEventos.Location = new System.Drawing.Point(6, 64);
            this.chkReconhecerEventos.Name = "chkReconhecerEventos";
            this.chkReconhecerEventos.Size = new System.Drawing.Size(127, 17);
            this.chkReconhecerEventos.TabIndex = 3;
            this.chkReconhecerEventos.Text = "Reconhecer Eventos";
            this.chkReconhecerEventos.UseVisualStyleBackColor = true;
            // 
            // chkLimparEventos
            // 
            this.chkLimparEventos.AutoSize = true;
            this.chkLimparEventos.Location = new System.Drawing.Point(6, 41);
            this.chkLimparEventos.Name = "chkLimparEventos";
            this.chkLimparEventos.Size = new System.Drawing.Size(99, 17);
            this.chkLimparEventos.TabIndex = 2;
            this.chkLimparEventos.Text = "Limpar Eventos";
            this.chkLimparEventos.UseVisualStyleBackColor = true;
            // 
            // chkAcEvViewer
            // 
            this.chkAcEvViewer.AutoSize = true;
            this.chkAcEvViewer.Location = new System.Drawing.Point(6, 18);
            this.chkAcEvViewer.Name = "chkAcEvViewer";
            this.chkAcEvViewer.Size = new System.Drawing.Size(115, 17);
            this.chkAcEvViewer.TabIndex = 1;
            this.chkAcEvViewer.Text = "Acesso Ev. Viewer";
            this.chkAcEvViewer.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkPesquisarGrupos);
            this.tabPage5.Controls.Add(this.chkExcluirGrupos);
            this.tabPage5.Controls.Add(this.chkEditarGrupos);
            this.tabPage5.Controls.Add(this.chkCriarGrupos);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(237, 100);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Grupos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chkPesquisarGrupos
            // 
            this.chkPesquisarGrupos.AutoSize = true;
            this.chkPesquisarGrupos.Location = new System.Drawing.Point(129, 24);
            this.chkPesquisarGrupos.Name = "chkPesquisarGrupos";
            this.chkPesquisarGrupos.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisarGrupos.TabIndex = 13;
            this.chkPesquisarGrupos.Text = "Pesquisar";
            this.chkPesquisarGrupos.UseVisualStyleBackColor = true;
            // 
            // chkExcluirGrupos
            // 
            this.chkExcluirGrupos.AutoSize = true;
            this.chkExcluirGrupos.Location = new System.Drawing.Point(129, 59);
            this.chkExcluirGrupos.Name = "chkExcluirGrupos";
            this.chkExcluirGrupos.Size = new System.Drawing.Size(57, 17);
            this.chkExcluirGrupos.TabIndex = 12;
            this.chkExcluirGrupos.Text = "Excluir";
            this.chkExcluirGrupos.UseVisualStyleBackColor = true;
            // 
            // chkEditarGrupos
            // 
            this.chkEditarGrupos.AutoSize = true;
            this.chkEditarGrupos.Location = new System.Drawing.Point(41, 59);
            this.chkEditarGrupos.Name = "chkEditarGrupos";
            this.chkEditarGrupos.Size = new System.Drawing.Size(53, 17);
            this.chkEditarGrupos.TabIndex = 11;
            this.chkEditarGrupos.Text = "Editar";
            this.chkEditarGrupos.UseVisualStyleBackColor = true;
            // 
            // chkCriarGrupos
            // 
            this.chkCriarGrupos.AutoSize = true;
            this.chkCriarGrupos.Location = new System.Drawing.Point(41, 24);
            this.chkCriarGrupos.Name = "chkCriarGrupos";
            this.chkCriarGrupos.Size = new System.Drawing.Size(47, 17);
            this.chkCriarGrupos.TabIndex = 10;
            this.chkCriarGrupos.Text = "Criar";
            this.chkCriarGrupos.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkPesquisarUsuarios);
            this.tabPage6.Controls.Add(this.chkExcluirUsuarios);
            this.tabPage6.Controls.Add(this.chkEditarUsuarios);
            this.tabPage6.Controls.Add(this.chkCriarUsuarios);
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(237, 100);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Usuários";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chkPesquisarUsuarios
            // 
            this.chkPesquisarUsuarios.AutoSize = true;
            this.chkPesquisarUsuarios.Location = new System.Drawing.Point(129, 24);
            this.chkPesquisarUsuarios.Name = "chkPesquisarUsuarios";
            this.chkPesquisarUsuarios.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisarUsuarios.TabIndex = 13;
            this.chkPesquisarUsuarios.Text = "Pesquisar";
            this.chkPesquisarUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkExcluirUsuarios
            // 
            this.chkExcluirUsuarios.AutoSize = true;
            this.chkExcluirUsuarios.Location = new System.Drawing.Point(129, 59);
            this.chkExcluirUsuarios.Name = "chkExcluirUsuarios";
            this.chkExcluirUsuarios.Size = new System.Drawing.Size(57, 17);
            this.chkExcluirUsuarios.TabIndex = 12;
            this.chkExcluirUsuarios.Text = "Excluir";
            this.chkExcluirUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkEditarUsuarios
            // 
            this.chkEditarUsuarios.AutoSize = true;
            this.chkEditarUsuarios.Location = new System.Drawing.Point(41, 59);
            this.chkEditarUsuarios.Name = "chkEditarUsuarios";
            this.chkEditarUsuarios.Size = new System.Drawing.Size(53, 17);
            this.chkEditarUsuarios.TabIndex = 11;
            this.chkEditarUsuarios.Text = "Editar";
            this.chkEditarUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkCriarUsuarios
            // 
            this.chkCriarUsuarios.AutoSize = true;
            this.chkCriarUsuarios.Location = new System.Drawing.Point(41, 24);
            this.chkCriarUsuarios.Name = "chkCriarUsuarios";
            this.chkCriarUsuarios.Size = new System.Drawing.Size(47, 17);
            this.chkCriarUsuarios.TabIndex = 10;
            this.chkCriarUsuarios.Text = "Criar";
            this.chkCriarUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chkPesquisarCentrais);
            this.tabPage7.Controls.Add(this.chkExcluirCentrais);
            this.tabPage7.Controls.Add(this.chkEditarCentrais);
            this.tabPage7.Controls.Add(this.chkCriarCentrais);
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(237, 100);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Centrais";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // chkPesquisarCentrais
            // 
            this.chkPesquisarCentrais.AutoSize = true;
            this.chkPesquisarCentrais.Location = new System.Drawing.Point(129, 24);
            this.chkPesquisarCentrais.Name = "chkPesquisarCentrais";
            this.chkPesquisarCentrais.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisarCentrais.TabIndex = 13;
            this.chkPesquisarCentrais.Text = "Pesquisar";
            this.chkPesquisarCentrais.UseVisualStyleBackColor = true;
            // 
            // chkExcluirCentrais
            // 
            this.chkExcluirCentrais.AutoSize = true;
            this.chkExcluirCentrais.Location = new System.Drawing.Point(129, 59);
            this.chkExcluirCentrais.Name = "chkExcluirCentrais";
            this.chkExcluirCentrais.Size = new System.Drawing.Size(57, 17);
            this.chkExcluirCentrais.TabIndex = 12;
            this.chkExcluirCentrais.Text = "Excluir";
            this.chkExcluirCentrais.UseVisualStyleBackColor = true;
            // 
            // chkEditarCentrais
            // 
            this.chkEditarCentrais.AutoSize = true;
            this.chkEditarCentrais.Location = new System.Drawing.Point(41, 59);
            this.chkEditarCentrais.Name = "chkEditarCentrais";
            this.chkEditarCentrais.Size = new System.Drawing.Size(53, 17);
            this.chkEditarCentrais.TabIndex = 11;
            this.chkEditarCentrais.Text = "Editar";
            this.chkEditarCentrais.UseVisualStyleBackColor = true;
            // 
            // chkCriarCentrais
            // 
            this.chkCriarCentrais.AutoSize = true;
            this.chkCriarCentrais.Location = new System.Drawing.Point(41, 24);
            this.chkCriarCentrais.Name = "chkCriarCentrais";
            this.chkCriarCentrais.Size = new System.Drawing.Size(47, 17);
            this.chkCriarCentrais.TabIndex = 10;
            this.chkCriarCentrais.Text = "Criar";
            this.chkCriarCentrais.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chkPesquisarZonas);
            this.tabPage8.Controls.Add(this.chkExcluirZonas);
            this.tabPage8.Controls.Add(this.chkEditarZonas);
            this.tabPage8.Controls.Add(this.chkCriarZonas);
            this.tabPage8.Location = new System.Drawing.Point(4, 40);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(237, 100);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Zonas";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chkPesquisarZonas
            // 
            this.chkPesquisarZonas.AutoSize = true;
            this.chkPesquisarZonas.Location = new System.Drawing.Point(129, 24);
            this.chkPesquisarZonas.Name = "chkPesquisarZonas";
            this.chkPesquisarZonas.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisarZonas.TabIndex = 13;
            this.chkPesquisarZonas.Text = "Pesquisar";
            this.chkPesquisarZonas.UseVisualStyleBackColor = true;
            // 
            // chkExcluirZonas
            // 
            this.chkExcluirZonas.AutoSize = true;
            this.chkExcluirZonas.Location = new System.Drawing.Point(129, 59);
            this.chkExcluirZonas.Name = "chkExcluirZonas";
            this.chkExcluirZonas.Size = new System.Drawing.Size(57, 17);
            this.chkExcluirZonas.TabIndex = 12;
            this.chkExcluirZonas.Text = "Excluir";
            this.chkExcluirZonas.UseVisualStyleBackColor = true;
            // 
            // chkEditarZonas
            // 
            this.chkEditarZonas.AutoSize = true;
            this.chkEditarZonas.Location = new System.Drawing.Point(41, 59);
            this.chkEditarZonas.Name = "chkEditarZonas";
            this.chkEditarZonas.Size = new System.Drawing.Size(53, 17);
            this.chkEditarZonas.TabIndex = 11;
            this.chkEditarZonas.Text = "Editar";
            this.chkEditarZonas.UseVisualStyleBackColor = true;
            // 
            // chkCriarZonas
            // 
            this.chkCriarZonas.AutoSize = true;
            this.chkCriarZonas.Location = new System.Drawing.Point(41, 24);
            this.chkCriarZonas.Name = "chkCriarZonas";
            this.chkCriarZonas.Size = new System.Drawing.Size(47, 17);
            this.chkCriarZonas.TabIndex = 10;
            this.chkCriarZonas.Text = "Criar";
            this.chkCriarZonas.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.chkPesquisarMapas);
            this.tabPage9.Controls.Add(this.chkExcluirMapas);
            this.tabPage9.Controls.Add(this.chkEditarMapas);
            this.tabPage9.Controls.Add(this.chkCriarMapas);
            this.tabPage9.Location = new System.Drawing.Point(4, 40);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(237, 100);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "Mapas";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // chkPesquisarMapas
            // 
            this.chkPesquisarMapas.AutoSize = true;
            this.chkPesquisarMapas.Location = new System.Drawing.Point(129, 24);
            this.chkPesquisarMapas.Name = "chkPesquisarMapas";
            this.chkPesquisarMapas.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisarMapas.TabIndex = 13;
            this.chkPesquisarMapas.Text = "Pesquisar";
            this.chkPesquisarMapas.UseVisualStyleBackColor = true;
            // 
            // chkExcluirMapas
            // 
            this.chkExcluirMapas.AutoSize = true;
            this.chkExcluirMapas.Location = new System.Drawing.Point(129, 59);
            this.chkExcluirMapas.Name = "chkExcluirMapas";
            this.chkExcluirMapas.Size = new System.Drawing.Size(57, 17);
            this.chkExcluirMapas.TabIndex = 12;
            this.chkExcluirMapas.Text = "Excluir";
            this.chkExcluirMapas.UseVisualStyleBackColor = true;
            // 
            // chkEditarMapas
            // 
            this.chkEditarMapas.AutoSize = true;
            this.chkEditarMapas.Location = new System.Drawing.Point(41, 59);
            this.chkEditarMapas.Name = "chkEditarMapas";
            this.chkEditarMapas.Size = new System.Drawing.Size(53, 17);
            this.chkEditarMapas.TabIndex = 11;
            this.chkEditarMapas.Text = "Editar";
            this.chkEditarMapas.UseVisualStyleBackColor = true;
            // 
            // chkCriarMapas
            // 
            this.chkCriarMapas.AutoSize = true;
            this.chkCriarMapas.Location = new System.Drawing.Point(41, 24);
            this.chkCriarMapas.Name = "chkCriarMapas";
            this.chkCriarMapas.Size = new System.Drawing.Size(47, 17);
            this.chkCriarMapas.TabIndex = 10;
            this.chkCriarMapas.Text = "Criar";
            this.chkCriarMapas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permissões:";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.tvDados);
            this.pnlList.Location = new System.Drawing.Point(11, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(209, 281);
            this.pnlList.TabIndex = 5;
            // 
            // tvDados
            // 
            this.tvDados.ImageIndex = 1;
            this.tvDados.ImageList = this.imageList1;
            this.tvDados.Location = new System.Drawing.Point(3, 3);
            this.tvDados.Name = "tvDados";
            this.tvDados.SelectedImageIndex = 0;
            this.tvDados.Size = new System.Drawing.Size(203, 275);
            this.tvDados.TabIndex = 12;
            this.tvDados.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDados_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check.png");
            this.imageList1.Images.SetKeyName(1, "User Group-01.png");
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtIDPermissao);
            this.pnlDados.Controls.Add(this.txtID);
            this.pnlDados.Controls.Add(this.txtDescricao);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.lblUsuario);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.tabPermissoes);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Location = new System.Drawing.Point(226, 12);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(264, 281);
            this.pnlDados.TabIndex = 0;
            // 
            // txtIDPermissao
            // 
            this.txtIDPermissao.Enabled = false;
            this.txtIDPermissao.Location = new System.Drawing.Point(159, 112);
            this.txtIDPermissao.Name = "txtIDPermissao";
            this.txtIDPermissao.Size = new System.Drawing.Size(89, 20);
            this.txtIDPermissao.TabIndex = 6;
            this.txtIDPermissao.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(162, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(11, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 36);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Image = global::IB.SM.SysAdmin.Properties.Resources.tick_circle_frame;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::IB.SM.SysAdmin.Properties.Resources.cancel_round;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(122, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::IB.SM.SysAdmin.Properties.Resources.Exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(375, 299);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 28);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::IB.SM.SysAdmin.Properties.Resources.trash_can_delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(254, 299);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 28);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::IB.SM.SysAdmin.Properties.Resources.Appedit;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(133, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 28);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::IB.SM.SysAdmin.Properties.Resources.Plus_Box_Green;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(11, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 28);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGrupos";
            this.Text = "Grupos / Permissões";
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            this.tabPermissoes.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabPermissoes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.CheckBox chkAcConfig;
        private System.Windows.Forms.CheckBox chkAcADM;
        private System.Windows.Forms.CheckBox chkLimparEventos;
        private System.Windows.Forms.CheckBox chkAcEvViewer;
        private System.Windows.Forms.CheckBox chkSilenciarEventos;
        private System.Windows.Forms.CheckBox chkImportarEventos;
        private System.Windows.Forms.CheckBox chkReconhecerEventos;
        private System.Windows.Forms.CheckBox chkPesquisarGrupos;
        private System.Windows.Forms.CheckBox chkExcluirGrupos;
        private System.Windows.Forms.CheckBox chkEditarGrupos;
        private System.Windows.Forms.CheckBox chkCriarGrupos;
        private System.Windows.Forms.CheckBox chkPesquisarUsuarios;
        private System.Windows.Forms.CheckBox chkExcluirUsuarios;
        private System.Windows.Forms.CheckBox chkEditarUsuarios;
        private System.Windows.Forms.CheckBox chkCriarUsuarios;
        private System.Windows.Forms.CheckBox chkPesquisarCentrais;
        private System.Windows.Forms.CheckBox chkExcluirCentrais;
        private System.Windows.Forms.CheckBox chkEditarCentrais;
        private System.Windows.Forms.CheckBox chkCriarCentrais;
        private System.Windows.Forms.CheckBox chkPesquisarZonas;
        private System.Windows.Forms.CheckBox chkExcluirZonas;
        private System.Windows.Forms.CheckBox chkEditarZonas;
        private System.Windows.Forms.CheckBox chkCriarZonas;
        private System.Windows.Forms.CheckBox chkPesquisarMapas;
        private System.Windows.Forms.CheckBox chkExcluirMapas;
        private System.Windows.Forms.CheckBox chkEditarMapas;
        private System.Windows.Forms.CheckBox chkCriarMapas;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TreeView tvDados;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDPermissao;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
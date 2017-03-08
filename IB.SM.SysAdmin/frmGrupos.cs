using IB.SM.Business;
using IB.SM.Model.Business;
using IB.SM.Model.Data.Repositories.Base;
using IB.SM.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.SysAdmin
{
    public partial class frmGrupos : Form
    {
        private IGroupController grController { get; set; }

        public frmGrupos()
        {
            InitializeComponent();
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            grController = new GroupController();
            this.Limpa_Form();
            CarregaTreeView();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvDados_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strNome = this.tvDados.SelectedNode.Text.ToString();
            carregaDadosTextBox(strNome);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (!String.IsNullOrEmpty(txtNome.Text))
            {
                try
                {
                    Grupo g = PreencheGrupo();
                    if (g.ID != 0)
                        result = MessageBox.Show("Deseja alterar o registro selecionado ? ", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                        return;

                    g = grController.Salvar(g);
                    txtID.Text = g.ID.ToString();
                    txtIDPermissao.Text = g.Permissao.ID.ToString();
                    MessageBox.Show("Registros inseridos com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome do Grupo", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtID.Text != null))
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado ? ", "Excluir", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        Grupo g = grController.BuscarporID(Convert.ToInt16(txtID.Text),true);
                        grController.Excluir(g);
                        MessageBox.Show("Registro excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpar.PerformClick();
                        CarregaTreeView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o Grupo.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpa_Form();
            txtNome.Focus();
        }

        private void HabilitaDesabilitaCampos(Control container, bool value)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl.Controls.Count > 0)
                    HabilitaDesabilitaCampos(ctrl,value);
                ctrl.Enabled = value;
            }
        }

        #region Função PreencheGrupo

        private Grupo PreencheGrupo()
        {
            Grupo retorno = new Grupo();

            if (!String.IsNullOrEmpty(txtID.Text))
            {
                retorno = grController.BuscarporID(Convert.ToInt16(txtID.Text), true);
            }

            retorno.Nome = txtNome.Text;
            retorno.Descricao = txtDescricao.Text;
            if (retorno.Permissao == null)
                retorno.Permissao = new Permissao();

            //Acesso
            retorno.Permissao.SystemADMAccess = chkAcADM.Checked;
            retorno.Permissao.SystemConfig = chkAcConfig.Checked;
            retorno.Permissao.AlarmViewAccess = chkAcEvViewer.Checked;

            //Centrais
            retorno.Permissao.CreateCentral = chkCriarCentrais.Checked;
            retorno.Permissao.UpdateCentral = chkEditarCentrais.Checked;
            retorno.Permissao.DeleteCentral = chkExcluirCentrais.Checked;
            retorno.Permissao.FindCentral = chkPesquisarCentrais.Checked;

            //Grupos
            retorno.Permissao.CreateGroup = chkCriarGrupos.Checked;
            retorno.Permissao.UpdateGroup = chkEditarGrupos.Checked;
            retorno.Permissao.DeleteGroup = chkExcluirGrupos.Checked;
            retorno.Permissao.FindGroup = chkPesquisarGrupos.Checked;

            //Mapas;
            retorno.Permissao.CreateMaps = chkCriarMapas.Checked;
            retorno.Permissao.UpdateMaps = chkEditarMapas.Checked;
            retorno.Permissao.DeleteMaps = chkExcluirMapas.Checked;
            retorno.Permissao.FindMaps = chkPesquisarMapas.Checked;

            //Usuarion;
            retorno.Permissao.CreateUser = chkCriarUsuarios.Checked;
            retorno.Permissao.UpdateUser = chkEditarUsuarios.Checked;
            retorno.Permissao.DeleteUser = chkExcluirUsuarios.Checked;
            retorno.Permissao.FindUser = chkPesquisarUsuarios.Checked;

            //Zonas;
            retorno.Permissao.CreateZone = chkCriarZonas.Checked;
            retorno.Permissao.UpdateZone = chkEditarZonas.Checked;
            retorno.Permissao.DeleteZone = chkExcluirZonas.Checked;
            retorno.Permissao.FindZone = chkPesquisarZonas.Checked;
            //Eventos;
            retorno.Permissao.ImportEvents = chkImportarEventos.Checked;
            retorno.Permissao.ClearEvents = chkLimparEventos.Checked;
            retorno.Permissao.AcknowledgeEvents = chkReconhecerEventos.Checked;
            retorno.Permissao.SilenceEvents = chkSilenciarEventos.Checked;


            return retorno;
        }

        #endregion

        #region Função Limpar Form

        private void Limpa_Form()
        {
            Limpa_Form(true);
        }

        private void Limpa_Form(bool tudo)
        {
            AppFunc.ResetFields(this);
            CarregaTreeView();
            //Acesso
            chkAcADM.Checked = true;
            chkAcConfig.Checked = true;
            chkAcEvViewer.Checked = true;

            //Centrais
            chkCriarCentrais.Checked = true;
            chkEditarCentrais.Checked = true;
            chkExcluirCentrais.Checked = true;
            chkPesquisarCentrais.Checked = true;

            //Grupos
            chkCriarGrupos.Checked = true;
            chkEditarGrupos.Checked = true;
            chkExcluirGrupos.Checked = true;
            chkPesquisarGrupos.Checked = true;

            //Mapas
            chkCriarMapas.Checked = true;
            chkEditarMapas.Checked = true;
            chkExcluirMapas.Checked = true;
            chkPesquisarMapas.Checked = true;

            //Usuarion
            chkCriarUsuarios.Checked = true;
            chkEditarUsuarios.Checked = true;
            chkExcluirUsuarios.Checked = true;
            chkPesquisarUsuarios.Checked = true;

            //Zonas
            chkCriarZonas.Checked = true;
            chkEditarZonas.Checked = true;
            chkExcluirZonas.Checked = true;
            chkPesquisarZonas.Checked = true;

            //Eventos
            chkImportarEventos.Checked = true;
            chkLimparEventos.Checked = true;
            chkReconhecerEventos.Checked = true;
            chkSilenciarEventos.Checked = true;
        }

        #endregion

        #region Função CarregaTreeView

        private void CarregaTreeView()
        {
            tvDados.Nodes.Clear();
            try
            {
                List<Grupo> grupos = new List<Grupo>();

                grupos = grController.ListarTodos().ToList();
                foreach (Grupo g in grupos)
                {
                    tvDados.Nodes.Add(g.Nome);
                }
                foreach (TreeNode n in tvDados.Nodes)
                {
                    if (n.Text == txtNome.Text)
                    {
                        tvDados.SelectedNode = n;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Função carregaDadosTextBox

        private void carregaDadosTextBox(string strNome)
        {
            try
            {
                Grupo g = grController.BuscaporNome(strNome,true);
                ValidaPermissoes(g);
                if (g != null)
                {
                    txtID.Text = g.ID.ToString();
                    txtNome.Text = g.Nome;
                    txtDescricao.Text = g.Descricao;

                    if (g.Permissao != null)
                    {
                        txtIDPermissao.Text = g.Permissao.ID.ToString();
                        //Acesso
                        chkAcADM.Checked = g.Permissao.SystemADMAccess;
                        chkAcConfig.Checked = g.Permissao.SystemConfig;
                        chkAcEvViewer.Checked = g.Permissao.AlarmViewAccess;

                        //Centrais
                        chkCriarCentrais.Checked = g.Permissao.CreateCentral;
                        chkEditarCentrais.Checked = g.Permissao.UpdateCentral;
                        chkExcluirCentrais.Checked = g.Permissao.DeleteCentral;
                        chkPesquisarCentrais.Checked = g.Permissao.FindCentral;

                        //Grupos
                        chkCriarGrupos.Checked = g.Permissao.CreateGroup;
                        chkEditarGrupos.Checked = g.Permissao.UpdateGroup;
                        chkExcluirGrupos.Checked = g.Permissao.DeleteGroup;
                        chkPesquisarGrupos.Checked = g.Permissao.FindGroup;

                        //Mapas
                        chkCriarMapas.Checked = g.Permissao.CreateMaps;
                        chkEditarMapas.Checked = g.Permissao.UpdateMaps;
                        chkExcluirMapas.Checked = g.Permissao.DeleteMaps;
                        chkPesquisarMapas.Checked = g.Permissao.FindMaps;

                        //Usuarion
                        chkCriarUsuarios.Checked = g.Permissao.CreateUser;
                        chkEditarUsuarios.Checked = g.Permissao.UpdateUser;
                        chkExcluirUsuarios.Checked = g.Permissao.DeleteUser;
                        chkPesquisarUsuarios.Checked = g.Permissao.FindUser;

                        //Zonas
                        chkCriarZonas.Checked = g.Permissao.CreateZone;
                        chkEditarZonas.Checked = g.Permissao.UpdateZone;
                        chkExcluirZonas.Checked = g.Permissao.DeleteZone;
                        chkPesquisarZonas.Checked = g.Permissao.FindZone;

                        //Eventos
                        chkImportarEventos.Checked = g.Permissao.ImportEvents;
                        chkLimparEventos.Checked = g.Permissao.ClearEvents;
                        chkReconhecerEventos.Checked = g.Permissao.AcknowledgeEvents;
                        chkSilenciarEventos.Checked = g.Permissao.SilenceEvents;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

        #region Função ValidaPermissoes

        private void ValidaPermissoes(Grupo g)
        {
            try
            {
                if(!Instancia.instanciaP.FindGroup)
                    return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

    }
}

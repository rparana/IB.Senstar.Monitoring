using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB.SM.SysAdmin
{
    public class AppFunc
    {
        #region Função VerificaFormAberto

        public static bool VerificaFormAberto(string NomedoForm)
        {
            FormCollection fc = Application.OpenForms;
            bool retorno = false;
            foreach (Form frm in fc)
            {
                if (frm.Name.ToUpper() == NomedoForm.ToUpper())
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion

        #region Função Limpa Campos

        //-------------------------------------------------
        public static void ResetFields(Control form)
        {
            //Loop em todos os componentes do form, se for algum container chamo a função novamente para o container.
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Controls.Count > 0)
                    ResetFields(ctrl);
                Reset(ctrl);
            }
        }

        public static void Reset(Control ctrl)
        {

            if (ctrl is TextBox)
            {
                TextBox tb = (TextBox)ctrl;
                if (tb != null)
                {
                    tb.ResetText();
                }
            }
            if (ctrl is ComboBox)
            {
                ComboBox tb = (ComboBox)ctrl;
                if (tb != null)
                {
                    tb.ResetText();
                }
            }
            else if (ctrl is CheckBox)
            {
                CheckBox dd = (CheckBox)ctrl;
                dd.Checked = false;
            }
            else if (ctrl is PictureBox)
            {
                PictureBox dd = (PictureBox)ctrl;
                if (dd != null)
                {
                    dd.Image = null;
                }
            }
            else if (ctrl is ListView)
            {
                ListView dd = (ListView)ctrl;
                if (dd != null)
                {
                    dd.Items.Clear();
                }
            }
            else if (ctrl is TabControl)
            {
                TabControl dd = (TabControl)ctrl;
                if (dd != null)
                {
                    dd.SelectTab(0);
                }
            }
            else if (ctrl is TreeView)
            {
                TreeView dd = (TreeView)ctrl;
                if (dd != null)
                {
                    dd.Nodes.Clear();
                }
            }
        }

        #endregion

    }
    #region Função CriaLista

    public class CriaLista
    {
        private string myDisplay;
        private string myValue;

        public CriaLista(string strDisplay, string strValue)
        {

            this.myValue = strValue;
            this.myDisplay = strDisplay;
        }

        public string Value
        {
            get
            {
                return myValue;
            }
        }

        public string Display
        {

            get
            {
                return myDisplay;
            }
        }

    }
    #endregion
}

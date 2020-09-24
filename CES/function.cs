using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES
{
    public class function
    {

        public void cargarForm(Form frm, Form _frm, Form parent)
        {
            if (_frm == null)
            {
                inicializaForm(frm, parent); 
            }
            else
                refresForm(_frm);
        }

        protected void inicializaForm(Form frm, Form parent)
        {
            frm.MdiParent = parent;
            //frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }
        protected void refresForm(Form frm)
        {
            frm.BringToFront();
            frm.WindowState = FormWindowState.Normal;
        }
    }
}

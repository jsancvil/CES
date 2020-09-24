using CES.Pages.Catalogos;
using CES.Pages.Config;
using CES.Pages.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        readonly function ofunciones = new function();
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.Inventario frm = new Control.Inventario();
            var _frm = Application.OpenForms["Inventario"] as Control.Inventario;
            ofunciones.cargarForm(frm, _frm, this);
        }


        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.Bitacora frm = new Control.Bitacora();
            var _frm = Application.OpenForms["Bitacora"] as Control.Bitacora;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos.Productos frm = new Catalogos.Productos();
            var _frm = Application.OpenForms["Productos"] as Catalogos.Productos;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos.ProductoAlta frm = new Catalogos.ProductoAlta();
            var _frm = Application.OpenForms["ProductoAlta"] as Catalogos.ProductoAlta;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Catalogos.Grupos frm = new Catalogos.Grupos();
            var _frm = Application.OpenForms["Grupos"] as Catalogos.Grupos;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Catalogos.GrupoAlta frm = new Catalogos.GrupoAlta();
            var _frm = Application.OpenForms["GrupoAlta"] as Catalogos.GrupoAlta;
            frm._idGrupo = 0;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Catalogos.UM frm = new Catalogos.UM();
            var _frm = Application.OpenForms["UM"] as Catalogos.UM;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Catalogos.UMAlta frm = new Catalogos.UMAlta();
            var _frm = Application.OpenForms["UMAlta"] as Catalogos.UMAlta;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void listaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Catalogos.Proveedores frm = new Catalogos.Proveedores();
            var _frm = Application.OpenForms["Proveedores"] as Catalogos.Proveedores;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Catalogos.ProveedorAlta frm = new Catalogos.ProveedorAlta();
            var _frm = Application.OpenForms["ProveedorAlta"] as Catalogos.ProveedorAlta;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void listaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            var _frm = Application.OpenForms["Usuarios"] as Usuarios;
            ofunciones.cargarForm(frm, _frm, this);
        }
        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UsuarioAlta frm = new UsuarioAlta();
            var _frm = Application.OpenForms["UsuarioAlta"] as UsuarioAlta;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void cerrarCeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro(a) de que quieres salir?",
                           "Control de Entradas y Salidas",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information) == DialogResult.OK)
            {
                Environment.Exit(1);

            }

        }
        private void listaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Entradas frm = new Entradas();
            var _frm = Application.OpenForms["Entradas"] as Entradas;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaAlta frm = new EntradaAlta();
            var _frm = Application.OpenForms["EntradaAlta"] as EntradaAlta;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Licencia frm = new Licencia();
            var _frm = Application.OpenForms["Licencia"] as Licencia;
            ofunciones.cargarForm(frm, _frm, this);
        }

        private void menuControlSalidaN_Click(object sender, EventArgs e)
        {
            SalidaAlta frm = new SalidaAlta();
            var _frm = Application.OpenForms["SalidaAlta"] as SalidaAlta;
            ofunciones.cargarForm(frm, _frm, this);

        }

        private void menuControlSalidaL_Click(object sender, EventArgs e)
        {
            Salidas frm = new Salidas();
            var _frm = Application.OpenForms["Salidas"] as Salidas;
            ofunciones.cargarForm(frm, _frm, this);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {

                switch (LoginInfo.idRol)
                {
                    case 1:
                        {
                            configLicencia.Visible = true;
                        }
                        break;
                    case 2:
                        {
                            configLicencia.Visible = false;
                        }
                        break;
                    case 3:
                        {
                            menucConfig.Enabled = false;
                            configLicencia.Visible = false;
                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

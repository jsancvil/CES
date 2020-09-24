using CES.DB.Metodos.Catalogos;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages.Catalogos
{
    public partial class ProveedorAlta : MetroFramework.Forms.MetroForm
    {
        public int _idProveedor;

        public ProveedorAlta()
        {
            InitializeComponent();
            OnLoad();

        }

        private void ProveedorAlta_Load(object sender, EventArgs e)
        {

            if (_idProveedor != 0)
                cargarDatos();
            else
                vaciarCampos();
        }

        protected void OnLoad()
        {
            try
            {

                txtIdProveedor.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void vaciarCampos()
        {
            txtIdProveedor.Text = "0";
            txtNombreProveedor.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtFechaAlta.Text = string.Empty;
            

            btnGuardar.Text = "Actualizar";
        }

        protected void cargarDatos()
        {
            try
            {
                var dt = new dtoProveedores
                {
                    operacion = "SelectByID",
                    activo = true,
                    idProveedor = _idProveedor
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    txtIdProveedor.Text = row["idProveedor"].ToString();
                    txtNombreProveedor.Text = row["nombre"].ToString();
                    txtRFC.Text = row["RFC"].ToString();
                    txtContacto.Text = row["nomContacto"].ToString();
                    txtTelefono.Text = row["telContacto"].ToString();
                    txtCorreo.Text = row["mailContacto"].ToString();
                    txtFechaAlta.Text = row["fechaAlta"] != DBNull.Value ? ((DateTime)row["fechaAlta"]).ToString("yyyy-MM-dd HH:mm") : "";

                    btnGuardar.Text = "Actualizar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                MetroTextBox txt = (MetroTextBox)sender;

                if (txt.Text.Contains('.'))
                {
                    if (e.KeyChar == '.')
                        e.Handled = true;
                }

                if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                base.OnKeyPress(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validaCampos())
                {
                    return;
                }

                var result = new dtoProveedores
                {
                    operacion = txtIdProveedor.Text != "0" ? "Update" : "Insert",
                    idProveedor = int.Parse(txtIdProveedor.Text),
                    nombre = txtNombreProveedor.Text,
                    mailContacto = txtCorreo.Text.Trim(),
                    RFC = txtRFC.Text.Trim(),
                    nomContacto = txtContacto.Text.Trim(),
                    telContacto = txtTelefono.Text.Trim(),
                    idUsuario = LoginInfo.idUsuario,
                    activo = true
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    string msn = "Registro " + (txtIdProveedor.Text != "0" ? "Actualizado" : "Agregado") + " Correctamenete";

                    MessageBox.Show(msn);

                    var _frm = Application.OpenForms["Proveedores"] as Catalogos.Proveedores;
                    if (!((_frm) != null))
                    {
                        Proveedores frm = new Proveedores();
                        inicializaForm(frm);
                    }
                    else
                    {
                        _frm.Show();
                        _frm.btnActualizar_Click(null, null);
                    }

                    this.Hide();
                }
                else
                    MessageBox.Show(result.messageError);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void inicializaForm(Form frm)
        {

            var menu = Application.OpenForms["menu"] as Menu;
            frm.MdiParent = menu;

            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        bool validaCampos()
        {
            bool validado = true;

            try
            {

                if (txtNombreProveedor.Text.Trim() == "")
                {
                    txtNombreProveedor.Focus();
                    validado = false;

                    lblError.SetError(txtNombreProveedor, "Ingresar Nombre de la empresa");
                }

            }
            catch (Exception ex)
            {
                validado = false;
                MessageBox.Show(ex.Message);
            }

            return validado;
        }

    }
}

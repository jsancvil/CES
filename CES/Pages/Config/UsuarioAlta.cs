using CES.DB.Metodos.Catalogos;
using CES.DB.Metodos.config;
using CES.Pages.Config;
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

namespace CES.Pages.Config
{
    public partial class UsuarioAlta : MetroFramework.Forms.MetroForm
    {
        public int _idUsuario;

        public UsuarioAlta()
        {
            InitializeComponent();
            OnLoad();

        }

        private void UsuarioAlta_Load(object sender, EventArgs e)
        {

            if (_idUsuario != 0)
                cargarDatos();
            else
                vaciarCampos();
        }

        protected void OnLoad()
        {
            try
            {
                var dtRol = new dtoRol
                {
                    operacion = "SelectAll",
                    activo = true
                }.CRUD().dtResult;


                ddlRol.DisplayMember = "rol";
                ddlRol.ValueMember = "idRol";
                ddlRol.DataSource = dtRol;



                txtIdUsuario.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void vaciarCampos()
        {
            txtIdUsuario.Text = "0";
            txtNombreUsuario.Text = string.Empty;

            btnGuardar.Text = "Guardar";
        }

        protected void cargarDatos()
        {
            try
            {
                var dt = new dtoUsuarios
                {
                    operacion = "SelectByID",
                    activo = true,
                    idUsuario = _idUsuario
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    txtIdUsuario.Text = row["idUsuario"].ToString();
                    txtNombreUsuario.Text = row["nombre"].ToString();
                    txtNombreUsuario.Text = row["nombre"].ToString();
                    txtCelular.Text = row["celular"].ToString();
                    txtCorreo.Text = row["correo"].ToString();
                    txtPsw.Text = row["psw"].ToString();
                    txtTelefono.Text = row["telefono"].ToString();
                    txtUsuario.Text = row["usuario"].ToString();

                    ddlRol.SelectedValue = row["idRol"].ToString();


                    btnGuardar.Text = "Actualizar";

                    if (_idUsuario == 1 && LoginInfo.idUsuario != 1)
                        btnGuardar.Enabled = false;
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

                var result = new dtoUsuarios
                {
                    operacion = txtIdUsuario.Text != "0" ? "Update" : "Insert",
                    idUsuario = int.Parse(txtIdUsuario.Text),
                    nombre = txtNombreUsuario.Text.Trim(),
                    celular = txtCelular.Text.Trim(),
                    correo = txtCorreo.Text.Trim(),
                    idDepto = 1,
                    idRol = int.Parse(ddlRol.SelectedValue.ToString()),
                    idUsuarioA = LoginInfo.idUsuario,
                    psw = txtPsw.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    usuario = txtUsuario.Text.Trim(),
                    activo = true
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    string msn = "Registro " + (txtIdUsuario.Text != "0" ? "Actualizado" : "Agregado") + " Correctamenete";

                    MessageBox.Show(msn);

                    var _frm = Application.OpenForms["Usuarios"] as Usuarios;
                    if (!((_frm) != null))
                    {
                        Usuarios frm = new Usuarios();
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

                if (txtUsuario.Text.Trim() == "")
                {
                    txtUsuario.Focus();
                    validado = false;

                    lblError.SetError(txtUsuario, "Ingresar un Usuario");
                }

                if (txtNombreUsuario.Text.Trim() == "")
                {
                    txtNombreUsuario.Focus();
                    validado = false;

                    lblError.SetError(txtNombreUsuario, "Ingresar un Nombre");
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

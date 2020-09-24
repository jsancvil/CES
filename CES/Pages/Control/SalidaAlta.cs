using CES.DB.Metodos.Catalogos;
using CES.DB.Metodos.config;
using CES.DB.Metodos.Control;
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

namespace CES.Pages.Control
{
    public partial class SalidaAlta : MetroFramework.Forms.MetroForm
    {
        public int _idSalida;

        public SalidaAlta()
        {
            InitializeComponent();
            OnLoad();

        }

        private void SalidaAlta_Load(object sender, EventArgs e)
        {

            if (_idSalida != 0)
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

                txtFechaAlta.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                txtIdSalida.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void vaciarCampos()
        {
            txtIdSalida.Text = "0";
            txtNombreSalida.Text = string.Empty;

            btnGuardar.Text = "Guardar";
        }

        protected void cargarDatos()
        {
            try
            {
                var dt = new dtoSalidas
                {
                    operacion = "SelectByID",
                    activo = true,
                    idSalida = _idSalida
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    txtIdSalida.Text = row["idSalida"].ToString();
                    txtNombreSalida.Text = row["nombre"].ToString();
                    txtNombreSalida.Text = row["nombre"].ToString();
                    txtCelular.Text = row["celular"].ToString();
                    txtCorreo.Text = row["correo"].ToString();
                    txtPsw.Text = row["psw"].ToString();
                    txtTelefono.Text = row["telefono"].ToString();
                    txtSalida.Text = row["Salida"].ToString();

                    ddlRol.SelectedValue = row["idRol"].ToString();


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

                var result = new dtoSalidas
                {
                    operacion = txtIdSalida.Text != "0" ? "Update" : "Insert",
                    idSalida = int.Parse(txtIdSalida.Text),
                    //nombre = txtNombreSalida.Text.Trim(),
                    //celular = txtCelular.Text.Trim(),
                    //correo = txtCorreo.Text.Trim(),
                    //idDepto = 1,
                    //idRol = int.Parse(ddlRol.SelectedValue.ToString()),
                    //idSalidaA = LoginInfo.idSalida,
                    //psw = txtPsw.Text.Trim(),
                    //telefono = txtTelefono.Text.Trim(),
                    //Salida = txtSalida.Text.Trim(),
                    activo = true
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    string msn = "Registro " + (txtIdSalida.Text != "0" ? "Actualizado" : "Agregado") + " Correctamenete";

                    MessageBox.Show(msn);

                    var _frm = Application.OpenForms["Salidas"] as Salidas;
                    if (!((_frm) != null))
                    {
                        Salidas frm = new Salidas();
                        inicializaForm(frm);
                    }
                    else
                    {
                        _frm.Show();
                        //_frm.btnActualizar_Click(null, null);
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

                if (txtSalida.Text.Trim() == "")
                {
                    txtSalida.Focus();
                    validado = false;

                    lblError.SetError(txtSalida, "Ingresar un Salida");
                }

                if (txtNombreSalida.Text.Trim() == "")
                {
                    txtNombreSalida.Focus();
                    validado = false;

                    lblError.SetError(txtNombreSalida, "Ingresar un Nombre");
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

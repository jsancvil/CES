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
    public partial class ProductoAlta : MetroFramework.Forms.MetroForm
    {
        public int _idProducto;
        public string _code;

        public ProductoAlta()
        {
            InitializeComponent();
            OnLoad();

        }

        private void ProductoAlta_Load(object sender, EventArgs e)
        {

            if (_idProducto != 0)
                cargarDatos();
            else
            {
                vaciarCampos();
                txtCodigo.Text = _code;
            }
        }

        protected void OnLoad()
        {
            try
            {
                var dtUM = new DB.Metodos.Catalogos.dtoUM
                {
                    operacion = "SelectAll",
                    activo = true
                }.CRUD().dtResult;


                ddlUM.DisplayMember = "nombre";
                ddlUM.ValueMember = "idUm";
                ddlUM.DataSource = dtUM;

                var dtGrupo = new DB.Metodos.Catalogos.dtoGrupo
                {
                    operacion = "SelectAll",
                    activo = true
                }.CRUD().dtResult;

                ddlGrupo.DisplayMember = "grupo";
                ddlGrupo.ValueMember = "idGrupo";
                ddlGrupo.DataSource = dtGrupo;

                txtIdProducto.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void vaciarCampos()
        {
            txtIdProducto.Text = "0";
            txtNombreProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            //ddlGrupo.SelectedValue = string.Empty;
            txtCodigo.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtMin.Text = string.Empty;
            txtMax.Text = string.Empty;
            //ddlUM.SelectedValue = string.Empty;

            btnGuardar.Text = "Guardar";
        }

        protected void cargarDatos()
        {
            try
            {
                var dt = new dtoProductos
                {
                    operacion = "SelectByID",
                    activo = true,
                    idProducto = _idProducto
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    txtIdProducto.Text = row["idProducto"].ToString();
                    txtNombreProducto.Text = row["nombre"].ToString();
                    txtDescripcion.Text = row["descripcion"].ToString();
                    ddlGrupo.SelectedValue = row["idGrupo"].ToString();
                    txtCodigo.Text = row["codigo"].ToString();
                    txtTotal.Text = row["total"].ToString();
                    txtMin.Text = row["minimo"].ToString();
                    txtMax.Text = row["maximo"].ToString();
                    ddlUM.SelectedValue = row["idUm"].ToString();
                    txtPrecioUnit.Text = row["pUnitario"] != DBNull.Value ? row["pUnitario"].ToString() : "";
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

                var result = new dtoProductos
                {
                    operacion = txtIdProducto.Text != "0" ? "Update" : "Insert",
                    idProducto = int.Parse(txtIdProducto.Text),
                    nombre = txtNombreProducto.Text,
                    descripcion = txtDescripcion.Text,
                    idGrupo = int.Parse(ddlGrupo.SelectedValue.ToString()),
                    codigo = txtCodigo.Text,
                    total = txtTotal.Text != "" ? decimal.Parse(txtTotal.Text) : 0,
                    minimo = txtMin.Text != "" ? decimal.Parse(txtMin.Text) : 0,
                    maximo = txtMax.Text != "" ? decimal.Parse(txtMax.Text) : 0,
                    idUm = int.Parse(ddlUM.SelectedValue.ToString()),
                    idUsuario = LoginInfo.idUsuario,
                    activo = true,
                    precioUnit = txtPrecioUnit.Text != "" ? decimal.Parse(txtPrecioUnit.Text) : 0,
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    string msn = "Registro " + (txtIdProducto.Text != "0" ? "Actualizado" : "Agregado") + " Correctamenete";

                    MessageBox.Show(msn);
                    if (!(_code.Length > 1))
                    {
                        var _frm = Application.OpenForms["Productos"] as Catalogos.Productos;
                        if (!((_frm) != null))
                        {
                            Productos frm = new Productos();
                            inicializaForm(frm);
                        }
                        else
                        {

                            _frm.Show();
                            _frm.btnActualizar_Click(null, null);

                        }
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

                if (txtCodigo.Text.Trim() == "")
                {
                    txtCodigo.Focus();
                    validado = false;

                    lblError.SetError(txtCodigo, "Ingresar Codigo");
                }

                if (txtNombreProducto.Text.Trim() == "")
                {
                    txtNombreProducto.Focus();
                    validado = false;

                    lblError.SetError(txtNombreProducto, "Ingresar Nombre");
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

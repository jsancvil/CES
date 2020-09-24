using CES.DB.Metodos.Catalogos;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages.Catalogos
{
    public partial class UMAlta : MetroFramework.Forms.MetroForm
    {
        public int _idUM;
        public UMAlta()
        {
            InitializeComponent();
            OnLoad();
        }

        private void UMAlta_Load(object sender, EventArgs e)
        {

            if (_idUM != 0)
                cargarDatos();
            else
                btnGuardar.Text = "Guardar";
        }

        private void ProductoAlta_Load(object sender, EventArgs e)
        {

            if (_idUM != 0)
                cargarDatos();
            else
                btnGuardar.Text = "Guardar";
        }

        protected void OnLoad()
        {
            try
            {
                txtIdUM.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void cargarDatos()
        {
            try
            {
                var dt = new dtoUM
                {
                    operacion = "SelectByID",
                    activo = true,
                    idUm = _idUM
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    txtIdUM.Text = row["idUM"].ToString();
                    txtUM.Text = row["UM"].ToString();
                    txtFechaAlta.Text = row["fechaAlta"] != DBNull.Value ? ((DateTime)row["fechaAlta"]).ToString("yyy-MM-dd HH:mm") : "";
                    txtNombreUM.Text = row["nombre"].ToString();
                    btnGuardar.Text = "Actualizar";
                }
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

                var result = new dtoUM
                {
                    operacion = txtIdUM.Text != "0" ? "Update" : "Insert",
                    idUm = int.Parse(txtIdUM.Text),
                    um = txtUM.Text,
                    nombre = txtNombreUM.Text,
                    idUsuario = LoginInfo.idUsuario,
                    activo = true
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    string msn = "Registro " + (txtIdUM.Text != "0" ? "Actualizado" : "Agregado") + " Correctamenete";

                    MessageBox.Show(msn);

                    var _frm = Application.OpenForms["UM"] as Catalogos.UM;
                    if (!((_frm) != null))
                    {
                        Catalogos.UM frm = new Catalogos.UM();
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

                if (txtUM.Text.Trim() == "")
                {
                    txtUM.Focus();
                    validado = false;

                    lblError.SetError(txtUM, "Ingresar Codigo");
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

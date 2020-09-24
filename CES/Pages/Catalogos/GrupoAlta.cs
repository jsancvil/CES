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
    public partial class GrupoAlta : MetroFramework.Forms.MetroForm
    {
        public int _idGrupo;
        public GrupoAlta()
        {
            InitializeComponent();
            OnLoad();
        }

        private void GrupoAlta_Load(object sender, EventArgs e)
        {

            if (_idGrupo != 0)
                cargarDatos();
            else
                btnGuardar.Text = "Guardar";
        }

        private void ProductoAlta_Load(object sender, EventArgs e)
        {

            if (_idGrupo != 0)
                cargarDatos();
            else
                btnGuardar.Text = "Guardar";
        }

        protected void OnLoad()
        {
            try
            {
                txtIdGrupo.Text = "0";

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
                var dt = new dtoGrupo
                {
                    operacion = "SelectByID",
                    activo = true,
                    idGrupo = _idGrupo
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    txtIdGrupo.Text = row["idGrupo"].ToString();
                    txtGrupo.Text = row["grupo"].ToString();
                    txtFechaAlta.Text = row["fechaAlta"].ToString();

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

                var result = new dtoGrupo
                {
                    operacion = txtIdGrupo.Text != "0" ? "Update" : "Insert",
                    idGrupo = int.Parse(txtIdGrupo.Text),
                    grupo = txtGrupo.Text,
                    idUsuario = LoginInfo.idUsuario,
                    activo = true
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    string msn = "Registro " + (txtIdGrupo.Text != "0" ? "Actualizado" : "Agregado") + " Correctamenete";

                    MessageBox.Show(msn);

                    var _frm = Application.OpenForms["Grupos"] as Catalogos.Grupos;
                    if (!((_frm) != null))
                    {
                        Catalogos.Grupos frm = new Catalogos.Grupos();
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

                if (txtGrupo.Text.Trim() == "")
                {
                    txtGrupo.Focus();
                    validado = false;

                    lblError.SetError(txtGrupo, "Ingresar Codigo");
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

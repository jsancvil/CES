using CES.DB.Metodos.Catalogos;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages.Catalogos
{
    public partial class Grupos : MetroFramework.Forms.MetroForm
    {
        readonly function ofunciones = new function();
        public Grupos()
        {
            InitializeComponent();

            OnLoad();
        }

        public DataTable dt;

        protected void OnLoad()
        {
            try
            {
                dt = new dtoGrupo
                {
                    operacion = "SelectAll",
                    activo = true
                }.CRUD().dtResult;

                gvData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GrupoAlta frm = new GrupoAlta();
            var menu = Application.OpenForms["menu"] as Menu;
            var _frm = Application.OpenForms["GrupoAlta"] as Catalogos.GrupoAlta;
            frm._idGrupo = 0;
            ofunciones.cargarForm(frm, _frm, menu);
        }


        public void btnActualizar_Click(object sender, EventArgs e)
        {
            OnLoad();
        }

        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 if (e.RowIndex == -1 || e.ColumnIndex == -1)
                    return;

                string idGrupo = gvData.Rows[e.RowIndex].Cells["idGrupo"].FormattedValue.ToString();

                if (gvData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el grupo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        var result = new dtoGrupo
                        {
                            operacion = "Delete",
                            idGrupo = int.Parse(idGrupo),
                            activo = false,
                            idUsuario = LoginInfo.idUsuario
                        }.CRUD();

                        if (!bool.Parse(result.hasError.ToString()))
                        {
                            string msn = "Registro Eliminado Correctamenete";

                            MessageBox.Show(msn);

                            OnLoad();

                        }
                        else
                            MessageBox.Show(result.messageError);
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            string nombre = DateTime.Now.ToString("yyyyMMddHHmmss");
            nombre = string.Format("Grupos_{0}.xlsx", nombre);

            //Exporting to Excel
            string folderPath = "C:\\CES\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {

                wb.Worksheets.Add(dt, "Customers");
                wb.SaveAs(folderPath + nombre);
            }

            if (MessageBox.Show("Archivo generado correctamente ¿Abrir ubicación del archivo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(@folderPath);
            }
        }

        private void gvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idGrupo = gvData.Rows[e.RowIndex].Cells["idGrupo"].FormattedValue.ToString();

                GrupoAlta frm = new GrupoAlta();
                var _frm = Application.OpenForms["GrupoAlta"] as ProductoAlta;
                var menu = Application.OpenForms["menu"] as Menu;
                frm._idGrupo = int.Parse(idGrupo);
                ofunciones.cargarForm(frm, null, menu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using CES.DB.Metodos.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Diagnostics;
using CES.DB.Metodos.config;

namespace CES.Pages.Catalogos
{
    public partial class Proveedores : MetroFramework.Forms.MetroForm
    {
        readonly function ofunciones = new function();
        readonly ObjetosFunciones objFunciones = new ObjetosFunciones();

        public DataTable dt;

        private int PgSize = 20;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;

        public Proveedores()
        {
            InitializeComponent();
            ddlPaginas.SelectedValue = "20";
            OnLoad();
        }

        protected void OnLoad()
        {
            try
            {
                var dtPaginado = new DB.Metodos.config.dtoTablasPaginado
                {
                    operacion = "SelectAll",
                    activo = true
                }.CRUD().dtResult;


                ddlPaginas.DisplayMember = "nombre";
                ddlPaginas.ValueMember = "valor";
                ddlPaginas.DataSource = dtPaginado;

                ddlPaginas.SelectedValue = "20";
                PgSize = int.Parse(ddlPaginas.SelectedValue.ToString());

                string query = "SELECT COUNT(*) FROM Catalogo.Proveedores WHERE activo = 1";
                var dtReg = objFunciones.selectByQuery(query);
                int rowCount = dtReg != null ? int.Parse(dtReg.Rows[0][0].ToString()) : 0;

                TotalPage = rowCount / PgSize;
                // if any row left after calculated pages, add one more page 
                if (rowCount % PgSize > 0)
                    TotalPage += 1;


                lblTotal.Text = "Total de Proveedores: " + rowCount;

                GetCurrentRecords(CurrentPageIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCurrentRecords(int page)
        {
            DataTable dt = new DataTable();

            int indexFin = PgSize;
            int indexInicio = (page * PgSize) - PgSize;


            dt = new dtoProveedores
            {
                operacion = "SelectAll",
                activo = true,
                indexInicio = indexInicio,
                indexFin = indexFin
            }.CRUD().dtResult;

            gvData.DataSource = dt;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            ProveedorAlta frm = new ProveedorAlta();
            var menu = Application.OpenForms["menu"] as Menu;
            var _frm = Application.OpenForms["ProveedorAlta"] as Catalogos.ProveedorAlta;
            ofunciones.cargarForm(frm, _frm, menu);
        }

        protected void inicializaForm(Form frm)
        {
            var menu = Application.OpenForms["menu"] as Menu;
            frm.MdiParent = menu;

            //frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            OnLoad();
        }



        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idProveedor = gvData.Rows[e.RowIndex].Cells["idProveedor"].FormattedValue.ToString();

                if (gvData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el Proveedor?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        var result = new dtoProveedores
                        {
                            operacion = "Delete",
                            idProveedor = int.Parse(idProveedor),
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
            nombre = string.Format("Proveedores_{0}.xlsx", nombre);

            //Creating DataTable
            //DataTable dt = new DataTable();

            ////Adding the Columns
            //foreach (DataGridViewColumn column in gvData.Columns)
            //{
            //    if(column.Name != "Delete")
            //        dt.Columns.Add(column.HeaderText, column.ValueType);
            //}

            ////Adding the Rows
            //foreach (DataGridViewRow row in gvData.Rows)
            //{
            //    dt.Rows.Add();
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
            //    }
            //}

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

        private void btnPrimeraPagina_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            GetCurrentRecords(this.CurrentPageIndex);
        }

        private void btnSiguientePagina_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                GetCurrentRecords(this.CurrentPageIndex);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                GetCurrentRecords(this.CurrentPageIndex);
            }
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            GetCurrentRecords(this.CurrentPageIndex);
        }

        private void ddlPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PgSize = int.Parse(ddlPaginas.SelectedValue.ToString());

                string query = "SELECT COUNT(*) FROM Catalogo.Proveedores WHERE activo = 1";
                var dtReg = objFunciones.selectByQuery(query);
                int rowCount = dtReg != null ? int.Parse(dtReg.Rows[0][0].ToString()) : 0;

                TotalPage = rowCount / PgSize;
                // if any row left after calculated pages, add one more page 
                if (rowCount % PgSize > 0)
                    TotalPage += 1;


                lblTotal.Text = "Total de Proveedores: " + rowCount;

                GetCurrentRecords(CurrentPageIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idProveedor = gvData.Rows[e.RowIndex].Cells["idProveedor"].FormattedValue.ToString();

                ProveedorAlta frm = new ProveedorAlta();
                var _frm = Application.OpenForms["ProveedorAlta"] as ProveedorAlta;
                var menu = Application.OpenForms["menu"] as Menu;
                frm._idProveedor = int.Parse(idProveedor);
                ofunciones.cargarForm(frm, _frm, menu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

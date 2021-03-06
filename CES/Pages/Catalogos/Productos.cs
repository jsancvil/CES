﻿using CES.DB.Metodos.Catalogos;
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
    public partial class Productos : MetroFramework.Forms.MetroForm
    {
        readonly function ofunciones = new function();
        readonly ObjetosFunciones objFunciones = new ObjetosFunciones();

        public DataTable dt;

        private int PgSize = 20;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;

        public Productos()
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

                string query = "SELECT COUNT(*) FROM Catalogo.Productos WHERE activo = 1";
                var dtReg = objFunciones.selectByQuery(query);
                int rowCount = dtReg != null ? int.Parse(dtReg.Rows[0][0].ToString()) : 0;

                TotalPage = rowCount / PgSize;
                // if any row left after calculated pages, add one more page 
                if (rowCount % PgSize > 0)
                    TotalPage += 1;


                lblTotal.Text = "Total de productos: " + rowCount;

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


            dt = new dtoProductos
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

            ProductoAlta frm = new ProductoAlta();
            var menu = Application.OpenForms["menu"] as Menu;
            var _frm = Application.OpenForms["ProductoAlta"] as Catalogos.ProductoAlta;
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
                 if (e.RowIndex == -1 || e.ColumnIndex == -1)
                    return;

                string idProducto = gvData.Rows[e.RowIndex].Cells["idProducto"].FormattedValue.ToString();

                if (gvData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el producto?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        var result = new dtoProductos
                        {
                            operacion = "Delete",
                            idProducto = int.Parse(idProducto),
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
            try
            {
                string nombre = DateTime.Now.ToString("yyyyMMddHHmmss");
                nombre = string.Format("Productos_{0}.xlsx", nombre);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                string query = "SELECT COUNT(*) FROM Catalogo.Productos WHERE activo = 1";
                var dtReg = objFunciones.selectByQuery(query);
                int rowCount = dtReg != null ? int.Parse(dtReg.Rows[0][0].ToString()) : 0;

                TotalPage = rowCount / PgSize;
                // if any row left after calculated pages, add one more page 
                if (rowCount % PgSize > 0)
                    TotalPage += 1;


                lblTotal.Text = "Total de productos: " + rowCount;

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
                string idProducto = gvData.Rows[e.RowIndex].Cells["idProducto"].FormattedValue.ToString();

                ProductoAlta frm = new ProductoAlta();
                var _frm = Application.OpenForms["ProductoAlta"] as ProductoAlta;
                var menu = Application.OpenForms["menu"] as Menu;
                frm._idProducto = int.Parse(idProducto);
                ofunciones.cargarForm(frm, null, menu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

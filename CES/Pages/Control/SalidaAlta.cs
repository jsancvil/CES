﻿using CES.DB.Metodos.Catalogos;
using CES.DB.Metodos.config;
using CES.DB.Metodos.Control;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages.Control
{
    public partial class SalidaAlta : MetroFramework.Forms.MetroForm
    {
        readonly function ofunciones = new function();

        public int _idSalida;
        public DataTable dt;
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
                var dtUser = new dtoUsuarios
                {
                    operacion = "SelectByNombre",
                    activo = true,
                }.CRUD().dtResult;                
                

                ddlIdSolicita.DisplayMember = "nombre";
                ddlIdSolicita.ValueMember = "idUsuario";
                ddlIdSolicita.DataSource = dtUser;

                ddlIdSolicita.SelectedValue = "0";


                txtFechaAlta.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                txtIdSalida.Text = "0";

                inicializaTabla();
                gvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void vaciarCampos()
        {
            txtIdSalida.Text = "0";
            txtOtroReceptor.Text = string.Empty;

            btnGuardar.Text = "Guardar";
        }

        protected void cargarDatos()
        {
            try
            {
                var dtSalidas = new dtoSalidas
                {
                    operacion = "SelectByID",
                    activo = true,
                    idSalida = _idSalida
                }.CRUD().dtResult;

                foreach (DataRow row in dtSalidas.Rows)
                {
                    txtIdSalida.Text = row["idSalida"].ToString();
                    txtOtroReceptor.Text = row["otroSolicita"].ToString();
                    txtFolio.Text = row["folio"].ToString();

                    ddlIdSolicita.SelectedValue = row["idUsuarioSolicita"].ToString();

                    btnGuardar.Enabled = false;
                    btnAdd.Enabled = false;
                    txtCode.Enabled = false;
                    txtCantidad.Enabled = false;
                    //txtPrecioUnit.Enabled = false;
                    ddlIdSolicita.Enabled = false;
                    txtOtroReceptor.Enabled = false;
                    txtFolio.Enabled = false;
                    //txtSubTotal.Enabled = false;
                    chkAutomatico.Enabled = false;
                }

                var dtPartidas = new dtoSalidasPartidas
                {
                    operacion = "SelectByidSalida",
                    idSalida = _idSalida
                }.CRUD().dtResult;


                dt = dtPartidas;
                gvData.DataSource = dtPartidas;
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
                    fechaAlta = DateTime.Parse(txtFechaAlta.Text),
                    folio = txtFolio.Text.Trim(),
                    idUsuarioAutoriza = LoginInfo.idUsuario,
                    otroSolicita = txtOtroReceptor.Text.Trim(),
                    idUsuarioSolicita = int.Parse(ddlIdSolicita.SelectedValue.ToString()),
                    activo = true
                }.CRUD();

                if (!bool.Parse(result.hasError.ToString()))
                {
                    int idSalida = int.Parse(result.idOut);

                    //Agergar las partidas
                    foreach (DataRow row in dt.Rows)
                    {
                        var dtoPartidas = new dtoSalidasPartidas
                        {
                            operacion = "Insert",
                            idSalida = idSalida,
                            code = row["code"].ToString(),
                            activo = true,
                            cantidad = (decimal)row["cantidad"],
                            idProducto = (int)row["idProducto"],
                            nombre = row["nombre"].ToString(),
                        }.CRUD();

                    }


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

                if (txtFolio.Text.Trim() == "")
                {
                    txtFolio.Focus();
                    validado = false;

                    lblError.SetError(txtFolio, "Ingresar un Salida");
                }

                if (txtOtroReceptor.Text.Trim() == "")
                {
                    txtOtroReceptor.Focus();
                    validado = false;

                    lblError.SetError(txtOtroReceptor, "Ingresar un Nombre");
                }

            }
            catch (Exception ex)
            {
                validado = false;
                MessageBox.Show(ex.Message);
            }

            return validado;
        }

        bool validaCamposAdd()
        {
            bool validado = true;

            try
            {

                if (txtCantidad.Text.Trim() == "")
                {
                    txtCantidad.Focus();
                    validado = false;

                    lblError.SetError(txtCantidad, "Captura la cantidad");
                }

                if (txtCode.Text.Trim() == "")
                {
                    txtCode.Focus();
                    validado = false;

                    lblError.SetError(txtCode, "Captura Codigo");
                }

                if (lblNombre.Text.Trim() == "--------------")
                {
                    txtCode.Focus();
                    validado = false;

                    lblError.SetError(lblNombre, "No existe");
                }

            }
            catch (Exception ex)
            {
                validado = false;
                MessageBox.Show(ex.Message);
            }

            return validado;
        }

        private void chkAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked)
            {
                txtCantidad.Text = "";
            }
            else
            {
                txtCantidad.Text = "1";

            }
        }

        //private void txtCantidad_TextChanged(object sender, EventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        txtPrecioUnit.Focus();
        //    }
        //}

        //private void txtPrecioUnit_TextChanged(object sender, EventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        //Add Registro
        //        add();
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add Registro
            buscarProducto();
        }

        protected void add()
        {
            try
            {
                if (!validaCamposAdd())
                {
                    return;
                }

                DataRow myDataRow;

                string code = txtCode.Text;
                string producto = lblNombre.Text;
                decimal cantidad = txtCantidad.Text != "" ? decimal.Parse(txtCantidad.Text) : 1;
                int idProducto = lblIdProducto.Text != "" ? int.Parse(lblIdProducto.Text) : 0;

                myDataRow = dt.NewRow();
                myDataRow["idPartida"] = dt.Rows.Count + 1;
                myDataRow["code"] = code;
                myDataRow["nombre"] = producto;
                myDataRow["cantidad"] = cantidad;
                myDataRow["idProducto"] = idProducto;
                dt.Rows.Add(myDataRow);

                txtCode.Text = string.Empty;
                txtCode.Focus();

                //lblNombre.Text = string.Empty;

                if (chkAutomatico.Checked)
                {
                    txtCantidad.Text = "";
                }
                else
                {
                    txtCantidad.Text = "1";

                }

                DataView dv = dt.DefaultView;
                dv.Sort = "idPartida desc";
                dt = dv.ToTable();
                gvData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Create Customers table   
        private void inicializaTabla()
        {
            // Create a new DataTable.    
            DataTable custTable = new DataTable("Customers");
            DataColumn dtColumn;
            DataRow myDataRow;

            // Create id column  
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "idPartida";
            dtColumn.Caption = "idPartida";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;
            // Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "idProducto";
            dtColumn.Caption = "idProducto";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "code";
            dtColumn.Caption = "code";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "nombre";
            dtColumn.Caption = "nombre";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(decimal);
            dtColumn.ColumnName = "cantidad";
            dtColumn.Caption = "cantidad";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(decimal);
            dtColumn.ColumnName = "pUnitario";
            dtColumn.Caption = "pUnitario";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Create Name column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(decimal);
            dtColumn.ColumnName = "pTotal";
            dtColumn.Caption = "pTotal";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            custTable.Columns.Add(dtColumn);

            // Make id column the primary key column.    
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = custTable.Columns["idPartida"];
            custTable.PrimaryKey = PrimaryKeyColumns;

            dt = custTable.Copy();
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarProducto();
            }
        }

        public void buscarProducto()
        {

            try
            {
                if (txtCode.Text.Trim() == "")
                    return;

                //lblNombre.Text = string.Empty; ;
                lblGrupo.Text = "--------------";
                lblPrecioUnit.Text = "--------------";
                lblNombre.Text = "--------------";

                var result = new dtoProductos
                {
                    operacion = "SearchByCode",
                    codigo = txtCode.Text,
                    activo = true
                }.CRUD();


                if (!bool.Parse(result.hasError.ToString()))
                {

                    foreach (DataRow row in result.dtResult.Rows)
                    {
                        lblNombre.Text = row["nombre"].ToString();
                        lblGrupo.Text = row["grupo"].ToString();
                        lblPrecioUnit.Text = "$ " + row["pUnitario"].ToString();
                        lblIdProducto.Text = row["idProducto"].ToString();

                        //if (txtPrecioUnit.Text == "")
                        //    txtPrecioUnit.Text = row["pUnitario"].ToString();

                        //txtCode.Text = string.Empty;
                    }

                    if (result.dtResult.Rows.Count == 0)
                    {
                        if (MessageBox.Show("El producto no existe ¿Quieres agregarlo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Catalogos.ProductoAlta frm = new Catalogos.ProductoAlta();
                            var _frm = Application.OpenForms["ProductoAlta"] as Catalogos.ProductoAlta;
                            var menu = Application.OpenForms["menu"] as Menu;
                            frm._code = txtCode.Text;
                            ofunciones.cargarForm(frm, _frm, menu);

                            txtCode.Text = string.Empty;
                            //txtCode.Focus();
                        }
                    }
                    else
                    {

                        if (chkAutomatico.Checked)
                        {
                            if (txtCantidad.Text == "")
                                txtCantidad.Focus();
                            else
                                add();

                        }
                        else
                        {
                            add();
                        }
                    }
                }
                else
                    MessageBox.Show(result.messageError);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = gvData.Rows[e.RowIndex].Cells["idPartida"].FormattedValue.ToString();

                if (gvData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DataRow[] dtr = dt.Select("idPartida=" + id);
                    foreach (var drow in dtr)
                    {
                        drow.Delete();
                    }

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
                nombre = string.Format("SalidaPartidas_{0}.xlsx", nombre);

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
    }
}

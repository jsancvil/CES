using CES.DB.DataSets.CatalogosTableAdapters;

namespace CES.Pages.Control
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvData = new MetroFramework.Controls.MetroGrid();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVer = new System.Windows.Forms.Label();
            this.ddlPaginas = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguientePagina = new System.Windows.Forms.Button();
            this.btnUltimaPagina = new System.Windows.Forms.Button();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.config = new CES.DB.DataSets.Config();
            this.catalogos = new CES.DB.DataSets.Catalogos();
            this.productosspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productos_spTableAdapter = new CES.DB.DataSets.CatalogosTableAdapters.Productos_spTableAdapter();
            this._idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosspBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            this.gvData.AllowUserToResizeRows = false;
            this.gvData.AutoGenerateColumns = false;
            this.gvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._idProducto,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.Precio,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.Delete});
            this.gvData.DataSource = this.productosspBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvData.EnableHeadersVisualStyles = false;
            this.gvData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvData.Location = new System.Drawing.Point(20, 60);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(966, 460);
            this.gvData.TabIndex = 0;
            this.gvData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            this.gvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellDoubleClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(648, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 23);
            this.btnActualizar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(757, 31);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(103, 23);
            this.btnExportar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVer);
            this.panel1.Controls.Add(this.ddlPaginas);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnSiguientePagina);
            this.panel1.Controls.Add(this.btnUltimaPagina);
            this.panel1.Controls.Add(this.btnPrimeraPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 29);
            this.panel1.TabIndex = 5;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(201, 7);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(23, 13);
            this.lblVer.TabIndex = 6;
            this.lblVer.Text = "Ver";
            // 
            // ddlPaginas
            // 
            this.ddlPaginas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPaginas.FormattingEnabled = true;
            this.ddlPaginas.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "500",
            "1000",
            "Todos"});
            this.ddlPaginas.Location = new System.Drawing.Point(230, 4);
            this.ddlPaginas.Name = "ddlPaginas";
            this.ddlPaginas.Size = new System.Drawing.Size(99, 21);
            this.ddlPaginas.TabIndex = 5;
            this.ddlPaginas.SelectedIndexChanged += new System.EventHandler(this.ddlPaginas_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(3, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(614, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(110, 23);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguientePagina
            // 
            this.btnSiguientePagina.Location = new System.Drawing.Point(498, 3);
            this.btnSiguientePagina.Name = "btnSiguientePagina";
            this.btnSiguientePagina.Size = new System.Drawing.Size(110, 23);
            this.btnSiguientePagina.TabIndex = 2;
            this.btnSiguientePagina.Text = "Siguiente página";
            this.btnSiguientePagina.UseVisualStyleBackColor = true;
            this.btnSiguientePagina.Click += new System.EventHandler(this.btnSiguientePagina_Click);
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.Location = new System.Drawing.Point(730, 3);
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(110, 23);
            this.btnUltimaPagina.TabIndex = 1;
            this.btnUltimaPagina.Text = "Ultima página";
            this.btnUltimaPagina.UseVisualStyleBackColor = true;
            this.btnUltimaPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
            // 
            // btnPrimeraPagina
            // 
            this.btnPrimeraPagina.Location = new System.Drawing.Point(382, 3);
            this.btnPrimeraPagina.Name = "btnPrimeraPagina";
            this.btnPrimeraPagina.Size = new System.Drawing.Size(110, 23);
            this.btnPrimeraPagina.TabIndex = 0;
            this.btnPrimeraPagina.Text = "Primera página";
            this.btnPrimeraPagina.UseVisualStyleBackColor = true;
            this.btnPrimeraPagina.Click += new System.EventHandler(this.btnPrimeraPagina_Click);
            // 
            // config
            // 
            this.config.DataSetName = "Config";
            this.config.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogos
            // 
            this.catalogos.DataSetName = "Catalogos";
            this.catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosspBindingSource
            // 
            this.productosspBindingSource.DataMember = "Productos_sp";
            this.productosspBindingSource.DataSource = this.catalogos;
            // 
            // productos_spTableAdapter
            // 
            this.productos_spTableAdapter.ClearBeforeFill = true;
            // 
            // _idProducto
            // 
            this._idProducto.DataPropertyName = "idProducto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this._idProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this._idProducto.FillWeight = 50F;
            this._idProducto.HeaderText = "#";
            this._idProducto.Name = "_idProducto";
            this._idProducto.ReadOnly = true;
            this._idProducto.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nomUM";
            this.dataGridViewTextBoxColumn8.FillWeight = 50F;
            this.dataGridViewTextBoxColumn8.HeaderText = "UM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Grupo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "pUnitario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio Unit.";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "minimo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "maximo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = "Eliminar";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gvData);
            this.Name = "Inventario";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosspBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DB.DataSets.Config config;
        private MetroFramework.Controls.MetroGrid gvData;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnExportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguientePagina;
        private System.Windows.Forms.Button btnUltimaPagina;
        private System.Windows.Forms.Button btnPrimeraPagina;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox ddlPaginas;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosspBindingSource;
        private DB.DataSets.Catalogos catalogos;
        private Productos_spTableAdapter productos_spTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
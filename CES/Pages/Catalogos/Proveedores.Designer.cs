using CES.DB.DataSets.CatalogosTableAdapters;

namespace CES.Pages.Catalogos
{
    partial class Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProveedoresspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Proveedores_spTableAdapter = new CES.DB.DataSets.CatalogosTableAdapters.Proveedores_spTableAdapter();
            this.gvData = new MetroFramework.Controls.MetroGrid();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.proveedoresspBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catalogos = new CES.DB.DataSets.Catalogos();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
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
            this.usuariosspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios_spTableAdapter = new CES.DB.DataSets.ConfigTableAdapters.Usuarios_spTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresspBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosspBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Proveedores_spTableAdapter
            // 
            this.Proveedores_spTableAdapter.ClearBeforeFill = true;
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
            this.idProveedor,
            this.dataGridViewTextBoxColumn1,
            this.rFCDataGridViewTextBoxColumn,
            this.nomContactoDataGridViewTextBoxColumn,
            this.telContactoDataGridViewTextBoxColumn,
            this.mailContactoDataGridViewTextBoxColumn,
            this.Delete});
            this.gvData.DataSource = this.proveedoresspBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvData.EnableHeadersVisualStyles = false;
            this.gvData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvData.Location = new System.Drawing.Point(20, 60);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(862, 460);
            this.gvData.TabIndex = 0;
            this.gvData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            this.gvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellDoubleClick);
            // 
            // idProveedor
            // 
            this.idProveedor.DataPropertyName = "idProveedor";
            this.idProveedor.FillWeight = 50F;
            this.idProveedor.HeaderText = "#";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomContactoDataGridViewTextBoxColumn
            // 
            this.nomContactoDataGridViewTextBoxColumn.DataPropertyName = "nomContacto";
            this.nomContactoDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nomContactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.nomContactoDataGridViewTextBoxColumn.Name = "nomContactoDataGridViewTextBoxColumn";
            this.nomContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomContactoDataGridViewTextBoxColumn.Width = 200;
            // 
            // telContactoDataGridViewTextBoxColumn
            // 
            this.telContactoDataGridViewTextBoxColumn.DataPropertyName = "telContacto";
            this.telContactoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telContactoDataGridViewTextBoxColumn.Name = "telContactoDataGridViewTextBoxColumn";
            this.telContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailContactoDataGridViewTextBoxColumn
            // 
            this.mailContactoDataGridViewTextBoxColumn.DataPropertyName = "mailContacto";
            this.mailContactoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.mailContactoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.mailContactoDataGridViewTextBoxColumn.Name = "mailContactoDataGridViewTextBoxColumn";
            this.mailContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailContactoDataGridViewTextBoxColumn.Width = 120;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Eliminar";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // proveedoresspBindingSource1
            // 
            this.proveedoresspBindingSource1.DataMember = "Proveedores_sp";
            this.proveedoresspBindingSource1.DataSource = this.catalogos;
            // 
            // catalogos
            // 
            this.catalogos.DataSetName = "Catalogos";
            this.catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(539, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 23);
            this.btnNuevo.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo Proveedor";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.panel1.Size = new System.Drawing.Size(862, 29);
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
            // usuariosspBindingSource
            // 
            this.usuariosspBindingSource.DataMember = "Usuarios_sp";
            this.usuariosspBindingSource.DataSource = this.config;
            // 
            // usuarios_spTableAdapter
            // 
            this.usuarios_spTableAdapter.ClearBeforeFill = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gvData);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresspBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosspBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ProveedoresspBindingSource;
        private DB.DataSets.Config config;
        private System.Windows.Forms.BindingSource usuariosspBindingSource;
        private DB.DataSets.ConfigTableAdapters.Usuarios_spTableAdapter usuarios_spTableAdapter;
        private DB.DataSets.CatalogosTableAdapters.Proveedores_spTableAdapter Proveedores_spTableAdapter;
        private MetroFramework.Controls.MetroGrid gvData;
        private MetroFramework.Controls.MetroButton btnNuevo;
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
        private System.Windows.Forms.BindingSource proveedoresspBindingSource1;
        private DB.DataSets.Catalogos catalogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
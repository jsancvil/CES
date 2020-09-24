namespace CES.Pages.Catalogos
{
    partial class Grupos
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
            this.gvData = new MetroFramework.Controls.MetroGrid();
            this.idGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grupospBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogos = new CES.DB.DataSets.Catalogos();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.grupo_spTableAdapter = new CES.DB.DataSets.CatalogosTableAdapters.Grupo_spTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupospBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
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
            this.idGrupo,
            this.grupoDataGridViewTextBoxColumn,
            this.Delete});
            this.gvData.DataSource = this.grupospBindingSource;
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
            this.gvData.Size = new System.Drawing.Size(416, 331);
            this.gvData.TabIndex = 0;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            this.gvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellDoubleClick);
            // 
            // idGrupo
            // 
            this.idGrupo.DataPropertyName = "idGrupo";
            this.idGrupo.FillWeight = 50F;
            this.idGrupo.HeaderText = "#";
            this.idGrupo.Name = "idGrupo";
            this.idGrupo.ReadOnly = true;
            this.idGrupo.Width = 50;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "grupo";
            this.grupoDataGridViewTextBoxColumn.FillWeight = 250F;
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoDataGridViewTextBoxColumn.Width = 250;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.NullValue = "Eliminar";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 70F;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "";
            this.Delete.Width = 70;
            // 
            // grupospBindingSource
            // 
            this.grupospBindingSource.DataMember = "Grupo_sp";
            this.grupospBindingSource.DataSource = this.catalogos;
            // 
            // catalogos
            // 
            this.catalogos.DataSetName = "Catalogos";
            this.catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //  
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(112, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 23);
            this.btnNuevo.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Grupo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(221, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 23);
            this.btnActualizar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(330, 31);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(103, 23);
            this.btnExportar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // grupo_spTableAdapter
            // 
            this.grupo_spTableAdapter.ClearBeforeFill = true;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 411);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gvData);
            this.Name = "Grupos";
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupospBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gvData;
        private System.Windows.Forms.BindingSource grupospBindingSource;
        private DB.DataSets.Catalogos catalogos;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private DB.DataSets.CatalogosTableAdapters.Grupo_spTableAdapter grupo_spTableAdapter;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
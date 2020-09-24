namespace CES.Pages.Control
{
    partial class EntradaAlta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioUnit = new MetroFramework.Controls.MetroTextBox();
            this.lblGrupo = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioUnit = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkAutomatico = new MetroFramework.Controls.MetroCheckBox();
            this.gvData = new MetroFramework.Controls.MetroGrid();
            this.entradasPartidasspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.control = new CES.DB.DataSets.Control();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtFolio = new MetroFramework.Controls.MetroTextBox();
            this.ddlProveedor = new MetroFramework.Controls.MetroComboBox();
            this.txtFechaAlta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreEntrada = new MetroFramework.Controls.MetroTextBox();
            this.txtIdEntrada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.entradasspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradas_spTableAdapter = new CES.DB.DataSets.ControlTableAdapters.Entradas_spTableAdapter();
            this.entradasPartidas_spTableAdapter = new CES.DB.DataSets.ControlTableAdapters.EntradasPartidas_spTableAdapter();
            this.salidasPartidas_spTableAdapter = new CES.DB.DataSets.ControlTableAdapters.SalidasPartidas_spTableAdapter();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.idPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasPartidasspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasspBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdProducto);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.txtPrecioUnit);
            this.panel1.Controls.Add(this.lblGrupo);
            this.panel1.Controls.Add(this.lblPrecioUnit);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.chkAutomatico);
            this.panel1.Controls.Add(this.gvData);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.ddlProveedor);
            this.panel1.Controls.Add(this.txtFechaAlta);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtNombreEntrada);
            this.panel1.Controls.Add(this.txtIdEntrada);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 469);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(961, 191);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(73, 19);
            this.metroLabel10.TabIndex = 40;
            this.metroLabel10.Text = "Precio Unit";
            // 
            // txtPrecioUnit
            // 
            // 
            // 
            // 
            this.txtPrecioUnit.CustomButton.Image = null;
            this.txtPrecioUnit.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtPrecioUnit.CustomButton.Name = "";
            this.txtPrecioUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioUnit.CustomButton.TabIndex = 1;
            this.txtPrecioUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioUnit.CustomButton.UseSelectable = true;
            this.txtPrecioUnit.CustomButton.Visible = false;
            this.txtPrecioUnit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioUnit.Lines = new string[0];
            this.txtPrecioUnit.Location = new System.Drawing.Point(961, 213);
            this.txtPrecioUnit.MaxLength = 32767;
            this.txtPrecioUnit.Name = "txtPrecioUnit";
            this.txtPrecioUnit.PasswordChar = '\0';
            this.txtPrecioUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioUnit.SelectedText = "";
            this.txtPrecioUnit.SelectionLength = 0;
            this.txtPrecioUnit.SelectionStart = 0;
            this.txtPrecioUnit.ShortcutsEnabled = true;
            this.txtPrecioUnit.Size = new System.Drawing.Size(117, 23);
            this.txtPrecioUnit.TabIndex = 8;
            this.txtPrecioUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioUnit.UseSelectable = true;
            this.txtPrecioUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(683, 317);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(93, 19);
            this.lblGrupo.TabIndex = 38;
            this.lblGrupo.Text = "--------------";
            // 
            // lblPrecioUnit
            // 
            this.lblPrecioUnit.AutoSize = true;
            this.lblPrecioUnit.Location = new System.Drawing.Point(683, 285);
            this.lblPrecioUnit.Name = "lblPrecioUnit";
            this.lblPrecioUnit.Size = new System.Drawing.Size(93, 19);
            this.lblPrecioUnit.TabIndex = 37;
            this.lblPrecioUnit.Text = "--------------";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(683, 253);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 19);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "--------------";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(631, 317);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Grupo";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(601, 285);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Precio Unit.";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(618, 253);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Nombre";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(942, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCantidad.Lines = new string[] {
        "1"};
            this.txtCantidad.Location = new System.Drawing.Point(838, 213);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(117, 23);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(838, 191);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Cantidad";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(618, 213);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(206, 23);
            this.txtCode.TabIndex = 6;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(618, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Codigo";
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Location = new System.Drawing.Point(693, 163);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(177, 15);
            this.chkAutomatico.TabIndex = 5;
            this.chkAutomatico.Text = "Capturar Cantidad y/o precio";
            this.chkAutomatico.UseSelectable = true;
            this.chkAutomatico.CheckedChanged += new System.EventHandler(this.chkAutomatico_CheckedChanged);
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
            this.idPartida,
            this.codeDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.pUnitarioDataGridViewTextBoxColumn,
            this.pTotalDataGridViewTextBoxColumn,
            this.Delete});
            this.gvData.DataSource = this.entradasPartidasspBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvData.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvData.EnableHeadersVisualStyles = false;
            this.gvData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvData.Location = new System.Drawing.Point(4, 4);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(589, 419);
            this.gvData.TabIndex = 27;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            // 
            // entradasPartidasspBindingSource
            // 
            this.entradasPartidasspBindingSource.DataMember = "EntradasPartidas_sp";
            this.entradasPartidasspBindingSource.DataSource = this.control;
            // 
            // control
            // 
            this.control.DataSetName = "Control";
            this.control.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(618, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Proveedor";
            // 
            // txtSubTotal
            // 
            // 
            // 
            // 
            this.txtSubTotal.CustomButton.Image = null;
            this.txtSubTotal.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtSubTotal.CustomButton.Name = "";
            this.txtSubTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubTotal.CustomButton.TabIndex = 1;
            this.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubTotal.CustomButton.UseSelectable = true;
            this.txtSubTotal.CustomButton.Visible = false;
            this.txtSubTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSubTotal.Lines = new string[0];
            this.txtSubTotal.Location = new System.Drawing.Point(923, 119);
            this.txtSubTotal.MaxLength = 32767;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.ShortcutsEnabled = true;
            this.txtSubTotal.Size = new System.Drawing.Size(156, 23);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.UseSelectable = true;
            this.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(858, 123);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(58, 19);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "SubTotal";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(648, 119);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 19);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Folio";
            // 
            // txtFolio
            // 
            // 
            // 
            // 
            this.txtFolio.CustomButton.Image = null;
            this.txtFolio.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtFolio.CustomButton.Name = "";
            this.txtFolio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolio.CustomButton.TabIndex = 1;
            this.txtFolio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolio.CustomButton.UseSelectable = true;
            this.txtFolio.CustomButton.Visible = false;
            this.txtFolio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFolio.Lines = new string[0];
            this.txtFolio.Location = new System.Drawing.Point(695, 119);
            this.txtFolio.MaxLength = 32767;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.PasswordChar = '\0';
            this.txtFolio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolio.SelectedText = "";
            this.txtFolio.SelectionLength = 0;
            this.txtFolio.SelectionStart = 0;
            this.txtFolio.ShortcutsEnabled = true;
            this.txtFolio.Size = new System.Drawing.Size(136, 23);
            this.txtFolio.TabIndex = 3;
            this.txtFolio.UseSelectable = true;
            this.txtFolio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ddlProveedor
            // 
            this.ddlProveedor.FormattingEnabled = true;
            this.ddlProveedor.ItemHeight = 23;
            this.ddlProveedor.Location = new System.Drawing.Point(693, 53);
            this.ddlProveedor.Name = "ddlProveedor";
            this.ddlProveedor.Size = new System.Drawing.Size(385, 29);
            this.ddlProveedor.TabIndex = 1;
            this.ddlProveedor.UseSelectable = true;
            // 
            // txtFechaAlta
            // 
            // 
            // 
            // 
            this.txtFechaAlta.CustomButton.Image = null;
            this.txtFechaAlta.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtFechaAlta.CustomButton.Name = "";
            this.txtFechaAlta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFechaAlta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFechaAlta.CustomButton.TabIndex = 1;
            this.txtFechaAlta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFechaAlta.CustomButton.UseSelectable = true;
            this.txtFechaAlta.CustomButton.Visible = false;
            this.txtFechaAlta.Enabled = false;
            this.txtFechaAlta.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFechaAlta.Lines = new string[0];
            this.txtFechaAlta.Location = new System.Drawing.Point(923, 22);
            this.txtFechaAlta.MaxLength = 32767;
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.PasswordChar = '\0';
            this.txtFechaAlta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFechaAlta.SelectedText = "";
            this.txtFechaAlta.SelectionLength = 0;
            this.txtFechaAlta.SelectionStart = 0;
            this.txtFechaAlta.ShortcutsEnabled = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(155, 23);
            this.txtFechaAlta.TabIndex = 2;
            this.txtFechaAlta.UseSelectable = true;
            this.txtFechaAlta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFechaAlta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(847, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Fecha Alta";
            // 
            // txtNombreEntrada
            // 
            this.txtNombreEntrada.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombreEntrada.CustomButton.Image = null;
            this.txtNombreEntrada.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtNombreEntrada.CustomButton.Name = "";
            this.txtNombreEntrada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreEntrada.CustomButton.TabIndex = 1;
            this.txtNombreEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreEntrada.CustomButton.UseSelectable = true;
            this.txtNombreEntrada.CustomButton.Visible = false;
            this.txtNombreEntrada.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombreEntrada.Lines = new string[0];
            this.txtNombreEntrada.Location = new System.Drawing.Point(695, 88);
            this.txtNombreEntrada.MaxLength = 32767;
            this.txtNombreEntrada.Name = "txtNombreEntrada";
            this.txtNombreEntrada.PasswordChar = '\0';
            this.txtNombreEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreEntrada.SelectedText = "";
            this.txtNombreEntrada.SelectionLength = 0;
            this.txtNombreEntrada.SelectionStart = 0;
            this.txtNombreEntrada.ShortcutsEnabled = true;
            this.txtNombreEntrada.Size = new System.Drawing.Size(383, 23);
            this.txtNombreEntrada.TabIndex = 2;
            this.txtNombreEntrada.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreEntrada.UseSelectable = true;
            this.txtNombreEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdEntrada
            // 
            // 
            // 
            // 
            this.txtIdEntrada.CustomButton.Image = null;
            this.txtIdEntrada.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtIdEntrada.CustomButton.Name = "";
            this.txtIdEntrada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdEntrada.CustomButton.TabIndex = 1;
            this.txtIdEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdEntrada.CustomButton.UseSelectable = true;
            this.txtIdEntrada.CustomButton.Visible = false;
            this.txtIdEntrada.Enabled = false;
            this.txtIdEntrada.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdEntrada.Lines = new string[0];
            this.txtIdEntrada.Location = new System.Drawing.Point(695, 22);
            this.txtIdEntrada.MaxLength = 32767;
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.PasswordChar = '\0';
            this.txtIdEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdEntrada.SelectedText = "";
            this.txtIdEntrada.SelectionLength = 0;
            this.txtIdEntrada.SelectionStart = 0;
            this.txtIdEntrada.ShortcutsEnabled = true;
            this.txtIdEntrada.Size = new System.Drawing.Size(136, 23);
            this.txtIdEntrada.TabIndex = 1;
            this.txtIdEntrada.UseSelectable = true;
            this.txtIdEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(599, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Quien Entrega";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(668, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(927, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 29);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblError
            // 
            this.lblError.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 38);
            this.panel2.TabIndex = 1;
            // 
            // entradasspBindingSource
            // 
            this.entradasspBindingSource.DataMember = "Entradas_sp";
            this.entradasspBindingSource.DataSource = this.control;
            // 
            // entradas_spTableAdapter
            // 
            this.entradas_spTableAdapter.ClearBeforeFill = true;
            // 
            // entradasPartidas_spTableAdapter
            // 
            this.entradasPartidas_spTableAdapter.ClearBeforeFill = true;
            // 
            // salidasPartidas_spTableAdapter
            // 
            this.salidasPartidas_spTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(683, 340);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 13);
            this.lblIdProducto.TabIndex = 41;
            // 
            // idPartida
            // 
            this.idPartida.DataPropertyName = "idPartida";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.idPartida.DefaultCellStyle = dataGridViewCellStyle2;
            this.idPartida.FillWeight = 20F;
            this.idPartida.HeaderText = "#";
            this.idPartida.Name = "idPartida";
            this.idPartida.ReadOnly = true;
            this.idPartida.Width = 20;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cantidadDataGridViewTextBoxColumn.FillWeight = 75F;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 75;
            // 
            // pUnitarioDataGridViewTextBoxColumn
            // 
            this.pUnitarioDataGridViewTextBoxColumn.DataPropertyName = "pUnitario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.pUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pUnitarioDataGridViewTextBoxColumn.FillWeight = 75F;
            this.pUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio Unit.";
            this.pUnitarioDataGridViewTextBoxColumn.Name = "pUnitarioDataGridViewTextBoxColumn";
            this.pUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.pUnitarioDataGridViewTextBoxColumn.Width = 75;
            // 
            // pTotalDataGridViewTextBoxColumn
            // 
            this.pTotalDataGridViewTextBoxColumn.DataPropertyName = "pTotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.pTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.pTotalDataGridViewTextBoxColumn.FillWeight = 125F;
            this.pTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            this.pTotalDataGridViewTextBoxColumn.Name = "pTotalDataGridViewTextBoxColumn";
            this.pTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.pTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "X";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // EntradaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EntradaAlta";
            this.Text = "Entrada Alta";
            this.Load += new System.EventHandler(this.EntradaAlta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasPartidasspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entradasspBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtFechaAlta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNombreEntrada;
        private MetroFramework.Controls.MetroTextBox txtIdEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtFolio;
        private System.Windows.Forms.ErrorProvider lblError;
        private MetroFramework.Controls.MetroTextBox txtSubTotal;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox ddlProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid gvData;
        private System.Windows.Forms.BindingSource entradasPartidasspBindingSource;
        private DB.DataSets.Control control;
        private System.Windows.Forms.BindingSource entradasspBindingSource;
        private DB.DataSets.ControlTableAdapters.Entradas_spTableAdapter entradas_spTableAdapter;
        private DB.DataSets.ControlTableAdapters.EntradasPartidas_spTableAdapter entradasPartidas_spTableAdapter;
        private DB.DataSets.ControlTableAdapters.SalidasPartidas_spTableAdapter salidasPartidas_spTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkAutomatico;
        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtPrecioUnit;
        private MetroFramework.Controls.MetroLabel lblGrupo;
        private MetroFramework.Controls.MetroLabel lblPrecioUnit;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
    }
}
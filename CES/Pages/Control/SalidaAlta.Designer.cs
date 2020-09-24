namespace CES.Pages.Control
{
    partial class SalidaAlta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdProducto = new System.Windows.Forms.Label();
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
            this.salidasPartidasspBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.control = new CES.DB.DataSets.Control();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtFolio = new MetroFramework.Controls.MetroTextBox();
            this.ddlIdSolicita = new MetroFramework.Controls.MetroComboBox();
            this.txtFechaAlta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtOtroReceptor = new MetroFramework.Controls.MetroTextBox();
            this.txtIdSalida = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalidasspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalidasPartidasspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salidasPartidas_spTableAdapter1 = new CES.DB.DataSets.ControlTableAdapters.SalidasPartidas_spTableAdapter();
            this.idPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasPartidasspBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasPartidasspBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdProducto);
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
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.ddlIdSolicita);
            this.panel1.Controls.Add(this.txtFechaAlta);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtOtroReceptor);
            this.panel1.Controls.Add(this.txtIdSalida);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 469);
            this.panel1.TabIndex = 0;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(683, 340);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 13);
            this.lblIdProducto.TabIndex = 41;
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
            this.btnAdd.Location = new System.Drawing.Point(961, 213);
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
            this.chkAutomatico.Size = new System.Drawing.Size(120, 15);
            this.chkAutomatico.TabIndex = 5;
            this.chkAutomatico.Text = "Capturar Cantidad";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPartida,
            this.codeDataGridViewTextBoxColumn,
            this.nombre,
            this.cantidadDataGridViewTextBoxColumn,
            this.Delete});
            this.gvData.DataSource = this.salidasPartidasspBindingSource1;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvData.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvData.EnableHeadersVisualStyles = false;
            this.gvData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvData.Location = new System.Drawing.Point(4, 4);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(510, 419);
            this.gvData.TabIndex = 27;
            this.gvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellClick);
            // 
            // salidasPartidasspBindingSource1
            // 
            this.salidasPartidasspBindingSource1.DataMember = "SalidasPartidas_sp";
            this.salidasPartidasspBindingSource1.DataSource = this.control;
            // 
            // control
            // 
            this.control.DataSetName = "Control";
            this.control.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(612, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "U. Receptor";
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
            // ddlIdSolicita
            // 
            this.ddlIdSolicita.FormattingEnabled = true;
            this.ddlIdSolicita.ItemHeight = 23;
            this.ddlIdSolicita.Location = new System.Drawing.Point(693, 53);
            this.ddlIdSolicita.Name = "ddlIdSolicita";
            this.ddlIdSolicita.Size = new System.Drawing.Size(385, 29);
            this.ddlIdSolicita.TabIndex = 1;
            this.ddlIdSolicita.UseSelectable = true;
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
            // txtOtroReceptor
            // 
            this.txtOtroReceptor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOtroReceptor.CustomButton.Image = null;
            this.txtOtroReceptor.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtOtroReceptor.CustomButton.Name = "";
            this.txtOtroReceptor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOtroReceptor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOtroReceptor.CustomButton.TabIndex = 1;
            this.txtOtroReceptor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOtroReceptor.CustomButton.UseSelectable = true;
            this.txtOtroReceptor.CustomButton.Visible = false;
            this.txtOtroReceptor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOtroReceptor.Lines = new string[0];
            this.txtOtroReceptor.Location = new System.Drawing.Point(695, 88);
            this.txtOtroReceptor.MaxLength = 32767;
            this.txtOtroReceptor.Name = "txtOtroReceptor";
            this.txtOtroReceptor.PasswordChar = '\0';
            this.txtOtroReceptor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOtroReceptor.SelectedText = "";
            this.txtOtroReceptor.SelectionLength = 0;
            this.txtOtroReceptor.SelectionStart = 0;
            this.txtOtroReceptor.ShortcutsEnabled = true;
            this.txtOtroReceptor.Size = new System.Drawing.Size(383, 23);
            this.txtOtroReceptor.TabIndex = 2;
            this.txtOtroReceptor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOtroReceptor.UseSelectable = true;
            this.txtOtroReceptor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOtroReceptor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdSalida
            // 
            // 
            // 
            // 
            this.txtIdSalida.CustomButton.Image = null;
            this.txtIdSalida.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtIdSalida.CustomButton.Name = "";
            this.txtIdSalida.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdSalida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdSalida.CustomButton.TabIndex = 1;
            this.txtIdSalida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdSalida.CustomButton.UseSelectable = true;
            this.txtIdSalida.CustomButton.Visible = false;
            this.txtIdSalida.Enabled = false;
            this.txtIdSalida.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdSalida.Lines = new string[0];
            this.txtIdSalida.Location = new System.Drawing.Point(695, 22);
            this.txtIdSalida.MaxLength = 32767;
            this.txtIdSalida.Name = "txtIdSalida";
            this.txtIdSalida.PasswordChar = '\0';
            this.txtIdSalida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdSalida.SelectedText = "";
            this.txtIdSalida.SelectionLength = 0;
            this.txtIdSalida.SelectionStart = 0;
            this.txtIdSalida.ShortcutsEnabled = true;
            this.txtIdSalida.Size = new System.Drawing.Size(136, 23);
            this.txtIdSalida.TabIndex = 1;
            this.txtIdSalida.UseSelectable = true;
            this.txtIdSalida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdSalida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(647, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Otro";
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
            // SalidasspBindingSource
            // 
            this.SalidasspBindingSource.DataMember = "Salidas_sp";
            this.SalidasspBindingSource.DataSource = this.control;
            // 
            // SalidasPartidasspBindingSource
            // 
            this.SalidasPartidasspBindingSource.DataMember = "SalidasPartidas_sp";
            this.SalidasPartidasspBindingSource.DataSource = this.control;
            // 
            // salidasPartidas_spTableAdapter1
            // 
            this.salidasPartidas_spTableAdapter1.ClearBeforeFill = true;
            // 
            // idPartida
            // 
            this.idPartida.DataPropertyName = "idPartida";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idPartida.DefaultCellStyle = dataGridViewCellStyle8;
            this.idPartida.FillWeight = 50F;
            this.idPartida.HeaderText = "#";
            this.idPartida.Name = "idPartida";
            this.idPartida.ReadOnly = true;
            this.idPartida.Width = 50;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 150F;
            this.nombre.HeaderText = "Producto";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.cantidadDataGridViewTextBoxColumn.FillWeight = 75F;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 75;
            // 
            // Delete
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = "X";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle10;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(388, 31);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(103, 23);
            this.btnExportar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // SalidaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 549);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SalidaAlta";
            this.Text = "Salida Alta";
            this.Load += new System.EventHandler(this.SalidaAlta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasPartidasspBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalidasspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasPartidasspBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtFechaAlta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtOtroReceptor;
        private MetroFramework.Controls.MetroTextBox txtIdSalida;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtFolio;
        private System.Windows.Forms.ErrorProvider lblError;
        private MetroFramework.Controls.MetroComboBox ddlIdSolicita;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid gvData;
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
        private MetroFramework.Controls.MetroLabel lblGrupo;
        private MetroFramework.Controls.MetroLabel lblPrecioUnit;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource SalidasspBindingSource;
        private System.Windows.Forms.BindingSource salidasPartidasspBindingSource1;
        private DB.DataSets.Control control;
        private System.Windows.Forms.BindingSource SalidasPartidasspBindingSource;
        private DB.DataSets.ControlTableAdapters.SalidasPartidas_spTableAdapter salidasPartidas_spTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private MetroFramework.Controls.MetroButton btnExportar;
    }
}
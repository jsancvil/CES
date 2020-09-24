namespace CES.Pages.Catalogos
{
    partial class ProveedorAlta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtContacto = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFechaAlta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreProveedor = new MetroFramework.Controls.MetroTextBox();
            this.txtIdProveedor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.txtRFC = new MetroFramework.Controls.MetroTextBox();
            this.lblRFC = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRFC);
            this.panel1.Controls.Add(this.txtRFC);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.txtContacto);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtFechaAlta);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.txtIdProveedor);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 281);
            this.panel1.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 115);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 19);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Contacto";
            // 
            // txtContacto
            // 
            // 
            // 
            // 
            this.txtContacto.CustomButton.Image = null;
            this.txtContacto.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtContacto.CustomButton.Name = "";
            this.txtContacto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContacto.CustomButton.TabIndex = 1;
            this.txtContacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContacto.CustomButton.UseSelectable = true;
            this.txtContacto.CustomButton.Visible = false;
            this.txtContacto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtContacto.Lines = new string[0];
            this.txtContacto.Location = new System.Drawing.Point(99, 112);
            this.txtContacto.MaxLength = 32767;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.PasswordChar = '\0';
            this.txtContacto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContacto.SelectedText = "";
            this.txtContacto.SelectionLength = 0;
            this.txtContacto.SelectionStart = 0;
            this.txtContacto.ShortcutsEnabled = true;
            this.txtContacto.Size = new System.Drawing.Size(383, 23);
            this.txtContacto.TabIndex = 5;
            this.txtContacto.UseSelectable = true;
            this.txtContacto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContacto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(173, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 44);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.txtFechaAlta.Location = new System.Drawing.Point(327, 15);
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
            this.metroLabel4.Location = new System.Drawing.Point(251, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Fecha Alta";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Teléfono";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombreProveedor.CustomButton.Image = null;
            this.txtNombreProveedor.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtNombreProveedor.CustomButton.Name = "";
            this.txtNombreProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProveedor.CustomButton.TabIndex = 1;
            this.txtNombreProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProveedor.CustomButton.UseSelectable = true;
            this.txtNombreProveedor.CustomButton.Visible = false;
            this.txtNombreProveedor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombreProveedor.Lines = new string[0];
            this.txtNombreProveedor.Location = new System.Drawing.Point(99, 47);
            this.txtNombreProveedor.MaxLength = 32767;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.PasswordChar = '\0';
            this.txtNombreProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProveedor.SelectedText = "";
            this.txtNombreProveedor.SelectionLength = 0;
            this.txtNombreProveedor.SelectionStart = 0;
            this.txtNombreProveedor.ShortcutsEnabled = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(383, 23);
            this.txtNombreProveedor.TabIndex = 3;
            this.txtNombreProveedor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProveedor.UseSelectable = true;
            this.txtNombreProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdProveedor
            // 
            // 
            // 
            // 
            this.txtIdProveedor.CustomButton.Image = null;
            this.txtIdProveedor.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtIdProveedor.CustomButton.Name = "";
            this.txtIdProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdProveedor.CustomButton.TabIndex = 1;
            this.txtIdProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdProveedor.CustomButton.UseSelectable = true;
            this.txtIdProveedor.CustomButton.Visible = false;
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdProveedor.Lines = new string[0];
            this.txtIdProveedor.Location = new System.Drawing.Point(99, 15);
            this.txtIdProveedor.MaxLength = 32767;
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.PasswordChar = '\0';
            this.txtIdProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdProveedor.SelectedText = "";
            this.txtIdProveedor.SelectionLength = 0;
            this.txtIdProveedor.SelectionStart = 0;
            this.txtIdProveedor.ShortcutsEnabled = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(136, 23);
            this.txtIdProveedor.TabIndex = 1;
            this.txtIdProveedor.UseSelectable = true;
            this.txtIdProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Empresa";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(72, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            // 
            // lblError
            // 
            this.lblError.ContainerControl = this;
            // 
            // txtTelefono
            // 
            // 
            // 
            // 
            this.txtTelefono.CustomButton.Image = null;
            this.txtTelefono.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtTelefono.CustomButton.Name = "";
            this.txtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefono.CustomButton.TabIndex = 1;
            this.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefono.CustomButton.UseSelectable = true;
            this.txtTelefono.CustomButton.Visible = false;
            this.txtTelefono.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(99, 145);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(383, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(28, 180);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(65, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Correo E.";
            // 
            // txtCorreo
            // 
            // 
            // 
            // 
            this.txtCorreo.CustomButton.Image = null;
            this.txtCorreo.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtCorreo.CustomButton.Name = "";
            this.txtCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreo.CustomButton.TabIndex = 1;
            this.txtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreo.CustomButton.UseSelectable = true;
            this.txtCorreo.CustomButton.Visible = false;
            this.txtCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCorreo.Lines = new string[0];
            this.txtCorreo.Location = new System.Drawing.Point(99, 178);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(383, 23);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.UseSelectable = true;
            this.txtCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRFC
            // 
            // 
            // 
            // 
            this.txtRFC.CustomButton.Image = null;
            this.txtRFC.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtRFC.CustomButton.Name = "";
            this.txtRFC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRFC.CustomButton.TabIndex = 1;
            this.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRFC.CustomButton.UseSelectable = true;
            this.txtRFC.CustomButton.Visible = false;
            this.txtRFC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRFC.Lines = new string[0];
            this.txtRFC.Location = new System.Drawing.Point(98, 79);
            this.txtRFC.MaxLength = 32767;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PasswordChar = '\0';
            this.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRFC.SelectedText = "";
            this.txtRFC.SelectionLength = 0;
            this.txtRFC.SelectionStart = 0;
            this.txtRFC.ShortcutsEnabled = true;
            this.txtRFC.Size = new System.Drawing.Size(383, 23);
            this.txtRFC.TabIndex = 4;
            this.txtRFC.UseSelectable = true;
            this.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRFC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(59, 80);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(33, 19);
            this.lblRFC.TabIndex = 23;
            this.lblRFC.Text = "RFC";
            // 
            // ProveedorAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 361);
            this.Controls.Add(this.panel1);
            this.Name = "ProveedorAlta";
            this.Text = "Proveedor Alta";
            this.Load += new System.EventHandler(this.ProveedorAlta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtFechaAlta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNombreProveedor;
        private MetroFramework.Controls.MetroTextBox txtIdProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtContacto;
        private System.Windows.Forms.ErrorProvider lblError;
        private MetroFramework.Controls.MetroLabel lblRFC;
        private MetroFramework.Controls.MetroTextBox txtRFC;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
    }
}
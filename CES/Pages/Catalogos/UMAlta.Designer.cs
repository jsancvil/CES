namespace CES.Pages.Catalogos
{
    partial class UMAlta
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFechaAlta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUM = new MetroFramework.Controls.MetroTextBox();
            this.txtIdUM = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblError = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreUM = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNombreUM);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtFechaAlta);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtUM);
            this.panel1.Controls.Add(this.txtIdUM);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 208);
            this.panel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(171, 115);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 44);
            this.btnGuardar.TabIndex = 5;
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
            // txtUM
            // 
            this.txtUM.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUM.CustomButton.Image = null;
            this.txtUM.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtUM.CustomButton.Name = "";
            this.txtUM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUM.CustomButton.TabIndex = 1;
            this.txtUM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUM.CustomButton.UseSelectable = true;
            this.txtUM.CustomButton.Visible = false;
            this.txtUM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUM.Lines = new string[0];
            this.txtUM.Location = new System.Drawing.Point(100, 49);
            this.txtUM.MaxLength = 32767;
            this.txtUM.Name = "txtUM";
            this.txtUM.PasswordChar = '\0';
            this.txtUM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUM.SelectedText = "";
            this.txtUM.SelectionLength = 0;
            this.txtUM.SelectionStart = 0;
            this.txtUM.ShortcutsEnabled = true;
            this.txtUM.Size = new System.Drawing.Size(135, 23);
            this.txtUM.TabIndex = 3;
            this.txtUM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUM.UseSelectable = true;
            this.txtUM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdUM
            // 
            // 
            // 
            // 
            this.txtIdUM.CustomButton.Image = null;
            this.txtIdUM.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtIdUM.CustomButton.Name = "";
            this.txtIdUM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdUM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdUM.CustomButton.TabIndex = 1;
            this.txtIdUM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdUM.CustomButton.UseSelectable = true;
            this.txtIdUM.CustomButton.Visible = false;
            this.txtIdUM.Enabled = false;
            this.txtIdUM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdUM.Lines = new string[0];
            this.txtIdUM.Location = new System.Drawing.Point(99, 15);
            this.txtIdUM.MaxLength = 32767;
            this.txtIdUM.Name = "txtIdUM";
            this.txtIdUM.PasswordChar = '\0';
            this.txtIdUM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdUM.SelectedText = "";
            this.txtIdUM.SelectionLength = 0;
            this.txtIdUM.SelectionStart = 0;
            this.txtIdUM.ShortcutsEnabled = true;
            this.txtIdUM.Size = new System.Drawing.Size(136, 23);
            this.txtIdUM.TabIndex = 1;
            this.txtIdUM.UseSelectable = true;
            this.txtIdUM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdUM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "UM";
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(34, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Nombre";
            // 
            // txtNombreUM
            // 
            this.txtNombreUM.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombreUM.CustomButton.Image = null;
            this.txtNombreUM.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtNombreUM.CustomButton.Name = "";
            this.txtNombreUM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreUM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreUM.CustomButton.TabIndex = 1;
            this.txtNombreUM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreUM.CustomButton.UseSelectable = true;
            this.txtNombreUM.CustomButton.Visible = false;
            this.txtNombreUM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombreUM.Lines = new string[0];
            this.txtNombreUM.Location = new System.Drawing.Point(99, 82);
            this.txtNombreUM.MaxLength = 32767;
            this.txtNombreUM.Name = "txtNombreUM";
            this.txtNombreUM.PasswordChar = '\0';
            this.txtNombreUM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreUM.SelectedText = "";
            this.txtNombreUM.SelectionLength = 0;
            this.txtNombreUM.SelectionStart = 0;
            this.txtNombreUM.ShortcutsEnabled = true;
            this.txtNombreUM.Size = new System.Drawing.Size(383, 23);
            this.txtNombreUM.TabIndex = 4;
            this.txtNombreUM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreUM.UseSelectable = true;
            this.txtNombreUM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreUM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UMAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 288);
            this.Controls.Add(this.panel1);
            this.Name = "UMAlta";
            this.Text = "UM Alta";
            this.Load += new System.EventHandler(this.UMAlta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtFechaAlta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUM;
        private MetroFramework.Controls.MetroTextBox txtIdUM;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider lblError;
        private MetroFramework.Controls.MetroTextBox txtNombreUM;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
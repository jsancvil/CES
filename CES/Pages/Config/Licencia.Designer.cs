namespace CES.Pages.Config
{
    partial class Licencia
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
            this.txtKey = new MetroFramework.Controls.MetroTextBox();
            this.btnActivar = new MetroFramework.Controls.MetroButton();
            this.lblEstatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            // 
            // 
            // 
            this.txtKey.CustomButton.Image = null;
            this.txtKey.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.txtKey.CustomButton.Name = "";
            this.txtKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKey.CustomButton.TabIndex = 1;
            this.txtKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKey.CustomButton.UseSelectable = true;
            this.txtKey.CustomButton.Visible = false;
            this.txtKey.Lines = new string[0];
            this.txtKey.Location = new System.Drawing.Point(24, 73);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKey.SelectedText = "";
            this.txtKey.SelectionLength = 0;
            this.txtKey.SelectionStart = 0;
            this.txtKey.ShortcutsEnabled = true;
            this.txtKey.Size = new System.Drawing.Size(354, 23);
            this.txtKey.TabIndex = 0;
            this.txtKey.UseSelectable = true;
            this.txtKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(384, 73);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 1;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseSelectable = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEstatus.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEstatus.Location = new System.Drawing.Point(111, 140);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 19);
            this.lblEstatus.TabIndex = 2;
            this.lblEstatus.Text = "------";
            // 
            // Licencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 311);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.txtKey);
            this.Name = "Licencia";
            this.Text = "Licencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtKey;
        private MetroFramework.Controls.MetroButton btnActivar;
        private MetroFramework.Controls.MetroLabel lblEstatus;
    }
}
namespace CES.Pages
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlEntradaN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlEntradaL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlSalidaN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlSalidaL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosProductosN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosProductosL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosGruposN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosGruposL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosUm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosUmN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosUmL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosProveedoresN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogosProveedoresL = new System.Windows.Forms.ToolStripMenuItem();
            this.menucConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menucConfigUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menucConfigN = new System.Windows.Forms.ToolStripMenuItem();
            this.menucConfigUsuarioL = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configLicencia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControl,
            this.menuCatalogos,
            this.menucConfig,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuControl
            // 
            this.menuControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControlEntrada,
            this.menuControlSalida,
            this.menuControlInventario,
            this.menuControlBitacora});
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(59, 20);
            this.menuControl.Text = "Control";
            // 
            // menuControlEntrada
            // 
            this.menuControlEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControlEntradaN,
            this.menuControlEntradaL});
            this.menuControlEntrada.Name = "menuControlEntrada";
            this.menuControlEntrada.Size = new System.Drawing.Size(152, 22);
            this.menuControlEntrada.Text = "Entrada";
            // 
            // menuControlEntradaN
            // 
            this.menuControlEntradaN.Name = "menuControlEntradaN";
            this.menuControlEntradaN.Size = new System.Drawing.Size(152, 22);
            this.menuControlEntradaN.Text = "Nueva";
            this.menuControlEntradaN.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // menuControlEntradaL
            // 
            this.menuControlEntradaL.Name = "menuControlEntradaL";
            this.menuControlEntradaL.Size = new System.Drawing.Size(152, 22);
            this.menuControlEntradaL.Text = "Lista";
            this.menuControlEntradaL.Click += new System.EventHandler(this.listaToolStripMenuItem5_Click);
            // 
            // menuControlSalida
            // 
            this.menuControlSalida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControlSalidaN,
            this.menuControlSalidaL});
            this.menuControlSalida.Name = "menuControlSalida";
            this.menuControlSalida.Size = new System.Drawing.Size(152, 22);
            this.menuControlSalida.Text = "Salida";
            // 
            // menuControlSalidaN
            // 
            this.menuControlSalidaN.Name = "menuControlSalidaN";
            this.menuControlSalidaN.Size = new System.Drawing.Size(152, 22);
            this.menuControlSalidaN.Text = "Nueva";
            // 
            // menuControlSalidaL
            // 
            this.menuControlSalidaL.Name = "menuControlSalidaL";
            this.menuControlSalidaL.Size = new System.Drawing.Size(152, 22);
            this.menuControlSalidaL.Text = "Lista";
            // 
            // menuControlInventario
            // 
            this.menuControlInventario.Name = "menuControlInventario";
            this.menuControlInventario.Size = new System.Drawing.Size(152, 22);
            this.menuControlInventario.Text = "Inventario";
            this.menuControlInventario.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // menuControlBitacora
            // 
            this.menuControlBitacora.Name = "menuControlBitacora";
            this.menuControlBitacora.Size = new System.Drawing.Size(152, 22);
            this.menuControlBitacora.Text = "Bitácora";
            this.menuControlBitacora.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // menuCatalogos
            // 
            this.menuCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogosProductos,
            this.menuCatalogosGrupos,
            this.menuCatalogosUm,
            this.menuCatalogosProveedores});
            this.menuCatalogos.Name = "menuCatalogos";
            this.menuCatalogos.Size = new System.Drawing.Size(72, 20);
            this.menuCatalogos.Text = "Catalogos";
            // 
            // menuCatalogosProductos
            // 
            this.menuCatalogosProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogosProductosN,
            this.menuCatalogosProductosL});
            this.menuCatalogosProductos.Name = "menuCatalogosProductos";
            this.menuCatalogosProductos.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosProductos.Text = "Productos";
            // 
            // menuCatalogosProductosN
            // 
            this.menuCatalogosProductosN.Name = "menuCatalogosProductosN";
            this.menuCatalogosProductosN.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosProductosN.Text = "Nuevo";
            this.menuCatalogosProductosN.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // menuCatalogosProductosL
            // 
            this.menuCatalogosProductosL.Name = "menuCatalogosProductosL";
            this.menuCatalogosProductosL.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosProductosL.Text = "Lista";
            this.menuCatalogosProductosL.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // menuCatalogosGrupos
            // 
            this.menuCatalogosGrupos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogosGruposN,
            this.menuCatalogosGruposL});
            this.menuCatalogosGrupos.Name = "menuCatalogosGrupos";
            this.menuCatalogosGrupos.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosGrupos.Text = "Grupos";
            // 
            // menuCatalogosGruposN
            // 
            this.menuCatalogosGruposN.Name = "menuCatalogosGruposN";
            this.menuCatalogosGruposN.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosGruposN.Text = "Nuevo";
            this.menuCatalogosGruposN.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // menuCatalogosGruposL
            // 
            this.menuCatalogosGruposL.Name = "menuCatalogosGruposL";
            this.menuCatalogosGruposL.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosGruposL.Text = "Lista";
            this.menuCatalogosGruposL.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // menuCatalogosUm
            // 
            this.menuCatalogosUm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogosUmN,
            this.menuCatalogosUmL});
            this.menuCatalogosUm.Name = "menuCatalogosUm";
            this.menuCatalogosUm.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosUm.Text = "UM";
            // 
            // menuCatalogosUmN
            // 
            this.menuCatalogosUmN.Name = "menuCatalogosUmN";
            this.menuCatalogosUmN.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosUmN.Text = "Nuevo";
            this.menuCatalogosUmN.Click += new System.EventHandler(this.nuevoToolStripMenuItem2_Click);
            // 
            // menuCatalogosUmL
            // 
            this.menuCatalogosUmL.Name = "menuCatalogosUmL";
            this.menuCatalogosUmL.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosUmL.Text = "Lista";
            this.menuCatalogosUmL.Click += new System.EventHandler(this.listaToolStripMenuItem2_Click);
            // 
            // menuCatalogosProveedores
            // 
            this.menuCatalogosProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogosProveedoresN,
            this.menuCatalogosProveedoresL});
            this.menuCatalogosProveedores.Name = "menuCatalogosProveedores";
            this.menuCatalogosProveedores.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosProveedores.Text = "Proveedores";
            // 
            // menuCatalogosProveedoresN
            // 
            this.menuCatalogosProveedoresN.Name = "menuCatalogosProveedoresN";
            this.menuCatalogosProveedoresN.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosProveedoresN.Text = "Nuevo";
            this.menuCatalogosProveedoresN.Click += new System.EventHandler(this.nuevoToolStripMenuItem3_Click);
            // 
            // menuCatalogosProveedoresL
            // 
            this.menuCatalogosProveedoresL.Name = "menuCatalogosProveedoresL";
            this.menuCatalogosProveedoresL.Size = new System.Drawing.Size(152, 22);
            this.menuCatalogosProveedoresL.Text = "Lista";
            this.menuCatalogosProveedoresL.Click += new System.EventHandler(this.listaToolStripMenuItem3_Click);
            // 
            // menucConfig
            // 
            this.menucConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucConfigUsuarios,
            this.configLicencia});
            this.menucConfig.Name = "menucConfig";
            this.menucConfig.Size = new System.Drawing.Size(95, 20);
            this.menucConfig.Text = "Configuración";
            // 
            // menucConfigUsuarios
            // 
            this.menucConfigUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucConfigN,
            this.menucConfigUsuarioL});
            this.menucConfigUsuarios.Name = "menucConfigUsuarios";
            this.menucConfigUsuarios.Size = new System.Drawing.Size(152, 22);
            this.menucConfigUsuarios.Text = "Usuarios";
            // 
            // menucConfigN
            // 
            this.menucConfigN.Name = "menucConfigN";
            this.menucConfigN.Size = new System.Drawing.Size(152, 22);
            this.menucConfigN.Text = "Nuevo";
            this.menucConfigN.Click += new System.EventHandler(this.nuevoToolStripMenuItem4_Click);
            // 
            // menucConfigUsuarioL
            // 
            this.menucConfigUsuarioL.Name = "menucConfigUsuarioL";
            this.menucConfigUsuarioL.Size = new System.Drawing.Size(152, 22);
            this.menucConfigUsuarioL.Text = "Lista";
            this.menucConfigUsuarioL.Click += new System.EventHandler(this.listaToolStripMenuItem4_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cerrarCeToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarCeToolStripMenuItem
            // 
            this.cerrarCeToolStripMenuItem.Name = "cerrarCeToolStripMenuItem";
            this.cerrarCeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarCeToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarCeToolStripMenuItem.Click += new System.EventHandler(this.cerrarCeToolStripMenuItem_Click);
            // 
            // configLicencia
            // 
            this.configLicencia.Name = "configLicencia";
            this.configLicencia.Size = new System.Drawing.Size(152, 22);
            this.configLicencia.Text = "Licencia";
            this.configLicencia.Click += new System.EventHandler(this.activarToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 488);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Control de Inventario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuControl;
        private System.Windows.Forms.ToolStripMenuItem menuControlEntrada;
        private System.Windows.Forms.ToolStripMenuItem menuControlSalida;
        private System.Windows.Forms.ToolStripMenuItem menuControlInventario;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosProductos;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosGrupos;
        private System.Windows.Forms.ToolStripMenuItem menucConfig;
        private System.Windows.Forms.ToolStripMenuItem menucConfigUsuarios;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuControlBitacora;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosProductosL;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosProductosN;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosGruposN;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosGruposL;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosUm;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosUmN;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosUmL;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosProveedoresN;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogosProveedoresL;
        private System.Windows.Forms.ToolStripMenuItem menucConfigN;
        private System.Windows.Forms.ToolStripMenuItem menucConfigUsuarioL;
        private System.Windows.Forms.ToolStripMenuItem menuControlEntradaN;
        private System.Windows.Forms.ToolStripMenuItem menuControlEntradaL;
        private System.Windows.Forms.ToolStripMenuItem menuControlSalidaN;
        private System.Windows.Forms.ToolStripMenuItem menuControlSalidaL;
        private System.Windows.Forms.ToolStripMenuItem configLicencia;
    }
}
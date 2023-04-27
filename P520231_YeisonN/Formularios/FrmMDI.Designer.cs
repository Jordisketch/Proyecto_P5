namespace P520231_YeisonN.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpresionDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.MnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.Gray;
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuReport,
            this.MnuExit,
            this.MnuAcercade});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(580, 29);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoriasDeProductosToolStripMenuItem,
            this.rolesDeUsuarioToolStripMenuItem,
            this.tipoDeProveedorToolStripMenuItem,
            this.tipoDeCompraToolStripMenuItem,
            this.toolStripSeparator2});
            this.MnuGestiones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuGestiones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(108, 25);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores ";
            this.gestionDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProveedoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(266, 6);
            // 
            // categoriasDeProductosToolStripMenuItem
            // 
            this.categoriasDeProductosToolStripMenuItem.Name = "categoriasDeProductosToolStripMenuItem";
            this.categoriasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.categoriasDeProductosToolStripMenuItem.Text = "Categorias de Productos ";
            // 
            // rolesDeUsuarioToolStripMenuItem
            // 
            this.rolesDeUsuarioToolStripMenuItem.Name = "rolesDeUsuarioToolStripMenuItem";
            this.rolesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.rolesDeUsuarioToolStripMenuItem.Text = "Roles de Usuario ";
            // 
            // tipoDeProveedorToolStripMenuItem
            // 
            this.tipoDeProveedorToolStripMenuItem.Name = "tipoDeProveedorToolStripMenuItem";
            this.tipoDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.tipoDeProveedorToolStripMenuItem.Text = "Tipo de Proveedor ";
            // 
            // tipoDeCompraToolStripMenuItem
            // 
            this.tipoDeCompraToolStripMenuItem.Name = "tipoDeCompraToolStripMenuItem";
            this.tipoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.tipoDeCompraToolStripMenuItem.Text = "Tipo de Compra ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(266, 6);
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeComprasToolStripMenuItem,
            this.toolStripSeparator4});
            this.MnuProcesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuProcesos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(103, 25);
            this.MnuProcesos.Text = "PROCESOS";
            // 
            // registroDeComprasToolStripMenuItem
            // 
            this.registroDeComprasToolStripMenuItem.Name = "registroDeComprasToolStripMenuItem";
            this.registroDeComprasToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.registroDeComprasToolStripMenuItem.Text = "Registro de Compras ";
            this.registroDeComprasToolStripMenuItem.Click += new System.EventHandler(this.registroDeComprasToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(238, 6);
            // 
            // MnuReport
            // 
            this.MnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasPorFechaToolStripMenuItem,
            this.comprasPorProveedorToolStripMenuItem,
            this.comprasPorProductoToolStripMenuItem,
            this.listadoDeInventarioToolStripMenuItem,
            this.reimpresionDeCompraToolStripMenuItem,
            this.toolStripSeparator3});
            this.MnuReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuReport.Name = "MnuReport";
            this.MnuReport.Size = new System.Drawing.Size(100, 25);
            this.MnuReport.Text = "REPORTES";
            // 
            // comprasPorFechaToolStripMenuItem
            // 
            this.comprasPorFechaToolStripMenuItem.Name = "comprasPorFechaToolStripMenuItem";
            this.comprasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.comprasPorFechaToolStripMenuItem.Text = "Compras por Fecha ";
            // 
            // comprasPorProveedorToolStripMenuItem
            // 
            this.comprasPorProveedorToolStripMenuItem.Name = "comprasPorProveedorToolStripMenuItem";
            this.comprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.comprasPorProveedorToolStripMenuItem.Text = "Compras por proveedor ";
            // 
            // comprasPorProductoToolStripMenuItem
            // 
            this.comprasPorProductoToolStripMenuItem.Name = "comprasPorProductoToolStripMenuItem";
            this.comprasPorProductoToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.comprasPorProductoToolStripMenuItem.Text = "Compras por producto ";
            // 
            // listadoDeInventarioToolStripMenuItem
            // 
            this.listadoDeInventarioToolStripMenuItem.Name = "listadoDeInventarioToolStripMenuItem";
            this.listadoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.listadoDeInventarioToolStripMenuItem.Text = "Listado de inventario";
            // 
            // reimpresionDeCompraToolStripMenuItem
            // 
            this.reimpresionDeCompraToolStripMenuItem.Name = "reimpresionDeCompraToolStripMenuItem";
            this.reimpresionDeCompraToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.reimpresionDeCompraToolStripMenuItem.Text = "Reimpresion de Compra  ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(268, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(65, 25);
            this.MnuExit.Text = "SALIR";
            // 
            // MnuAcercade
            // 
            this.MnuAcercade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuAcercade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuAcercade.Name = "MnuAcercade";
            this.MnuAcercade.Size = new System.Drawing.Size(100, 25);
            this.MnuAcercade.Text = "Acerca de ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "USUARIO:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(55, 17);
            this.LblUsuario.Text = "Usuario";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmMDI";
            this.Text = "SISTEMA DE COMPRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuReport;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercade;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem registroDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimpresionDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
    }
}
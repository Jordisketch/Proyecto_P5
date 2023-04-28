using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231.Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit(); 

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmUsuariosGestion();

                Globales.MiFormGestionUsuarios.Show();
            }

        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

            string InfoUsuario = string.Format("{0}-{1}({2})", Globales.MiUsuarioGlobal.UsuarioNombre, Globales.MiUsuarioGlobal.UsuarioCorreo, 
                Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion);

            LblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolID)
            {
                case 1:
                    break;
                case 2:
                    gestionDeUsuariosToolStripMenuItem.Visible = false;
 
                    break;
            }

        }

        private void gestionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionProveedores.Visible)
            {
                Globales.MiGestionProveedores = new FrmGestionProveedores();

                Globales.MiGestionProveedores.Show();
            }
        }

        private void gestionDeSedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionSedes.Visible)
            {
                Globales.MiGestionSedes = new FrmSede();

                Globales.MiGestionSedes.Show();
            }
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionProducto.Visible)
            {
                FrmProducto frmProducto = new FrmProducto();
                Globales.MiGestionProducto = frmProducto;

                Globales.MiGestionProducto.Show();
            }
        }
    }
}

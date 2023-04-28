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
    public partial class FrmGestionProveedores : Form
    {

        private Logica.Models.Proveedor MiProveedor { get; set; }

        public FrmGestionProveedores()
        {
            InitializeComponent();

            MiProveedor = new Logica.Models.Proveedor();
            
        }

        private void FrmGestionProveedores_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal; 
            
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
           TxtNombreProveedor.Clear();
           TxtCedulaPorveedor.Clear();
           TxtCorreoProveedor.Clear();
           TxtDireccionProveedor.Clear();
           TxtNotas.Clear();
           CbRolProveedor.SelectedIndex = -1;

        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            MiProveedor = new Logica.Models.Proveedor();
            MiProveedor.ProveedorNombre = TxtNombreProveedor.Text.Trim();
            MiProveedor.ProveedorCedula = TxtCedulaPorveedor.Text.Trim();
            MiProveedor.ProveedorEmail = TxtCorreoProveedor.Text.Trim();
            MiProveedor.ProveedorDireccion = TxtDireccionProveedor.Text.Trim();
            MiProveedor.ProveedorNotas = TxtNotas.Text.Trim();
            MiProveedor.MiTipoProveedor.ProveedorTipo = Convert.ToInt32(CbRolProveedor.SelectedValue);
        }
    }
}

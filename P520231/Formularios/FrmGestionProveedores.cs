using Logica.Models;
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
            cargarRoles();
            cargarProveedores();
            
        }

        private void cargarProveedores()
        {

            DgLista.DataSource = MiProveedor.Listar();

        }
        private void cargarRoles()
        {

            Logica.Models.TipoProveedor tipoProveedor = new Logica.Models.TipoProveedor();

            DataTable dt = new DataTable();
            dt = tipoProveedor.listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRolProveedor.ValueMember = "ProveedorTipoID";
                CbRolProveedor.DisplayMember = "ProveedorTipoDescripcion";
                CbRolProveedor.DataSource = dt;
                CbRolProveedor.SelectedIndex = -1;
            }

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

            if (!string.IsNullOrEmpty(MiProveedor.ProveedorNombre) && !string.IsNullOrEmpty(MiProveedor.ProveedorCedula) && !string.IsNullOrEmpty(MiProveedor.ProveedorEmail)
                && !string.IsNullOrEmpty(MiProveedor.ProveedorDireccion)  && !string.IsNullOrEmpty(MiProveedor.ProveedorNotas) && MiProveedor.MiTipoProveedor.ProveedorTipo > 0)
            {
                if (MiProveedor.Agregar())
                {
                    MessageBox.Show("Proveedor guardado correctamente.");
                    cargarProveedores();

                }
                else
                {
                    MessageBox.Show("Error al guardar el proveedor, intente de nuevo.");

                }


            }
            else
            {
                MessageBox.Show("Debe llenar el formulario");
            }
        }
    }
}

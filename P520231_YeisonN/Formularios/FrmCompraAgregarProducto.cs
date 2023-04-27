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

namespace P520231_YeisonN.Formularios
{
    public partial class FrmCompraAgregarProducto : Form
    {
        DataTable ListaProductos { get; set; }

        Producto MiProductolocal { get; set; }


        public FrmCompraAgregarProducto()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            MiProductolocal = new Producto();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DgvLista.SelectedRows[0];
                //se extraen los valores del producto de la fila seleccionada 
                int IdProducto = Convert.ToInt32(row.Cells["CProductoID"].Value);
                string NombreProducto = Convert.ToString(row.Cells["CProductoNombre"].Value);
                string CodigoBarras = Convert.ToString(row.Cells["CProductoCodigoBarras"].Value);
                decimal PrecioProducto = Convert.ToDecimal(row.Cells["CPrecioVentaUnitario"].Value);
                decimal Cantidad = NumUDCantida.Value;

                //se crea una nueva fila del data table del detalle del formulario de registro de compra y 
                //ademas se asigna los valores recolectados 
                DataRow MiFila = Globales.MiFormRegistroCompra.Listaproductos.NewRow();

                MiFila["ProductoID"] = IdProducto;
                MiFila["Cantidad"] = Cantidad;
                MiFila["PrecioVentaUnitario"] = PrecioProducto;
                MiFila["ProductoNombre"] = NombreProducto;
                MiFila["ProductoCodigoBarras"] = CodigoBarras;

                Globales.MiFormRegistroCompra.Listaproductos.Rows.Add(MiFila);

                DialogResult = DialogResult.OK;

            }


           
        }

        private void FrmCompraAgregarProducto_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            ListaProductos = new DataTable();

            ListaProductos = MiProductolocal.ListarEnBusqueda();

            DgvLista.DataSource = ListaProductos;

            DgvLista.ClearSelection();
        }


    }
}

using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_YeisonN.Formularios
{
    public partial class FrmRegistroCompra : Form
    {
        //objeto de compra local 
        public Compra MiCompraLocal { get; set; }  

        public DataTable Listaproductos { get; set; }

        public FrmRegistroCompra()
        {
            InitializeComponent();

            MiCompraLocal = new Compra();
            Listaproductos = new DataTable();
        }

        private void FrmRegistroCompra_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;

            CargarTiposDeCompra();
            LimpiarForm();

        }

        private void CargarTiposDeCompra()
        {
            DataTable dtTiposCompra = new DataTable();

            dtTiposCompra = MiCompraLocal.MiTipoCompre.listar();

            CboxCompraTipo.ValueMember = "id";
            CboxCompraTipo.DisplayMember = "descripcion";

            CboxCompraTipo.DataSource = dtTiposCompra;

            CboxCompraTipo.SelectedIndex = -1;
        }

        private void LimpiarForm()
        {
            TxtProveedorNombre.Clear(); 
            TxtNotas.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";
            CboxCompraTipo.SelectedIndex = -1;

            //se debe cargar un esquema en el datatable del detalle (listarproductos)
            //esto es importante para saber como se llaman los campos, que tipos de datos tienen 
            //y que pueda servir de datasource del DgvLista sin que elimine las columnas hechas en tiempo de disenio

            Listaproductos = MiCompraLocal.CargarEsquemaDetalle();
            DgvLista.DataSource = Listaproductos;
        }

        private void BtnProveedorBuscar_Click(object sender, EventArgs e)
        {
            //se abre un nuevo formulario de busqueda de proveedor, este formulario no es necesario definirlo en los globales (aunque es posible) 

            Form FormBusquedaProveedor = new FrmProveedorBuscar();  


            DialogResult respuesta = FormBusquedaProveedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                //usamos las composiciones a proveedor para extrae ele valor del nombre del proveedor 
                TxtProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;

            }
        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusquedaItem = new FrmCompraAgregarProducto();

            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                DgvLista.DataSource = Listaproductos;

                Totalizar();
            }
        }

        private void Totalizar()
        {
            //se usa para mostrar los totales en la parte inferior del form
            if (Listaproductos.Rows.Count > 0)
            {
                //se recorre la lista de filas del datatable del detalle y se realizan las operaciones 
                //matematicas para sumarizar 
                decimal TotalItems = 0;
                decimal TotalMontos = 0;


            foreach (DataRow row in Listaproductos.Rows)
                {
                    TotalItems += Convert.ToDecimal(row["Cantidad"]);
                    
                    TotalMontos += Convert.ToDecimal(row["PrecioVentaUnitario"]) * Convert.ToDecimal(row["Cantidad"]);
                }

              TxtTotalCantidad.Text = TotalItems.ToString();  
              //este formato sirve para representar un valor monetario
              TxtTotal.Text = string.Format("{0:C2}", TotalMontos); 


            }
        }

        private void BtnCrearCompra_Click(object sender, EventArgs e)
        {
            //primero se validad que se haya seleccionado un proveedor, un tipo de compra 
            //y que haya como minimo una linea en el detalle 

            if (ValidarCompra())
            {
                //los pasos para agregar un encabezado-detalle son: 1. realizar el insert en el encabezado 
                //y recolectar el ID recien creado, teniendo claro que ese ID se geera a nivel de BD.

                //2. con ese ID + el ID del producto tenemos las dos FK para hacer el insert en la tabla de detalle 

                //se agregan los datos de encabezado que hacen falta (de proveedor ya estaba listo)

                MiCompraLocal.MiTipoCompre.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiCompraLocal.CompraNota = TxtNotas.Text.Trim();
                MiCompraLocal.Miusuario.UsuarioID = 1;

                TrasladoDetalleListaVisualAObjetoCompra();

                //a este punto el objeto de compra local esta totalmente armado 

                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra Correctamente Creada", "😀", MessageBoxButtons.OK);

                    LimpiarForm();
                }
            }
        }

        private void TrasladoDetalleListaVisualAObjetoCompra()
        {
            //pasamos los datos del data table que se usa graficamente a la list de la objeto 
            //micompralocal 

            foreach (DataRow fila in Listaproductos.Rows)
            {
                CompraDetalle nuevodetalle = new CompraDetalle();

                nuevodetalle.MiProducto.ProductoID = Convert.ToInt32(fila["ProductoID"]);
                nuevodetalle.Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                nuevodetalle.PrecioUnitario = Convert.ToDecimal(fila["PrecioVentaUnitario"]);

                //una vez tenemos los datos en el nuevo detalle se agrega ese objeto
                //a la lista de detalles de la compra local 

                MiCompraLocal.ListaDetalles.Add(nuevodetalle);
            }
        }


        private bool ValidarCompra()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) && CboxCompraTipo.SelectedIndex >= 0 
                && Listaproductos.Rows.Count > 0)
            {
                R = true; 
            } 
            else
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un proveedor", "❌", MessageBoxButtons.OK);
                    return false;
                }

                if (CboxCompraTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo de compra", "❌", MessageBoxButtons.OK);
                    return false;
                }

                if (Listaproductos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe haber al menos una fila en el detalle", "❌", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;
        }






    }
}

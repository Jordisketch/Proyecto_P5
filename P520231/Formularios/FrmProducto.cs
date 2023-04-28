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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            producto = new Logica.Models.Producto();

            InitializeComponent();
        }
        private Logica.Models.Producto producto { get; set; }

        private void cargarListaCategorias()
        {

            Logica.Models.CategoriaProducto MiCategoria = new Logica.Models.CategoriaProducto();

            DataTable dt = new DataTable();
            dt = MiCategoria.listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                categorias.ValueMember = "CategoriaID";
                categorias.DisplayMember = "CategoriaDescripcion";
                categorias.DataSource = dt;
                categorias.SelectedIndex = -1;
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            producto = new Logica.Models.Producto();
            producto.ProductoNombre = TxtProductoNombre.Text.Trim();
            producto.CantidadStock = TxtProductoCantidad.ToString();
            producto.Micategoria.CategoriaID = Convert.ToInt32(categorias.SelectedValue);

            //paso 1.5

            if (producto.Micategoria.CategoriaID > 0 && !string.IsNullOrEmpty(producto.ProductoNombre) && !string.IsNullOrEmpty(producto.CantidadStock))
            {

                if (producto.Agregar())
                {
                    MessageBox.Show("Producto guardado correctamente.");
                    cargarListaProductos();

                }
                else
                {
                    MessageBox.Show("Error al guardar el prooducto, intente de nuevo.");

                }


            }
            else
            {
                MessageBox.Show("Debe llenar el formulario");
            }



        }
        private void cargarListaProductos()
        {

            dataGridView1.DataSource = producto.Listar();

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cargarListaCategorias();
            cargarListaProductos();
        }

        private void LimpiarFormulario(object sender, EventArgs e)
        {
            TxtProductoNombre.Clear();
            TxtProductoCantidad.Clear();
            categorias.SelectedIndex = -1;
        }
    }
}

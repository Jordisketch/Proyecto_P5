using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string CantidadStock { get; set; }
   

        public bool Agregar()
        {
            bool result = false;
            Conexion miConexion = new Conexion();

            miConexion.ListaDeParametros.Add(new SqlParameter("@ProductoNombre", this.ProductoNombre));
            miConexion.ListaDeParametros.Add(new SqlParameter("@cantidadStock", this.CantidadStock));
            miConexion.ListaDeParametros.Add(new SqlParameter("@CategoriaProductoID", this.Micategoria.CategoriaID));

            int rowsAffected = miConexion.EjecutarInsertUpdateDelete("GuardarProducto");
            if (rowsAffected > 0)
            {
                result = true;
            }

            return result;
        }

        public bool Editar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@productoID", this.ProductoID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("EliminarProducto");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPListarProductos");

            return R;

        }

        public CategoriaProducto Micategoria { get; set; }

        public Producto()
        {
            Micategoria = new CategoriaProducto();  
        }
    }
}

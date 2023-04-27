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
    public class Compra
    {
        //propiedades 
        public int CompraID { get; set; }
        public DateTime CompraFecha { get; set; }
        public int CompraNumero { get; set; }
        public string CompraNota { get; set; }
        public bool Activo { get; set; }

        //composiciones simples 
        public Usuario Miusuario{ get; set; }
        public Proveedor MiProveedor { get; set; }
        public TipoCompre MiTipoCompre { get; set; }

        //composiciones en lista o complejas

        public List<CompraDetalle> ListaDetalles { get; set; }  

        //constructor 
        public Compra()
        {
            Miusuario = new Usuario();
            MiProveedor = new Proveedor();
            MiTipoCompre = new TipoCompre();
            ListaDetalles = new List<CompraDetalle>();
        }


        //funciones 
        public DataTable CargarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPCompraDetalleEsquema", true);

            //como estamos cargandio el esquema tambien viene la indicacion del pk, se debe anular esa opcion 

            R.PrimaryKey = null;

            return R;
        }

        //funcion agregar en una estructura encabezado-detalle 

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            //lista de parametros 

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDProveedor", this.MiProveedor.ProveedorID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDTipoCompra ", this.MiTipoCompre.CompraTipoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDUsuario", this.Miusuario.UsuarioID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.CompraNota));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPCompraAgregar");
            //como la devolucion puede ser cualquier tipo se captura la respuesta en un object y 
            //luego se hace la conversion al tipo correcto, en este caso es un int 

            int IDCreada;

            if (retorno != null)
            {

                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());

                    this.CompraID = IDCreada;   

                    foreach(CompraDetalle item in this.ListaDetalles)
                    {

                        Conexion MiCnnDetalle = new Conexion();
                        //lista de parametros del sp de insert a detalle 

                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDCompra", IDCreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoID));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Precio", item.PrecioUnitario));

                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPCompraDetalleAgregar");
                    }
                    R = true;
                }
                catch (Exception)
                {
                    throw;
                }

            }

            return R;
        }






        }
}

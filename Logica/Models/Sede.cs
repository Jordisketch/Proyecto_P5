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
    public class Sede
    {
        public int id_sede { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }

        public Sede() { }

        public bool Agregar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@nombre", this.nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ubicacion", this.ubicacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.descripcion));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPSedeAgregar");

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
            

            R = MiCnn.EjecutarSELECT("SPSedesListar");


            return R;
        }
    }

}

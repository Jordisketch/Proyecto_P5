using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
        //Se digitan las propiedades de las clases como primer paso
        //Luego de escribir las propiedades simples se digitan 
        //Las propiedades compuestas (en este caso no hay)
        //Por ultmo se escribe las funciones y metodos

      public int UsuarioRolID { get; set; }
      
      public string UsuarioRolDescripcion { get; set; }

      public DataTable Listar()
        {
           DataTable R = new DataTable();
            //aqui va la programacion indicada en el diagrama de secuencias 

            return R;
        }




    }
}

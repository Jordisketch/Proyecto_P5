﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        //propiedad simple
        public int UsuarioID { get; set; }
        public string UsuarioCorreo { get; set; }
        public string UsuarioContrasennia { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioCedula { get; set; }
        public string UsuarioTelefono { get; set; }
        public string UsuarioDireccion { get; set; }
        public bool Activo { get; set; }

        //Propiedades Compuestas
        Usuario_Rol MiRolTipo { get; set; }

        //normalmente cuando tenemos propiedades compuestas con tipos que hemos programado nosotros mismos 
        //debemos instanciar dichas propiedades ya que son objetos. Para esto lo mas recomendable es un constructor.

        //constructor
        public Usuario()
        {
            //al creae una nueva instancia de la clase Usuario, se ejecuta el codigo de este constructor, tambien se crea una nueva 
            //instancia de la clase usuarioo_rol para el objeto MiRolTipo
          MiRolTipo = new Usuario_Rol();    
        }


        //funciones y metodos 
        public bool Agregar()
        {
            //cuando la funcion devuelve un bool se debe de inicializar la variable de retorno en false
            //(tiene negativo el resultado de la funcion)y solo si la operacion en este caso el insert sale
            //correcta se cambia el valor R a true.
            bool R = false;
            //aca va el codigo funcional que invoca a un procedimiento almacenado que contiene el DML Insert
            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasennia)
        {
            Usuario R = new Usuario();

            return R;

        }








    }
}
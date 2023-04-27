using System.Windows.Forms;

namespace P520231_YeisonN
{
    public static class Globales
    {
        //Estas propiedades al pertenecer a una clase de auto instancia 
        //y se puede obtener acceso a ellas en la globalidad de la aplicacion.
        public static Form MiFormPrincipal = new Formularios.FrmMDI();
        
        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        //DEBEMOS TENER COMO OBJETO DE TIPO USUARIO QUE PERMITA ALMACENAR LOS DATOS DEL USUARIO QUE SE HAYA LOGUEADO CORRECTAMENTE
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();

        public static Formularios.FrmGestionProveedores MiGestionProveedores = new Formularios.FrmGestionProveedores();

    }
}

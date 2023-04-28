using System.Windows.Forms;

namespace P520231
{
    public static class Globales
    {

        public static Form MiFormPrincipal = new Formularios.FrmMDI();
        
        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();


        public static Formularios.FrmGestionProveedores MiGestionProveedores = new Formularios.FrmGestionProveedores();

        public static Formularios.FrmSede MiGestionSedes = new Formularios.FrmSede();

        public static Formularios.FrmProducto MiGestionProducto = new Formularios.FrmProducto();

    }
}

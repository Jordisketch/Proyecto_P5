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
    public partial class FrmUsuariosGestion : Form
    {

        //Por orden es mejor crear objetos locales que permitan 
        //la gestion del tema que estamos tratando, usar ojetos individuales 
        //en las funciones puede provocar desorden y complicar la lrctura del 
        //codigo fuente.

        //objeto local para usuario 
        private Logica.Models.Usuario MiUsuarioLocal {  get; set; }

        //lista local de ususarios que se visualizan en datgridview
        private DataTable ListaUsuarios { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre MDI, hacemos que sea una misma aplicacion 
            //no varias ventanas emergentes 

            MdiParent = Globales.MiFormPrincipal;

            cargarListaRoles();
            CargarListaDeUsuarios();    
        }


        private void CargarListaDeUsuarios()
        {
            //resetear la lista de ususarios haciendo re instancia del objeto 
            ListaUsuarios = new DataTable();
            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();
            } else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource = ListaUsuarios;

        }




        private void cargarListaRoles()
        {

            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();  

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0 )
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            }

        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando seleccionemos una fila del datagrid se debe cargar
            //la info de dicho ususario en el ususario local y luego 
            //dibujar esa info en los controles graficos 

            if (DgLista.SelectedRows.Count == 1)
            {
                //TODO:Limpiar formulario
                //de la coleccion de filas seleccionadas (en este caso es
                //solo una) seleccionamos la fila en indice 0, es decir la primera 
                DataGridViewRow MiFila = DgLista.SelectedRows[0];   
                //Lo que necesito es el valos del ID del ususario para realizar
                //la consulta y traer los datos para llenar el objeto de usuario local
                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);
                //para no asumir riesgos se reinstancia el usuario local 
                MiUsuarioLocal = new Logica.Models.Usuario();
                //ahora le agregamos el valor obtenido por la fila al IDdel usuario local 
                MiUsuarioLocal.UsuarioID = IdUsuario;
                //Una vez que tengo el objeto local con el valor del ID puedo ir a 
                //consultar ese usuario por el ID y llenar el resto de atributos 
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();
                //validamos el uso de usuario local tenga datos 
                if (MiUsuarioLocal!=null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //si carga correctamente el usuario local llenamos los controles
                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);
                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;
                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;
                    //combobox 
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;





                }



            }
        }
    }
}

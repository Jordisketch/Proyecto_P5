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
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

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
            ActivarAgregar();

        }


        private void CargarListaDeUsuarios()
        {
            //resetear la lista de ususarios haciendo re instancia del objeto 
            ListaUsuarios = new DataTable();
            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();
            }
            else
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

            if (dt != null && dt.Rows.Count > 0)
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


        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }


        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando seleccionemos una fila del datagrid se debe cargar
            //la info de dicho ususario en el ususario local y luego 
            //dibujar esa info en los controles graficos 

            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
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
                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
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

                    ActivarEditarEliminar();



                }



            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }

        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasenia.Clear();

            CbRolesUsuario.SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();

        }

        private bool ValidarDatosDigitados(bool OmitirPassword = false)
        {
            //evalua que se hayan digitado los campos de texto 
            //en el formulario 
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&

                CbRolesUsuario.SelectedIndex > -1
                )
            {
                if (OmitirPassword)
                {
                    //(EDITAR)si el password se omite, entonces ya paso la evaluacion a este punto, retorna true
                    R = true;
                }
                else
                {
                    //(AGREGAR)en caso en el que haya que evaluar la contrasennia se debe agregar otra condicion logica
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasenia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //en el caso en el que haga falta la contrasenia, se le indica al ususario

                        MessageBox.Show("Debe digitar una contraseña para el ususario", "✘", MessageBoxButtons.OK);
                        TxtUsuarioContrasenia.Focus();
                        return false;

                    }


                }


            }
            else
            {
                //que pasa cuando algo falta 

                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre de ususario", "✘", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el ususario", "✘", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono para el ususario", "✘", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el ususario", "✘", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }



                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el ususario", "✘", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }


            }


            return R;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                //estas variables almacenan el resultado de las consultas 
                //por correo y cedula 
                bool CedulaOk;
                bool EmailOk;

                //paso 1.1 y 1.2 
                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasenia.Text.Trim();
                //composicion del rol
                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //Vamos a realizar las consultas por email y cedula 
                //pasos 1.3 y 1.3.6
                CedulaOk = MiUsuarioLocal.ConsultarPorCedula();

                //pasos 1.4 y 1.4.6
                EmailOk = MiUsuarioLocal.ConsultarPorEmail();

                //paso 1.5 

                if (CedulaOk == false && EmailOk == false)
                {
                    //se puede agregar el usuario ya uqe no existe 

                    //se solicita al usuario confirmacion de si quiere agregar
                    //o no al usuario 

                    string msg = string.Format("¿Esta seguro que desea agregar el usuario {0}?", MiUsuarioLocal.UsuarioNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "❓", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario Guardado Correctamente", "✅", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario No Se Guardado Correctamente", "✘", MessageBoxButtons.OK);
                        }
                    }


                }
                else
                {
                    //Indicar al usuario si falla una consulta 

                    if (CedulaOk)
                    {
                        MessageBox.Show("Ya existe un usuario con la cedula digitada", "❌", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmailOk)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitado", "❌", MessageBoxButtons.OK);
                        return;
                    }
                }


            }


        }

        private void DgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eliminar esto cuando lo pueda ver con el profe 
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados(true))
            {
                //no es necesario capturar el id desde el campo del texto ya que al consultarlo (cuando o seleccionamos el usuario del datagrid), 
                //ya tenemos en el ID, este ID no puede ser modificado, el resto si
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();

                //como el cuador de texto de la contrasenia tiene un caracter en blanco puedo asignar sin problema el valor del cuadro de texto al atibuto
                //en el SP se evalua si tiene o no datos 
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasenia.Text.Trim();
                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //segun el diagrama de casos de uso expandido y la secuenci normal para un CRUD (editar) es habitual consultar por el ID el item 
                //que se va a modificar, para asegurarse que en el lapso de tiempo entre que se seleccione el ususario y se modifiquen los datos en 
                //pantalla aun exista el registro en la base de datos (exuste una posibilidad de que ya no exista debido a que en entornos donde hayan muchos ususarios
                //trabajando en el sistema algun otro este modificando el mismo registro) esto se llama cocurrencia 

                if (MiUsuarioLocal.ConsultarPorID())
                {

                    DialogResult respuesta = MessageBox.Show("¿Esta seguro de modificar el usuario?", "❓", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes )
                    {
                        if (MiUsuarioLocal.Editar())
                        {
                            MessageBox.Show("El usuario fue modificado de manera correcta", "✅", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeUsuarios();

                        }
                    }
                }




            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiUsuarioLocal.UsuarioID > 0 && MiUsuarioLocal.ConsultarPorID())
            {
                //tomando en cuenta que puedo estar viendo los ususarios activos o inactivos este boton podria dervir para activar o desactivar los ususarios 
                //el checkbox de la parte superior del form me sirve oara indemtificar la accion


                if (CboxVerActivos.Checked)
                {
                    //DESACTIVARUSUSARIO
                    DialogResult r = MessageBox.Show("¿Esta seguro de eleminir el ususario?", "❓", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes )
                    {
                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El ususario fue eliminado de manera correcta", "✅", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }
                    }

                }
                else
                {
                    //ACTIVAR USUARIO



                }












            }


        }
    }
}

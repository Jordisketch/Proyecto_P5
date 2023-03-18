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
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre MDI, hacemos que sea una misma aplicacion 
            //no varias ventanas emergentes 

            MdiParent = Globales.MiFormPrincipal;

            cargarListaRoles();


        }

        private void cargarListaRoles()
        {

            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();  

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0 )
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.ValueMember = "Descrip";
                CbRolesUsuario.DataSource = dt;
                CbRolesUsuario.SelectedIndex = -1;
            }

        }














    }
}

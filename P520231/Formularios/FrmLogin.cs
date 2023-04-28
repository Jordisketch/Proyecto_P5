using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            //Cierra la aplicacion 
            Application.Exit(); 



        }

        private void BtnVerContrasenia_MouseDown(object sender, MouseEventArgs e)
        {

            TxtContrasenia.UseSystemPasswordChar = false;

        }

        private void BtnVerContrasenia_MouseUp(object sender, MouseEventArgs e)
        {

            TxtContrasenia.UseSystemPasswordChar = true;


        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //validar que se haya digitado un ususario y contrasennia 

            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtContrasenia.Text.Trim()))
            {
                string usuario = TxtEmail.Text.Trim();
                string contrasennia = TxtContrasenia.Text.Trim();

                //tratar de validar que los datos digitados sean correctos 
                //en caso que la validacion sea correcta, aplicamos los valores al usuario global 
                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                if (Globales.MiUsuarioGlobal.UsuarioID > 0)
                {
                    //SI LA VALIDACION ES CORRECTA EL ID DEBERIA TENER UN VALOR MAYOR A CERO 

                    Globales.MiFormPrincipal.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o Contrasennia Incorrectas", "✘", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtContrasenia.Focus();
                    TxtContrasenia.SelectAll();
                }

            } 
            else
            {
                MessageBox.Show("Faltan datos requeridos!", "✘", MessageBoxButtons.OK);
            }


            

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // al presionar cierta convinacion de teclas el boton de ingreso aparace 

            if (e.Shift & e.Alt & e.KeyCode == Keys.A)
            {
                //si presionamos shift + tab + a
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}

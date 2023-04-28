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
    public partial class FrmSede : Form
    {
        public FrmSede()
        {
            sede = new Logica.Models.Sede();

            InitializeComponent();
        }

        private void FrmSedesGestion_Load(object sender, EventArgs e)
        {
            cargarSedes();
        }

        private Logica.Models.Sede sede { get; set; }

        private DataTable ListaSedes { get; set; }

        private void cargarSedes()
        {

            dataGridView1.DataSource = sede.Listar();

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
                sede = new Logica.Models.Sede();
                sede.descripcion = TxtDescripcionSede.Text.Trim();
                sede.nombre = TxtSedeNombre.Text.Trim();
                sede.ubicacion = TxtUbicacionSede.Text.Trim();

                //paso 1.5

                if (!string.IsNullOrEmpty(sede.descripcion) &&!string.IsNullOrEmpty(sede.nombre) && !string.IsNullOrEmpty(sede.ubicacion))
                {

                if (sede.Agregar())
                {
                    MessageBox.Show("Sede guardada correctamente.");
                    cargarSedes();

                }
                else
                {
                    MessageBox.Show("Error al guardar la sede, intente de nuevo.");

                }


                 }
                else
                {
                    MessageBox.Show("Debe llenar el formulario");
                }
               
        }
        private void Limpiar_Formulario(object sender, EventArgs e)
        {
           TxtDescripcionSede.Clear();
            TxtSedeNombre.Clear();
            TxtUbicacionSede.Clear();
        }

    }
}

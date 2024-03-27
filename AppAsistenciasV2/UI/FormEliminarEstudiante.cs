using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAsistenciasV2
{
    public partial class FormEliminarEstudiante : Form
    {
        GestionDB gestionDB = new GestionDB();
        public FormEliminarEstudiante()
        {
            InitializeComponent();
            LlenarComboBoxNombres();
        }

        private void LlenarComboBoxNombres()
        {
            // Limpiar el ComboBox antes de agregar nombres
            cbNombre.Items.Clear();

            // Obtener la lista de nombres de estudiantes desde la base de datos
            List<string> nombresEstudiantes = gestionDB.ObtenerNombresEstudiantes();

            // Agregar los nombres al ComboBox
            cbNombre.Items.AddRange(nombresEstudiantes.ToArray());
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            // Validar que no hay campos vacíos
            if (string.IsNullOrEmpty(cbNombre.Text) || string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eliminar el estudiante de la base de datos
            gestionDB.EliminarEstudiantePorNombre(cbNombre.Text);

            // Actualizar la lista de nombres en el ComboBox después de eliminar
            LlenarComboBoxNombres();

            // Limpiar los controles o realizar otras acciones después de eliminar
            LimpiarControles();
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarIdentificacionDesdeNombreSeleccionado();
        }

        private void LlenarIdentificacionDesdeNombreSeleccionado()
        {
            // Validar que haya un nombre seleccionado
            if (cbNombre.SelectedIndex >= 0)
            {
                // Obtener la identificación del estudiante según el nombre seleccionado
                string identificacion = gestionDB.ObtenerIdentificacionEstudiante(cbNombre.SelectedItem.ToString());

                // Llenar el campo de identificación
                txtIdentificacion.Text = identificacion;
            }
        }

        private void LimpiarControles()
        {
            cbNombre.SelectedIndex = -1;
            txtIdentificacion.Text = string.Empty;
        }

    }
}

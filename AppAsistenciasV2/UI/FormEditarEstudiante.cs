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
    public partial class FormEditarEstudiante : Form
    {
        GestionDB gestionDB = new GestionDB();
        public FormEditarEstudiante()
        {
            InitializeComponent();
            LlenarComboBoxTipoID();
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

        private void LlenarComboBoxTipoID()
        {
            cbTipoID.Items.Clear();
            cbTipoID.Items.AddRange(new string[] { "cc", "ti" });
        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Obtener los valores de los campos
                string nombre = cbNombre.SelectedItem.ToString();
                string tipoID = cbTipoID.SelectedItem.ToString();
                string identificacion = txtIdentificacion.Text;
                string contrasena = txtContrasena.Text;
                string email = txtEmail.Text;

                // Editar el estudiante en la base de datos
                GestionDB.EditarEstudiante(nombre, tipoID, identificacion, contrasena, email);

                // Limpia los campos después de editar el estudiante
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            // Validar que no hayan campos vacíos
            if (cbNombre.SelectedItem == null || string.IsNullOrEmpty(cbTipoID.Text) ||
                string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que identificación y contraseña sean valores numéricos
            if (!EsNumero(txtIdentificacion.Text) || !EsNumero(txtContrasena.Text))
            {
                MessageBox.Show("Los campos de identificación y contraseña deben contener valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el tipo de identificación sea cc o ti
            if (cbTipoID.Text != "cc" && cbTipoID.Text != "ti")
            {
                MessageBox.Show("El tipo de identificación debe ser 'cc' o 'ti'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que la contraseña sea de 4 dígitos
            if (txtContrasena.Text.Length != 4)
            {
                MessageBox.Show("La contraseña debe tener exactamente 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener y mostrar los demás campos cuando se selecciona un nombre en cbNombre
            if (cbNombre.SelectedItem != null)
            {
                string nombreSeleccionado = cbNombre.SelectedItem.ToString();

                Estudiante estudiante = gestionDB.ObtenerDatosEstudiante(nombreSeleccionado);

                // Mostrar los datos en los campos correspondientes
                cbTipoID.Text = estudiante.TipoID;
                txtIdentificacion.Text = estudiante.Identificacion;
                txtContrasena.Text = estudiante.Contrasena;
                txtEmail.Text = estudiante.Email;
            }
        }

        private bool EsNumero(string texto)
        {
            return int.TryParse(texto, out _);
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            cbNombre.SelectedItem = null;
            cbTipoID.SelectedItem = null;
            txtIdentificacion.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}

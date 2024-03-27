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
    public partial class FormAgregarEstudiante : Form
    {
        public FormAgregarEstudiante()
        {
            InitializeComponent();
            LlenarComboBoxTipoID();
        }

        private void LlenarComboBoxTipoID()
        {
            cbTipoID.Items.Clear();
            cbTipoID.Items.AddRange(new string[] { "cc", "ti" });
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Obtener los valores de los campos
                string nombre = txtNombre.Text;
                string tipoID = cbTipoID.SelectedItem.ToString();
                string identificacion = txtIdentificacion.Text;
                string contrasena = txtContrasena.Text;
                string email = txtEmail.Text;

                // Agregar el estudiante a la base de datos
                GestionDB.AgregarEstudiante(nombre, tipoID, identificacion, contrasena, email);

                // Limpia los campos después de agregar el estudiante
                LimpiarCampos();
            }
        }

        private bool ValidarCampos()
        {
            // Validar que no hayan campos vacíos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cbTipoID.Text) ||
                string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtContrasena.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que no haya valores numéricos en el campo de nombre
            if (ContieneNumeros(txtNombre.Text))
            {
                MessageBox.Show("El campo de nombre no puede contener valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }

        private bool EsNumero(string texto)
        {
            return int.TryParse(texto, out _);
        }

        private void LimpiarCampos()
        {
            // Limpia todos los campos después de agregar el estudiante
            txtNombre.Clear();
            cbTipoID.SelectedIndex = -1;
            txtIdentificacion.Clear();
            txtContrasena.Clear();
            txtEmail.Clear();
        }
    }
}

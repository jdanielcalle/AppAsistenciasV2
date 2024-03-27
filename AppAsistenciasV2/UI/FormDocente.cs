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
    public partial class FormDocente : Form
    {
        GestionDB gestionDB = new GestionDB();
        public FormDocente()
        {
            InitializeComponent();
            txtContrasena.PasswordChar = '•';
        }

        private void swVerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            // Cambia la propiedad UseSystemPasswordChar del TextBox
            txtContrasena.UseSystemPasswordChar = !swVerContrasena.Checked;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validación de valores numéricos en txtIdentificacion y txtContrasena
            if (!EsNumero(txtCedula.Text) || !EsNumero(txtContrasena.Text))
            {
                MessageBox.Show("Solo se permiten valores numéricos en Identificación y Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validación de longitud de contraseña
            if (txtContrasena.Text.Length != 4)
            {
                MessageBox.Show("La contraseña debe tener exactamente 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cedula = txtCedula.Text;
            string pin = txtContrasena.Text;
            if (gestionDB.ValidarCredencialesDocente(cedula, pin))
            {
                // Redirigir al formulario correspondiente para estudiantes
                FormPanelDocente formPanelDocente = new FormPanelDocente();
                formPanelDocente.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Función para validar si una cadena es un número
        private bool EsNumero(string texto)
        {
            return int.TryParse(texto, out _);
        }
    }
}

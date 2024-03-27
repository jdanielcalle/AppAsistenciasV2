using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppAsistenciasV2
{
    public partial class FormCancelarCurso : Form
    {
        public FormCancelarCurso()
        {
            InitializeComponent();
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCursoSeleccionado = cbCurso.SelectedItem.ToString();
            try
            {
                // 1. Obtener el ID del curso seleccionado en el ComboBox
                int idCursoSeleccionado = ObtenerIdCursoSeleccionado();

                // 2. Obtener la identificación del estudiante que ha iniciado sesión
                string identificacionEstudiante = ObtenerIdentificacionEstudiante();

                // 3. Ejecutar una instrucción SQL para eliminar la inscripción del estudiante en el curso seleccionado
                EliminarInscripcionEstudiante(identificacionEstudiante, idCursoSeleccionado);

                // Mostrar un mensaje de éxito o realizar otras acciones necesarias
                MessageBox.Show("Curso cancelado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                MessageBox.Show("Error al cancelar el curso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdCursoSeleccionado()
        {
            // Asumiendo que el DataSource del ComboBox contiene objetos Curso
            if (cbCurso.SelectedItem is Curso cursoSeleccionado)
            {
                // Retorna el ID del curso seleccionado
                return cursoSeleccionado.CursoID;
            }

            // Manejar el caso en el que no se ha seleccionado ningún curso
            throw new InvalidOperationException("No se ha seleccionado ningún curso.");
        }

        private string ObtenerIdentificacionEstudiante()
        {
            if (EstudianteActual.Estudiante != null)
            {
                return EstudianteActual.Estudiante.Identificacion;
            }
            
            // Manejar el caso en el que no hay un estudiante autenticado.
            throw new InvalidOperationException("No hay un estudiante autenticado.");
        }

        private void EliminarInscripcionEstudiante(string identificacionEstudiante, int idCursoSeleccionado)
        {
            string query = "DELETE FROM Inscripciones WHERE EstudianteID = @EstudianteID AND CursoID = @CursoID";

            using (SqlCommand command = new SqlCommand(query, GestionDB.Connection))
            {
                command.Parameters.AddWithValue("@EstudianteID", identificacionEstudiante);
                command.Parameters.AddWithValue("@CursoID", idCursoSeleccionado);

                // Ejecutar la instrucción DELETE
                command.ExecuteNonQuery();
            }
        }
    }
}

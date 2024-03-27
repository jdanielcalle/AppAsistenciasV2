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
    public partial class FormVerCursos : Form
    {
        private GestionDB gestionDB = new GestionDB();
        public FormVerCursos()
        {
            InitializeComponent();
            LlenarComboBoxCursos();
        }

        private void LlenarComboBoxCursos()
        {
            // Obtener la lista de cursos desde la base de datos
            List<string> cursos = gestionDB.ObtenerCursos();

            // Llenar ComboBox con la lista de cursos
            cbEstudiantes.DataSource = cursos;
        }

        private void cbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre del curso seleccionado
            string nombreCursoSeleccionado = cbEstudiantes.SelectedItem.ToString();

            // Obtener y mostrar los estudiantes inscritos en el curso seleccionado
            DataTable estudiantesTable = gestionDB.ObtenerEstudiantesPorCurso(nombreCursoSeleccionado);

            // Configurar el DataGridView para mostrar la información
            dvgEstudiantes.DataSource = estudiantesTable;
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La asistencia ha sido reportada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La asistencia ha sido registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La alerta de baja asistencia ha sido enviada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAsistenciasV2
{
    public partial class FormVerAsistencia : Form
    {
        public FormVerAsistencia()
        {
            InitializeComponent();
        }

        private void FormVerAsistencia_Load(object sender, EventArgs e)
        {
            // Realiza la consulta para obtener los nombres de los cursos
            List<string> nombresCursos = ObtenerNombresCursos();

            // Asigna los nombres de los cursos al ComboBox
            cbVerCursos.DataSource = nombresCursos;
        }

        // Método para obtener los nombres de los cursos desde la base de datos
        private List<string> ObtenerNombresCursos()
        {
            List<string> nombresCursos = new List<string>();

            using (SqlConnection connection = new SqlConnection("Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT NombreCurso FROM Cursos";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombresCursos.Add(reader["NombreCurso"].ToString());
                        }
                    }
                }
            }

            return nombresCursos;
        }

        private void cbVerCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCursoSeleccionado = cbVerCursos.SelectedItem.ToString();

            // Realiza la consulta para obtener la asistencia para el curso seleccionado
            List<Asistencia> asistencias = ObtenerAsistenciasPorCurso(nombreCursoSeleccionado);

            // Asigna las asistencias al DataGridView
            dataGridView1.DataSource = asistencias;
        }

        // Método para obtener las asistencias por curso desde la base de datos
        private List<Asistencia> ObtenerAsistenciasPorCurso(string nombreCurso)
        {
            List<Asistencia> asistencias = new List<Asistencia>();

            using (SqlConnection connection = new SqlConnection("Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT * FROM Asistencia INNER JOIN Cursos ON Asistencia.CursoID = Cursos.CursoID WHERE Cursos.NombreCurso = @NombreCurso";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreCurso", nombreCurso);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Asume que la clase Asistencia tiene propiedades adecuadas, ajusta según tu implementación
                            Asistencia asistencia = new Asistencia
                            {
                                // Ajusta las propiedades según las columnas de la tabla Asistencias
                                Fecha = Convert.ToDateTime(reader["FechaAsistencia"]),
                                Estado = reader["EstadoAsistencia"].ToString(),

                            };
                            asistencias.Add(asistencia);
                        }
                    }
                }
            }
            return asistencias;
        }
    }
}

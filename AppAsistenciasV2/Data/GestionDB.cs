using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AppAsistenciasV2
{
    internal class GestionDB
    {
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;");
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;


        string mensaje = "";
        public GestionDB()
        {

        }
        public void Conectar()
        {
            string strCon = ConfigurationManager.ConnectionStrings["strCon"].ToString();
            try
            {
                connection = new SqlConnection(strCon);
                connection.Open();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }

        public void CerrarConexion()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Método para válidar las credenciales de docente
        public bool ValidarCredencialesDocente(string cedula, string pin)
        {
            try
            {
                // Abre la conexión antes de ejecutar la consulta
                Conectar();

                // La consulta SQL para verificar las credenciales en la base de datos
                string query = "SELECT COUNT(*) FROM Profesores WHERE Cedula = @Cedula AND Pin = @Pin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Cedula", cedula);
                    command.Parameters.AddWithValue("@Pin", pin);

                    int count = (int)command.ExecuteScalar();
                    // Cierra la conexión después de ejecutar la consulta
                    CerrarConexion();
                    // Si count es mayor que cero, las credenciales son válidas
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            } 
        }

        // Método para válidar las credenciales de estudiante
        public bool ValidarCredencialesEstudiante(string identificacion, string pin)
        {
            try
            {
                // Abre la conexión antes de ejecutar la consulta
                Conectar();

                string query = "SELECT COUNT(*) FROM Estudiantes WHERE Identificacion = @Identificacion AND Pin = @Pin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Identificacion", identificacion);
                    command.Parameters.AddWithValue("@Pin", pin);

                    int count = (int)command.ExecuteScalar();

                    // Cierra la conexión después de ejecutar la consulta
                    CerrarConexion();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        private string connectionString = "Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;";

        public List<Curso> ObtenerCursosPorProfesor(int profesorId)
        {
            List<Curso> cursos = new List<Curso>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CursoID, NombreCurso FROM Cursos WHERE ProfesorID = @ProfesorID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfesorID", profesorId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cursos.Add(new Curso
                            {
                                CursoID = Convert.ToInt32(reader["CursoID"]),
                                NombreCurso = reader["NombreCurso"].ToString()
                            });
                        }
                    }
                }
            }

            return cursos;
        }

        public void AgregarCurso(int codigoCurso, string nombreCurso, int profesorId)
        {
            // Ejemplo de consulta SQL para agregar un nuevo curso
            string query = "INSERT INTO Cursos (CursoID, NombreCurso, ProfesorID) VALUES (@CursoID, @NombreCurso, @ProfesorID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CursoID", codigoCurso);
                    command.Parameters.AddWithValue("@NombreCurso", nombreCurso);
                    command.Parameters.AddWithValue("@ProfesorID", profesorId);

                    command.ExecuteNonQuery();
                }
            }
        }
        // Método para editar
        public void EditarCurso(int codigoCurso, string nuevoNombreCurso)
        {
            string query = "UPDATE Cursos SET NombreCurso = @NuevoNombreCurso WHERE CursoID = @CursoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NuevoNombreCurso", nuevoNombreCurso);
                    command.Parameters.AddWithValue("@CursoID", codigoCurso);

                    command.ExecuteNonQuery();
                }
            }
        }
        // Método para eliminar
        public void EliminarCurso(int codigoCurso)
        {
            string query = "DELETE FROM Cursos WHERE CursoID = @CursoID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CursoID", codigoCurso);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AgregarEstudiante(string nombre, string tipoID, string identificacion, string contrasena, string email)
        {
            string cadenaConexion = "Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                // Consulta SQL para insertar un nuevo estudiante en la tabla Estudiantes
                string query = "INSERT INTO Estudiantes (Nombre, TipoIdentificacion, Identificacion, Pin, Email) " +
                               "VALUES (@Nombre, @TipoIdentificacion, @Identificacion, @Pin, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@TipoIdentificacion", tipoID);
                    command.Parameters.AddWithValue("@Identificacion", identificacion);
                    command.Parameters.AddWithValue("@Pin", contrasena);
                    command.Parameters.AddWithValue("@Email", email);

                    // Ejecutar la consulta SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EditarEstudiante(string nombre, string tipoID, string identificacion, string contrasena, string email)
        {
            string cadenaConexion = "Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                // La consulta SQL para actualizar un estudiante en la tabla Estudiantes
                string query = "UPDATE Estudiantes SET TipoIdentificacion = @TipoIdentificacion, Pin = @Pin, Email = @Email " +
                               "WHERE Nombre = @Nombre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@TipoIdentificacion", tipoID);
                    command.Parameters.AddWithValue("@Pin", contrasena);
                    command.Parameters.AddWithValue("@Email", email);

                    // Ejecutar la consulta SQL
                    command.ExecuteNonQuery();
                }
            }
        }
        public Estudiante ObtenerDatosEstudiante(string nombre)
        {
            string query = "SELECT TipoIdentificacion, Identificacion, Pin, Email FROM Estudiantes WHERE Nombre = @Nombre";

            using (SqlConnection connection = new SqlConnection("Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crear un objeto Estudiante con los datos obtenidos
                            Estudiante estudiante = new Estudiante
                            {
                                TipoID = reader["TipoIdentificacion"].ToString(),
                                Identificacion = reader["Identificacion"].ToString(),
                                Contrasena = reader["Pin"].ToString(),
                                Email = reader["Email"].ToString()
                            };

                            return estudiante;
                        }
                    }
                }
            }

            // Si no se encuentra el estudiante, puedes devolver un objeto Estudiante vacío o manejar de otra manera según tus necesidades
            return new Estudiante();
        }
        public void EliminarEstudiantePorNombre(string nombre)
        {
            string query = "DELETE FROM Estudiantes WHERE Nombre = @Nombre";

            using (SqlConnection connection = new SqlConnection("Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);

                    // Ejecuta la consulta para eliminar el estudiante
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<string> ObtenerNombresEstudiantes()
        {
            List<string> nombresEstudiantes = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nombre FROM Estudiantes";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombresEstudiantes.Add(reader["Nombre"].ToString());
                        }
                    }
                }
            }

            return nombresEstudiantes;
        }

        public string ObtenerIdentificacionEstudiante(string nombreEstudiante)
        {
            string identificacion = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Identificacion FROM Estudiantes WHERE Nombre = @Nombre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreEstudiante);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            identificacion = reader["Identificacion"].ToString();
                        }
                    }
                }
            }

            return identificacion;
        }
        private string cadenaConexion = "Data Source=B13-213-5412;Initial Catalog=AppAsistenciasDBV2;Integrated Security=True;";
        public List<string> ObtenerCursos()
        {
            List<string> cursos = new List<string>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string query = "SELECT NombreCurso FROM Cursos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cursos.Add(reader["NombreCurso"].ToString());
                        }
                    }
                }
            }

            return cursos;
        }

        public DataTable ObtenerEstudiantesPorCurso(string nombreCurso)
        {
            DataTable estudiantesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                string query = "SELECT E.Nombre, E.Identificacion " +
                               "FROM Estudiantes E " +
                               "JOIN Inscripciones I ON E.EstudianteID = I.EstudianteID " +
                               "JOIN Cursos C ON I.CursoID = C.CursoID " +
                               "WHERE C.NombreCurso = @NombreCurso";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreCurso", nombreCurso);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(estudiantesTable);
                }
            }

            return estudiantesTable;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAsistenciasV2
{
    public class EstudianteAutenticado
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }

        public EstudianteAutenticado(string identificacion, string nombre)
        {
            Identificacion = identificacion;
            Nombre = nombre;
        }
    }

    public class EstudianteActual
    {
        public static EstudianteAutenticado Estudiante { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppAsistenciasV2
{
    internal class Asistencia
    {
        // Propiedades de la clase Asistencia
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public Asistencia()
        {

        }
    }
}

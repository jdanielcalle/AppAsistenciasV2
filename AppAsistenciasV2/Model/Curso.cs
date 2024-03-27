using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAsistenciasV2
{
    internal class Curso
    {
        public int CursoID { get; set; }
        public string NombreCurso { get; set; }

        public override string ToString()
        {
            // Este método determina cómo se mostrará un objeto Curso en el ComboBox
            return NombreCurso;
        }
    }
}

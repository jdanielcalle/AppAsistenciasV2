using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAsistenciasV2
{
    internal class ProfesorActual
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }

        // Singleton para garantizar una única instancia de ProfesorActual en la aplicación
        private static ProfesorActual instancia;

        private ProfesorActual() { }

        public static ProfesorActual Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ProfesorActual();
                }
                return instancia;
            }
        }
    }
}

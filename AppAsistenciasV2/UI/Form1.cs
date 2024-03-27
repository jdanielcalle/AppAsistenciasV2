using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AppAsistenciasV2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormDocente());
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormEstudiante());
        }

        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(formulario);

            formulario.Show();
        }
    }
}

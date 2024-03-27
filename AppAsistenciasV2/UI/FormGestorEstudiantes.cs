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
    public partial class FormGestorEstudiantes : Form
    {
        public FormGestorEstudiantes()
        {
            InitializeComponent();
        }

        private void MostrarEnPanelSubCentral(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelSubCentral.Controls.Clear();
            panelSubCentral.Controls.Add(formulario);

            formulario.Show();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            MostrarEnPanelSubCentral(new FormAgregarEstudiante());
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            MostrarEnPanelSubCentral(new FormEditarEstudiante());
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            MostrarEnPanelSubCentral(new FormEliminarEstudiante());
        }
    }
}

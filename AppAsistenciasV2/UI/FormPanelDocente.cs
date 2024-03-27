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
    public partial class FormPanelDocente : MaterialForm
    {
        public FormPanelDocente()
        {
            InitializeComponent();
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

        private void VolverAlLogin()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            VolverAlLogin();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormVerCursos());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormGestorCursos());
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FormGestorEstudiantes());
        }
    }
}

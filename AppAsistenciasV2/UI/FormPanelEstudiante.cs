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
    public partial class FormPanelEstudiante : MaterialForm
    {
        public FormPanelEstudiante()
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

        private void btnVerAsistencia_Click_1(object sender, EventArgs e)
        {
            MostrarFormulario(new FormVerAsistencia());
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            MostrarFormulario(new FormCancelarCurso());
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            VolverAlLogin();
        }
    }
}

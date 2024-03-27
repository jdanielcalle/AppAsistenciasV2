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
    public partial class FormGestorCursos : Form
    {
        private GestionDB gestionDB = new GestionDB();
        public FormGestorCursos()
        {
            InitializeComponent();
            LlenarComboBoxCursos();
        }

        private void LlenarComboBoxCursos()
        {
            int profesorId = ObtenerProfesorActualId();
            List<Curso> cursos = gestionDB.ObtenerCursosPorProfesor(profesorId);

            // Llenar ComboBox de editar
            cbCodigoEditar.DataSource = cursos;
            cbCodigoEditar.DisplayMember = "CursoID";
            cbCodigoEditar.ValueMember = "NombreCurso";

            // Llenar ComboBox de eliminar
            cbCodigoEliminar.DataSource = cursos;
            cbCodigoEliminar.DisplayMember = "CursoID";
            cbCodigoEliminar.ValueMember = "NombreCurso";
        }

        private int ObtenerProfesorActualId()
        {
            if (ProfesorActual.Instancia != null)
            {
                return ProfesorActual.Instancia.ProfesorId;
            }
            else
            {
                // Devuelve un valor predeterminado que indique la ausencia de un profesor autenticado
                return -1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoAgregar.Text, out int codigoCurso))
            {
                gestionDB.AgregarCurso(codigoCurso, txtNombreAgregar.Text, ObtenerProfesorActualId());
                LlenarComboBoxCursos();
            }
            else
            {
                MessageBox.Show("El código del curso debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbCodigoEditar.SelectedValue.ToString(), out int codigoCursoEditar))
            {
                gestionDB.EditarCurso(codigoCursoEditar, txtNombreEditar.Text);
                LlenarComboBoxCursos();
            }
            else
            {
                MessageBox.Show("Selecciona un curso para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cbCodigoEliminar.SelectedValue.ToString(), out int codigoCursoEliminar))
            {
                gestionDB.EliminarCurso(codigoCursoEliminar);
                LlenarComboBoxCursos();
            }
            else
            {
                MessageBox.Show("Selecciona un curso para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

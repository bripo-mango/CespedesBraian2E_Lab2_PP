using Libreria_Clases_TP_SYSACAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcialLabo2
{
    public partial class FormInscripcionCursos : Form
    {
        string respuestaValidador;

        List<Curso> cursoList = new List<Curso>();

        DataGridView dataGrid;

        ValidadorYAdministradorDeCupos validadorCupos = new ValidadorYAdministradorDeCupos();

        public FormInscripcionCursos(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;
            InitializeComponent();
        }

        private void FormInscripcionCursos_Load(object sender, EventArgs e)
        {
            dataGridView_CursosParaInscribirse.DataSource = Sistema.BaseDatosCursos.DevolverCursosDisponibles();
        }

        private void dataGridView_CursosParaInscribirse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CursosParaInscribirse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_Inscribirse_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_CursosParaInscribirse.SelectedRows)
            {
                Curso curso = (Curso)row.DataBoundItem;
                cursoList.Add(curso);
            }
            var respuestaUsuario = MessageBox.Show("Esta a punto de inscribirse a los cursos seleccionados, ¿Desea continuar?", "Confirmar inscripción", MessageBoxButtons.OKCancel);

            if (respuestaUsuario == DialogResult.OK)
            {
                respuestaValidador = validadorCupos.ValidarCursosSegunCupo(cursoList);
                if (respuestaValidador == "OK")
                {
                    MessageBox.Show("Se ha inscripto a los cursos seleccionados correctamente");
                    dataGrid.DataSource = null;
                    dataGrid.DataSource = Sistema.EstudianteLogueado.CursosInscriptos;
                }
                else
                {
                    MessageBox.Show($"No se pudo inscribir a los siguientes cursos por falta de cupo: {string.Join(", ", validadorCupos.CursosSinCupo)}");
                }
            }
            else
            {
                MessageBox.Show("Se ha cancelado la inscripción a los cursos seleccionados");
            }
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            DialogResult resultadoBox = MessageBox.Show("¿Esta seguro de querer salir de la sesión actual?", "Salir", MessageBoxButtons.OKCancel);

            if (resultadoBox == DialogResult.OK)
            {
                Close();
                FormInicio form = new FormInicio();
                form.ShowDialog();
            }
        }
    }
}

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
    public partial class FormCurso : Form
    {
        public FormCurso()
        {
            InitializeComponent();
        }

        private void dataGrid_Cursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_Cursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button_AgregarCurso_Click(object sender, EventArgs e)
        {
            FormNuevoCurso nuevoCurso = new FormNuevoCurso(dataGrid_Cursos);

            nuevoCurso.ShowDialog();

            dataGrid_Cursos.DataSource = null;
            dataGrid_Cursos.DataSource = Sistema.BaseDatosCursos.Cursos;

        }

        private void button_EditarGrupo_Click(object sender, EventArgs e)
        {
            if (dataGrid_Cursos.CurrentRow is not null)
            {
                string codigoMateria = (string)dataGrid_Cursos.CurrentRow.Cells["codigoDataGridViewTextBoxColumn"].Value;

                Curso curso = Sistema.BaseDatosCursos.Cursos.FirstOrDefault(x => x.Codigo == codigoMateria);

                FormEditarCurso formEditarCurso = new FormEditarCurso(curso, dataGrid_Cursos);

                formEditarCurso.ShowDialog();
            }
        }

        private void button_EliminarCurso_Click(object sender, EventArgs e)
        {

            if (dataGrid_Cursos.CurrentRow is not null)
            {
                string codigoMateria = (string)dataGrid_Cursos.CurrentRow.Cells["codigoDataGridViewTextBoxColumn"].Value;
                string nombreMateria = (string)dataGrid_Cursos.CurrentRow.Cells["nombreDataGridViewTextBoxColumn"].Value;


                DialogResult resultadoBox = MessageBox.Show($"Esta a punto de eliminar el curso: {nombreMateria}: {codigoMateria} ", "Eliminar Curso", MessageBoxButtons.YesNo);

                if (resultadoBox == DialogResult.Yes)
                {
                    Sistema.BaseDatosCursos.EliminarCursoBD(codigoMateria);
                    MessageBox.Show("El curso se ha eliminado del sistema");
                    dataGrid_Cursos.Update();
                    dataGrid_Cursos.DataSource = null;
                    dataGrid_Cursos.DataSource = Sistema.BaseDatosCursos.Cursos;
                }

            }
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {
            dataGrid_Cursos.DataSource = Sistema.BaseDatosCursos.Cursos;
            dataGrid_Cursos.Rows[0].Selected = false;
            dataGrid_Cursos.Update();


        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

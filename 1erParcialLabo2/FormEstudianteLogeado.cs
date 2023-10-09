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
    public partial class FormEstudianteLogeado : Form
    {
        Estudiante? estudianteLogeado;

        string mensajeBienvenida = $"Bienvenido {Sistema.EstudianteLogueado.Nombre}";

        public FormEstudianteLogeado(Estudiante estudiante)
        {
            estudianteLogeado = estudiante;
            InitializeComponent();
        }

        private void dataGridView_CursosEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CursosEstudiante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FormEstudianteLogeado_Load(object sender, EventArgs e)
        {
            dataGridView_CursosEstudiante.DataSource = estudianteLogeado.CursosInscriptos;
            label_BienvenidaEstudiante.Text = mensajeBienvenida;
        }

        private void button_InscribirseCursos_Click(object sender, EventArgs e)
        {
            FormInscripcionCursos formInscripcion = new FormInscripcionCursos(dataGridView_CursosEstudiante);

            formInscripcion.ShowDialog();
        }

        private void button_Horarios_Click(object sender, EventArgs e)
        {

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Sistema.EstudianteLogueado = null;
            estudianteLogeado = null;
            this.Close();
        }

        private void button_RealizarPagos_Click(object sender, EventArgs e)
        {
            FormPagos formPagos = new FormPagos();
            formPagos.ShowDialog();
        }
    }
}

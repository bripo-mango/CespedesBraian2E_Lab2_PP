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
    public partial class FormAdminLogeado : Form
    {

        public FormAdminLogeado()
        {
            InitializeComponent();
        }

        private void FormAdminLogeado_Load(object sender, EventArgs e)
        {
        }

        private void button_IngresoEstudiante_Click(object sender, EventArgs e)
        {
            FormNuevoEstudiante formIngresoEstudiante = new FormNuevoEstudiante();
            formIngresoEstudiante.ShowDialog();
        }

        private void button_IngresarCurso_Click(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            formCurso.ShowDialog();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {

            DialogResult resultadoBox = MessageBox.Show("¿Esta seguro de querer salir de la sesion actual?", "Salir", MessageBoxButtons.OKCancel);

            if (resultadoBox == DialogResult.OK)
            {
                Close();
                FormInicio form = new FormInicio();
                form.ShowDialog();
            }

        }
    }
}

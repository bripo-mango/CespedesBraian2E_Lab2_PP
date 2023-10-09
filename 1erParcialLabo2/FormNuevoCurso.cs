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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1erParcialLabo2
{
    public partial class FormNuevoCurso : Form
    {
        DataGridView cursos;

        Curso nuevoCurso;

        Dictionary<string, string> _diccionarioCampos;

        ValidadorInputCursos validadorInput = new ValidadorInputCursos();


        public FormNuevoCurso(DataGridView cursos)
        {
            InitializeComponent();
            this.cursos = cursos;
        }

        private void txtBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNuevoCurso_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_CapMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_CrearCurso_Click(object sender, EventArgs e)
        {
            _diccionarioCampos = new Dictionary<string, string>();

            _diccionarioCampos.Add("nombre", txtBox_Nombre.Text);
            _diccionarioCampos.Add("codigo", txtBox_Codigo.Text);
            _diccionarioCampos.Add("cupoMax", txtBox_CapMax.Text);
            _diccionarioCampos.Add("descripcion", txtBox_Desc.Text);
            _diccionarioCampos.Add("aula", txtBox_Aula.Text);

            var respuesta = validadorInput.ValidarDatosCurso(_diccionarioCampos);
            var respuestaDuplicados = ValidadorDuplicados.ValidarDuplicados(txtBox_Codigo.Text);

            if (!respuesta.ExistenciaErrores)
            {
                if (!respuestaDuplicados)
                {
                    nuevoCurso = new Curso(txtBox_Nombre.Text, txtBox_Codigo.Text, txtBox_Desc.Text, Convert.ToInt32(txtBox_CapMax.Text), comboBox_Horarios.Text, txtBox_Aula.Text, comboBox_Dia.Text);
                    nuevoCurso.RegistrarCurso();
                    MessageBox.Show("El curso se ha generado con éxito");
                    cursos.Update();
                }
                else
                {
                    MessageBox.Show("El código ingresado ya se encuentra registrado en el sistema");

                }

                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta.MensajeErrores);
            }
        }

        private void txtBox_Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Horarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Aula_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Dia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

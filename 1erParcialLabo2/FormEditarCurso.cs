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
    public partial class FormEditarCurso : Form
    {
        Curso curso;

        Dictionary<string, string> _diccionarioCampos;

        ValidadorInputCursos validadorInput = new ValidadorInputCursos();

        string codigoAbuscar;

        DataGridView gridCursos;

        public FormEditarCurso(Curso curso, DataGridView gridCursos)
        {
            InitializeComponent();
            this.curso = curso;
            this.gridCursos = gridCursos;
        }

        private void txtBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_CupoMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            _diccionarioCampos = new Dictionary<string, string>();

            _diccionarioCampos.Add("nombre", txtBox_Nombre.Text);
            _diccionarioCampos.Add("codigo", txtBox_Codigo.Text);
            _diccionarioCampos.Add("cupoMax", txtBox_CupoMax.Text);
            _diccionarioCampos.Add("descripcion", txtBox_Desc.Text);
            _diccionarioCampos.Add(comboBox_Horarios.Name, (string)comboBox_Horarios.Text);
            _diccionarioCampos.Add("aula", txtBox_Aula.Text);
            _diccionarioCampos.Add(comboBox_Dia.Name, (string)comboBox_Dia.Text);

            var respuesta = validadorInput.ValidarDatosCurso(_diccionarioCampos);
            var respuestaDuplicados = ValidadorDuplicados.ValidarDuplicados(txtBox_Codigo.Text);

            if (!respuesta.ExistenciaErrores)
            {
                if (respuestaDuplicados)
                {
                    Sistema.BaseDatosCursos.EditarCursoBD(codigoAbuscar, txtBox_Nombre.Text, txtBox_Codigo.Text, txtBox_Desc.Text, Convert.ToInt32(txtBox_CupoMax.Text), (string)comboBox_Horarios.Text, (string)comboBox_Dia.Text, txtBox_Aula.Text);
                    MessageBox.Show("Se modificaron los datos con éxito");
                    gridCursos.Refresh();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(respuesta.MensajeErrores);
            }
            gridCursos.ClearSelection();

        }

        private void FormEditarCurso_Load(object sender, EventArgs e)
        {
            txtBox_Codigo.Text = curso.Codigo;
            txtBox_Nombre.Text = curso.Nombre;
            codigoAbuscar = curso.Codigo;
            txtBox_Desc.Text = curso.Descripcion;
            txtBox_CupoMax.Text = curso.CupoMaximo.ToString();
            txtBox_Aula.Text = curso.Aula;

            comboBox_Dia.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" });
            comboBox_Horarios.Items.AddRange(new string[] { "Mañana", "Tarde", "Noche" });

            comboBox_Dia.SelectedItem = curso.Dia.ToString();
            comboBox_Horarios.SelectedItem = curso.Turno.ToString();

        }

        private void comboBox_Dia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Aula_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Horarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

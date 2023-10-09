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
    public partial class FormLogEstudiante : Form
    {
        ValidadorCredenciales validadorCredenciales;
        bool todoOk = true;

        public FormLogEstudiante()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            validadorCredenciales = new ValidadorCredenciales();
        }

        private void txtBox_Legajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Legajo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_Ingresar_Click_1(object sender, EventArgs e)
        {

            if (todoOk == false && !string.IsNullOrEmpty(txtBox_Pass.Text))
            {
                Sistema.BaseDatosEstudiantes.CambiarContraseñaAEstudiante(txtBox_Mail.Text, txtBox_Pass.Text);
            }

            string respuesta = validadorCredenciales.ValidarCredenciales(txtBox_Mail.Text, txtBox_Pass.Text, Log.Estudiante);

            if (respuesta == "OK")
            {
                if (Sistema.BaseDatosEstudiantes.BuscarSiUsuarioDebeCambiarContrasenia(txtBox_Mail.Text))
                {
                    todoOk = false;
                }
                else if (respuesta == "OK")
                {
                    Sistema.IngresarEstudianteComoUsuarioActivo(txtBox_Mail.Text);

                    FormEstudianteLogeado formEstudiante = new FormEstudianteLogeado(Sistema.EstudianteLogueado);
                    formEstudiante.Show();
                    todoOk = true;
                    this.Close();
                }
            }
            else if (respuesta == "CAMPOS VACIOS")
            {
                MessageBox.Show("Debe completar todos los campos para poder ingresar");

            }
            else
            {
                MessageBox.Show("El usuario no fue encontrado");

            }

            if (!todoOk)
            {
                MessageBox.Show("El usuario debe cambiar la contraseña");

            }
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Close();
        }
    }
}

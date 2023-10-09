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
    public partial class FormNuevoEstudiante : Form
    {
        Dictionary<string, string> _diccionarioCampos;
        Estudiante estudiante;
        ValidadorInputEstudiantes validadorEstudiantes = new ValidadorInputEstudiantes();
        string campoContrasenia = "contrasenia";

        public FormNuevoEstudiante()
        {
            InitializeComponent();
        }

        private void FormIngresoEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_NombreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CambiarPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_IngresoEstudiante_Click(object sender, EventArgs e)
        {

            _diccionarioCampos = new Dictionary<string, string>();

            _diccionarioCampos.Add(label_Nombre.Text.ToLower(), txtBox_NombreEstudiante.Text);
            _diccionarioCampos.Add(label_Legajo.Text.ToLower(), txtBox_Legajo.Text);
            _diccionarioCampos.Add(label_Telefono.Text.ToLower(), txtBox_Telefono.Text);
            _diccionarioCampos.Add(label_Correo.Text.ToLower(), txtBox_Correo.Text);
            _diccionarioCampos.Add(label_Direccion.Text.ToLower(), txtBox_Direccion.Text);
            _diccionarioCampos.Add(campoContrasenia, txtBox_Legajo.Text);

            var respuesta = validadorEstudiantes.ValidarDatosEstudiantes(_diccionarioCampos);

            if (!respuesta.ExistenciaErrores && respuesta.AusenciaCamposVacios)
            {
                estudiante = new Estudiante(txtBox_NombreEstudiante.Text, txtBox_Legajo.Text, txtBox_Direccion.Text, txtBox_Telefono.Text, txtBox_Correo.Text, txtBox_Legajo.Text, checkBox_CambiarPass.Checked);

                estudiante.RegistrarEstudiante();

                EmisorCorreoElectronico.EnviarCorreoElectronico(estudiante, txtBox_Legajo.Text);

                MessageBox.Show("El alumno se ha creado con éxito");

                txtBox_NombreEstudiante.Text = null;
                txtBox_Legajo.Text = null;
                txtBox_Telefono.Text = null;
                txtBox_Correo.Text = null;
                txtBox_Direccion.Text = null;
            }
            else if (!string.IsNullOrEmpty(respuesta.MensajeErrores))
            {
                MessageBox.Show(respuesta.MensajeErrores);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para poder continuar");

            }

        }

        private void button_CerrarIngresoAlumnos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}

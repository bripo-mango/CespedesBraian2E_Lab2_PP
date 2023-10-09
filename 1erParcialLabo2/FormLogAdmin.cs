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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _1erParcialLabo2
{
    public partial class FormLogAdmin : Form
    {
        private string correo;
        private string contrasenia;

        private ValidadorCredenciales validadorCredenciales;

        FormAdminLogeado formAdminLogeado;


        private string respuestaValidador;

        public FormLogAdmin()
        {
            InitializeComponent();
            validadorCredenciales = new ValidadorCredenciales();
        }

        private void txtBox_Usuario_TextChanged(object sender, EventArgs e)
        {
            correo = txtBox_Usuario.Text;
        }

        private void txtBox_Pass_TextChanged(object sender, EventArgs e)
        {
            contrasenia = txtBox_Pass.Text;
        }

        private void button_IngresarAdmin_Click(object sender, EventArgs e)
        {

            bool logPorCod = false;


            if (textBox1.Text == Sistema.CodigoAccesoAdmins)
            {
                logPorCod = true;
                this.Close();
                formAdminLogeado = new FormAdminLogeado();
                formAdminLogeado.Show();
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Código ingresado invalido");
            }

            if (!logPorCod && string.IsNullOrEmpty(textBox1.Text))
            {
                respuestaValidador = validadorCredenciales.ValidarCredenciales(correo, contrasenia, Log.Admin);

                if (respuestaValidador == "OK" && string.IsNullOrEmpty(textBox1.Text))
                {
                    Close();
                    formAdminLogeado.Show();
                }
                else if (respuestaValidador == "NO ENCONTRADO")
                {
                    MessageBox.Show("No se ha encontrado ningun usuario registrado en la base de datos");
                }
                else
                {
                    MessageBox.Show("Uno o mas campos se encuentran vacios");

                }
            }
        }

        private void label_pass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FormLogAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Button_Volver_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

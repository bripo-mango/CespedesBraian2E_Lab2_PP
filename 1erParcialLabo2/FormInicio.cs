using Libreria_Clases_TP_SYSACAD;

namespace _1erParcialLabo2
{
    public partial class FormInicio : Form
    {


        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            this.Visible = true;

            try
            {
                Sistema.InicializarSistema();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_LogAdmins_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FormLogAdmin formLogAdmin = new();

            formLogAdmin.ShowDialog();
        }
        private void button_LogEstudiantes_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FormLogEstudiante formLog = new();

            formLog.ShowDialog();
        }
    }
}
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
    public partial class FormPagos : Form
    {
        public FormPagos()
        {
            InitializeComponent();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            if (Sistema.EstudianteLogueado.ConceptosDePago is null)
            {
                Sistema.EstudianteLogueado.AñadirConceptosDePagoIniciales();
            }

            dataGridView_ConceptosPago.DataSource = Sistema.EstudianteLogueado.ConceptosDePago;
        }

        private void dataGridView_ConceptosPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

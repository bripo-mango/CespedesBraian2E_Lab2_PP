namespace _1erParcialLabo2
{
    partial class FormPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_ConceptosPago = new DataGridView();
            button_Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ConceptosPago).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_ConceptosPago
            // 
            dataGridView_ConceptosPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ConceptosPago.Location = new Point(12, 29);
            dataGridView_ConceptosPago.Name = "dataGridView_ConceptosPago";
            dataGridView_ConceptosPago.RowTemplate.Height = 25;
            dataGridView_ConceptosPago.Size = new Size(240, 150);
            dataGridView_ConceptosPago.TabIndex = 0;
            dataGridView_ConceptosPago.CellContentClick += dataGridView_ConceptosPago_CellContentClick;
            // 
            // button_Volver
            // 
            button_Volver.Location = new Point(12, 343);
            button_Volver.Name = "button_Volver";
            button_Volver.Size = new Size(75, 23);
            button_Volver.TabIndex = 1;
            button_Volver.Text = "Volver";
            button_Volver.UseVisualStyleBackColor = true;
            button_Volver.Click += button_Volver_Click;
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 408);
            Controls.Add(button_Volver);
            Controls.Add(dataGridView_ConceptosPago);
            Name = "FormPagos";
            Text = "Pagos";
            Load += FormPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_ConceptosPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_ConceptosPago;
        private Button button_Volver;
    }
}
namespace _1erParcialLabo2
{
    partial class FormAdminLogeado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLogeado));
            button_IngresoEstudiante = new Button();
            label1 = new Label();
            button_IngresarCurso = new Button();
            button_Salir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button_IngresoEstudiante
            // 
            button_IngresoEstudiante.Location = new Point(83, 211);
            button_IngresoEstudiante.Name = "button_IngresoEstudiante";
            button_IngresoEstudiante.Size = new Size(124, 26);
            button_IngresoEstudiante.TabIndex = 0;
            button_IngresoEstudiante.Text = "Registrar Estudiante";
            button_IngresoEstudiante.UseVisualStyleBackColor = true;
            button_IngresoEstudiante.Click += button_IngresoEstudiante_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 35);
            label1.Name = "label1";
            label1.Size = new Size(269, 36);
            label1.TabIndex = 1;
            label1.Text = "Menu Administrador";
            // 
            // button_IngresarCurso
            // 
            button_IngresarCurso.Location = new Point(573, 211);
            button_IngresarCurso.Name = "button_IngresarCurso";
            button_IngresarCurso.Size = new Size(124, 23);
            button_IngresarCurso.TabIndex = 2;
            button_IngresarCurso.Text = "Gestionar Cursos";
            button_IngresarCurso.UseVisualStyleBackColor = true;
            button_IngresarCurso.Click += button_IngresarCurso_Click;
            // 
            // button_Salir
            // 
            button_Salir.Location = new Point(31, 388);
            button_Salir.Name = "button_Salir";
            button_Salir.Size = new Size(75, 23);
            button_Salir.TabIndex = 3;
            button_Salir.Text = "Salir";
            button_Salir.UseVisualStyleBackColor = true;
            button_Salir.Click += button_Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 220);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_UTN_Avellaneda_1;
            pictureBox2.Location = new Point(641, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 72);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FormAdminLogeado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button_Salir);
            Controls.Add(button_IngresarCurso);
            Controls.Add(label1);
            Controls.Add(button_IngresoEstudiante);
            Name = "FormAdminLogeado";
            Text = "FormAdminLogeado";
            Load += FormAdminLogeado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_IngresoEstudiante;
        private Label label1;
        private Button button_IngresarCurso;
        private Button button_Salir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
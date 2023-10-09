namespace _1erParcialLabo2
{
    partial class FormNuevoEstudiante
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
            txtBox_NombreEstudiante = new TextBox();
            label_Nombre = new Label();
            txtBox_Legajo = new TextBox();
            label_Legajo = new Label();
            txtBox_Telefono = new TextBox();
            label_Telefono = new Label();
            label4 = new Label();
            txtBox_Correo = new TextBox();
            label_Correo = new Label();
            checkBox_CambiarPass = new CheckBox();
            button_IngresoEstudiante = new Button();
            txtBox_Direccion = new TextBox();
            label_Direccion = new Label();
            label5 = new Label();
            button_CerrarIngresoAlumnos = new Button();
            SuspendLayout();
            // 
            // txtBox_NombreEstudiante
            // 
            txtBox_NombreEstudiante.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_NombreEstudiante.Location = new Point(94, 164);
            txtBox_NombreEstudiante.Name = "txtBox_NombreEstudiante";
            txtBox_NombreEstudiante.Size = new Size(100, 23);
            txtBox_NombreEstudiante.TabIndex = 0;
            txtBox_NombreEstudiante.TextChanged += txtBox_NombreEstudiante_TextChanged;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre.Location = new Point(94, 127);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(65, 19);
            label_Nombre.TabIndex = 1;
            label_Nombre.Text = "Nombre";
            // 
            // txtBox_Legajo
            // 
            txtBox_Legajo.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Legajo.Location = new Point(94, 239);
            txtBox_Legajo.Name = "txtBox_Legajo";
            txtBox_Legajo.Size = new Size(100, 23);
            txtBox_Legajo.TabIndex = 2;
            // 
            // label_Legajo
            // 
            label_Legajo.AutoSize = true;
            label_Legajo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Legajo.Location = new Point(94, 201);
            label_Legajo.Name = "label_Legajo";
            label_Legajo.Size = new Size(53, 19);
            label_Legajo.TabIndex = 3;
            label_Legajo.Text = "Legajo";
            // 
            // txtBox_Telefono
            // 
            txtBox_Telefono.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Telefono.Location = new Point(94, 325);
            txtBox_Telefono.Name = "txtBox_Telefono";
            txtBox_Telefono.Size = new Size(126, 23);
            txtBox_Telefono.TabIndex = 4;
            txtBox_Telefono.TextChanged += txtBoxTelefono_TextChanged;
            // 
            // label_Telefono
            // 
            label_Telefono.AutoSize = true;
            label_Telefono.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Telefono.Location = new Point(94, 293);
            label_Telefono.Name = "label_Telefono";
            label_Telefono.Size = new Size(68, 19);
            label_Telefono.TabIndex = 5;
            label_Telefono.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 50);
            label4.Name = "label4";
            label4.Size = new Size(617, 36);
            label4.TabIndex = 6;
            label4.Text = "Bienvenido al sistema de ingresos de estudiantes";
            label4.Click += label4_Click;
            // 
            // txtBox_Correo
            // 
            txtBox_Correo.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Correo.Location = new Point(385, 164);
            txtBox_Correo.Name = "txtBox_Correo";
            txtBox_Correo.Size = new Size(125, 23);
            txtBox_Correo.TabIndex = 7;
            txtBox_Correo.TextChanged += txtBox_Correo_TextChanged;
            // 
            // label_Correo
            // 
            label_Correo.AutoSize = true;
            label_Correo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Correo.Location = new Point(385, 131);
            label_Correo.Name = "label_Correo";
            label_Correo.Size = new Size(55, 19);
            label_Correo.TabIndex = 8;
            label_Correo.Text = "Correo";
            // 
            // checkBox_CambiarPass
            // 
            checkBox_CambiarPass.AutoSize = true;
            checkBox_CambiarPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox_CambiarPass.Location = new Point(385, 323);
            checkBox_CambiarPass.Name = "checkBox_CambiarPass";
            checkBox_CambiarPass.Size = new Size(190, 21);
            checkBox_CambiarPass.TabIndex = 9;
            checkBox_CambiarPass.Text = "Debe cambiar contraseaña";
            checkBox_CambiarPass.UseVisualStyleBackColor = true;
            checkBox_CambiarPass.CheckedChanged += checkBox_CambiarPass_CheckedChanged;
            // 
            // button_IngresoEstudiante
            // 
            button_IngresoEstudiante.Location = new Point(549, 470);
            button_IngresoEstudiante.Name = "button_IngresoEstudiante";
            button_IngresoEstudiante.Size = new Size(127, 27);
            button_IngresoEstudiante.TabIndex = 10;
            button_IngresoEstudiante.Text = "Ingresar estudiante";
            button_IngresoEstudiante.TextAlign = ContentAlignment.TopCenter;
            button_IngresoEstudiante.UseVisualStyleBackColor = true;
            button_IngresoEstudiante.Click += button_IngresoEstudiante_Click;
            // 
            // txtBox_Direccion
            // 
            txtBox_Direccion.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Direccion.Location = new Point(385, 239);
            txtBox_Direccion.Name = "txtBox_Direccion";
            txtBox_Direccion.Size = new Size(125, 23);
            txtBox_Direccion.TabIndex = 11;
            // 
            // label_Direccion
            // 
            label_Direccion.AutoSize = true;
            label_Direccion.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Direccion.Location = new Point(385, 205);
            label_Direccion.Name = "label_Direccion";
            label_Direccion.Size = new Size(73, 19);
            label_Direccion.TabIndex = 12;
            label_Direccion.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(49, 398);
            label5.Name = "label5";
            label5.Size = new Size(545, 19);
            label5.TabIndex = 13;
            label5.Text = "* La contraseña provisional generada será el mismo valor que el campo legajo.";
            // 
            // button_CerrarIngresoAlumnos
            // 
            button_CerrarIngresoAlumnos.Location = new Point(56, 468);
            button_CerrarIngresoAlumnos.Name = "button_CerrarIngresoAlumnos";
            button_CerrarIngresoAlumnos.Size = new Size(103, 29);
            button_CerrarIngresoAlumnos.TabIndex = 14;
            button_CerrarIngresoAlumnos.Text = "Volver";
            button_CerrarIngresoAlumnos.UseVisualStyleBackColor = true;
            button_CerrarIngresoAlumnos.Click += button_CerrarIngresoAlumnos_Click;
            // 
            // FormIngresoEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(707, 520);
            Controls.Add(button_CerrarIngresoAlumnos);
            Controls.Add(label5);
            Controls.Add(label_Direccion);
            Controls.Add(txtBox_Direccion);
            Controls.Add(button_IngresoEstudiante);
            Controls.Add(checkBox_CambiarPass);
            Controls.Add(label_Correo);
            Controls.Add(txtBox_Correo);
            Controls.Add(label4);
            Controls.Add(label_Telefono);
            Controls.Add(txtBox_Telefono);
            Controls.Add(label_Legajo);
            Controls.Add(txtBox_Legajo);
            Controls.Add(label_Nombre);
            Controls.Add(txtBox_NombreEstudiante);
            Name = "FormIngresoEstudiante";
            Text = "Ingresar Nuevo Estudiante";
            Load += FormIngresoEstudiante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_NombreEstudiante;
        private Label label_Nombre;
        private TextBox txtBox_Legajo;
        private Label label_Legajo;
        private TextBox txtBox_Telefono;
        private Label label_Telefono;
        private Label label4;
        private TextBox txtBox_Correo;
        private Label label_Correo;
        private CheckBox checkBox_CambiarPass;
        private Button button_IngresoEstudiante;
        private TextBox txtBox_Direccion;
        private Label label_Direccion;
        private Label label5;
        private Button button_CerrarIngresoAlumnos;
    }
}
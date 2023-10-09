namespace _1erParcialLabo2
{
    partial class FormNuevoCurso
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
            txtBox_Nombre = new TextBox();
            txtBox_Codigo = new TextBox();
            txtBox_Desc = new TextBox();
            txtBox_CapMax = new TextBox();
            label_Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_Volver = new Button();
            button_CrearCurso = new Button();
            comboBox_Horarios = new ComboBox();
            label_Turno = new Label();
            label1 = new Label();
            txtBox_Aula = new TextBox();
            comboBox_Dia = new ComboBox();
            label_Dia = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBox_Nombre
            // 
            txtBox_Nombre.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Nombre.Location = new Point(130, 114);
            txtBox_Nombre.Name = "txtBox_Nombre";
            txtBox_Nombre.Size = new Size(100, 23);
            txtBox_Nombre.TabIndex = 0;
            txtBox_Nombre.TextChanged += txtBox_Nombre_TextChanged;
            // 
            // txtBox_Codigo
            // 
            txtBox_Codigo.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Codigo.Location = new Point(130, 182);
            txtBox_Codigo.Name = "txtBox_Codigo";
            txtBox_Codigo.Size = new Size(100, 23);
            txtBox_Codigo.TabIndex = 1;
            txtBox_Codigo.TextChanged += txtBox_Codigo_TextChanged;
            // 
            // txtBox_Desc
            // 
            txtBox_Desc.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Desc.Location = new Point(127, 263);
            txtBox_Desc.Name = "txtBox_Desc";
            txtBox_Desc.Size = new Size(100, 23);
            txtBox_Desc.TabIndex = 2;
            txtBox_Desc.TextChanged += txtBox_Desc_TextChanged;
            // 
            // txtBox_CapMax
            // 
            txtBox_CapMax.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_CapMax.Location = new Point(127, 342);
            txtBox_CapMax.Name = "txtBox_CapMax";
            txtBox_CapMax.Size = new Size(100, 23);
            txtBox_CapMax.TabIndex = 3;
            txtBox_CapMax.TextChanged += txtBox_CapMax_TextChanged;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre.Location = new Point(130, 80);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(107, 19);
            label_Nombre.TabIndex = 4;
            label_Nombre.Text = "Nombre Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 153);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 5;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(139, 230);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 6;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(124, 305);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 7;
            label4.Text = "Cupo Máximo";
            // 
            // button_Volver
            // 
            button_Volver.Location = new Point(50, 448);
            button_Volver.Name = "button_Volver";
            button_Volver.Size = new Size(75, 23);
            button_Volver.TabIndex = 8;
            button_Volver.Text = "Volver";
            button_Volver.UseVisualStyleBackColor = true;
            button_Volver.Click += button_Volver_Click;
            // 
            // button_CrearCurso
            // 
            button_CrearCurso.Location = new Point(487, 448);
            button_CrearCurso.Name = "button_CrearCurso";
            button_CrearCurso.Size = new Size(75, 23);
            button_CrearCurso.TabIndex = 9;
            button_CrearCurso.Text = "Confirmar";
            button_CrearCurso.UseVisualStyleBackColor = true;
            button_CrearCurso.Click += button_CrearCurso_Click;
            // 
            // comboBox_Horarios
            // 
            comboBox_Horarios.BackColor = SystemColors.GradientInactiveCaption;
            comboBox_Horarios.FormattingEnabled = true;
            comboBox_Horarios.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            comboBox_Horarios.Location = new Point(403, 162);
            comboBox_Horarios.Name = "comboBox_Horarios";
            comboBox_Horarios.Size = new Size(121, 23);
            comboBox_Horarios.TabIndex = 10;
            comboBox_Horarios.SelectedIndexChanged += comboBox_Horarios_SelectedIndexChanged;
            // 
            // label_Turno
            // 
            label_Turno.AutoSize = true;
            label_Turno.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Turno.Location = new Point(430, 118);
            label_Turno.Name = "label_Turno";
            label_Turno.Size = new Size(49, 19);
            label_Turno.TabIndex = 11;
            label_Turno.Text = "Turno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(430, 282);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 12;
            label1.Text = "Aula";
            // 
            // txtBox_Aula
            // 
            txtBox_Aula.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Aula.Location = new Point(403, 305);
            txtBox_Aula.Name = "txtBox_Aula";
            txtBox_Aula.Size = new Size(121, 23);
            txtBox_Aula.TabIndex = 13;
            txtBox_Aula.TextChanged += txtBox_Aula_TextChanged;
            // 
            // comboBox_Dia
            // 
            comboBox_Dia.BackColor = SystemColors.GradientInactiveCaption;
            comboBox_Dia.FormattingEnabled = true;
            comboBox_Dia.Items.AddRange(new object[] { "Lunes", "Martes", "Míercoles", "Jueves", "Víernes" });
            comboBox_Dia.Location = new Point(403, 241);
            comboBox_Dia.Name = "comboBox_Dia";
            comboBox_Dia.Size = new Size(121, 23);
            comboBox_Dia.TabIndex = 14;
            comboBox_Dia.SelectedIndexChanged += comboBox_Dia_SelectedIndexChanged;
            // 
            // label_Dia
            // 
            label_Dia.AutoSize = true;
            label_Dia.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Dia.Location = new Point(439, 203);
            label_Dia.Name = "label_Dia";
            label_Dia.Size = new Size(31, 19);
            label_Dia.TabIndex = 15;
            label_Dia.Text = "Día";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(227, 29);
            label5.Name = "label5";
            label5.Size = new Size(197, 26);
            label5.TabIndex = 16;
            label5.Text = "Generar Nuevo Curso";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_UTN_Avellaneda_1;
            pictureBox1.Location = new Point(471, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 77);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // FormNuevoCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(631, 504);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label_Dia);
            Controls.Add(comboBox_Dia);
            Controls.Add(txtBox_Aula);
            Controls.Add(label1);
            Controls.Add(label_Turno);
            Controls.Add(comboBox_Horarios);
            Controls.Add(button_CrearCurso);
            Controls.Add(button_Volver);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_Nombre);
            Controls.Add(txtBox_CapMax);
            Controls.Add(txtBox_Desc);
            Controls.Add(txtBox_Codigo);
            Controls.Add(txtBox_Nombre);
            Name = "FormNuevoCurso";
            Text = "Nuevo Curso";
            Load += FormNuevoCurso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_Nombre;
        private TextBox txtBox_Codigo;
        private TextBox txtBox_Desc;
        private TextBox txtBox_CapMax;
        private Label label_Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_Volver;
        private Button button_CrearCurso;
        private ComboBox comboBox_Horarios;
        private Label label_Turno;
        private Label label1;
        private TextBox txtBox_Aula;
        private ComboBox comboBox_Dia;
        private Label label_Dia;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
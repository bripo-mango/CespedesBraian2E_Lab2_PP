namespace _1erParcialLabo2
{
    partial class FormEditarCurso
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
            button_Confirmar = new Button();
            button_Volver = new Button();
            label_Nombre = new Label();
            label_Codigo = new Label();
            label_Desc = new Label();
            label_CupoMax = new Label();
            txtBox_CupoMax = new TextBox();
            txtBox_Nombre = new TextBox();
            txtBox_Codigo = new TextBox();
            txtBox_Desc = new TextBox();
            label1 = new Label();
            label_Turno = new Label();
            label_Aula = new Label();
            txtBox_Aula = new TextBox();
            label_Dia = new Label();
            comboBox_Dia = new ComboBox();
            comboBox_Horarios = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Confirmar
            // 
            button_Confirmar.Location = new Point(453, 448);
            button_Confirmar.Name = "button_Confirmar";
            button_Confirmar.Size = new Size(75, 23);
            button_Confirmar.TabIndex = 0;
            button_Confirmar.Text = "Aceptar";
            button_Confirmar.UseVisualStyleBackColor = true;
            button_Confirmar.Click += button_Confirmar_Click;
            // 
            // button_Volver
            // 
            button_Volver.Location = new Point(44, 448);
            button_Volver.Name = "button_Volver";
            button_Volver.Size = new Size(75, 23);
            button_Volver.TabIndex = 1;
            button_Volver.Text = "Cerrar";
            button_Volver.UseVisualStyleBackColor = true;
            button_Volver.Click += button_Volver_Click;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nombre.Location = new Point(139, 68);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(65, 19);
            label_Nombre.TabIndex = 2;
            label_Nombre.Text = "Nombre";
            // 
            // label_Codigo
            // 
            label_Codigo.AutoSize = true;
            label_Codigo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Codigo.Location = new Point(144, 151);
            label_Codigo.Name = "label_Codigo";
            label_Codigo.Size = new Size(56, 19);
            label_Codigo.TabIndex = 3;
            label_Codigo.Text = "Código";
            // 
            // label_Desc
            // 
            label_Desc.AutoSize = true;
            label_Desc.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Desc.Location = new Point(127, 231);
            label_Desc.Name = "label_Desc";
            label_Desc.Size = new Size(88, 19);
            label_Desc.TabIndex = 4;
            label_Desc.Text = "Descripción";
            // 
            // label_CupoMax
            // 
            label_CupoMax.AutoSize = true;
            label_CupoMax.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_CupoMax.Location = new Point(360, 107);
            label_CupoMax.Name = "label_CupoMax";
            label_CupoMax.Size = new Size(103, 19);
            label_CupoMax.TabIndex = 5;
            label_CupoMax.Text = "Cupo Máximo";
            // 
            // txtBox_CupoMax
            // 
            txtBox_CupoMax.Location = new Point(363, 143);
            txtBox_CupoMax.Name = "txtBox_CupoMax";
            txtBox_CupoMax.Size = new Size(100, 23);
            txtBox_CupoMax.TabIndex = 6;
            txtBox_CupoMax.TextChanged += txtBox_CupoMax_TextChanged;
            // 
            // txtBox_Nombre
            // 
            txtBox_Nombre.Location = new Point(124, 103);
            txtBox_Nombre.Name = "txtBox_Nombre";
            txtBox_Nombre.Size = new Size(100, 23);
            txtBox_Nombre.TabIndex = 7;
            txtBox_Nombre.TextChanged += txtBox_Nombre_TextChanged;
            // 
            // txtBox_Codigo
            // 
            txtBox_Codigo.Location = new Point(124, 184);
            txtBox_Codigo.Name = "txtBox_Codigo";
            txtBox_Codigo.Size = new Size(100, 23);
            txtBox_Codigo.TabIndex = 8;
            txtBox_Codigo.TextChanged += txtBox_Codigo_TextChanged;
            // 
            // txtBox_Desc
            // 
            txtBox_Desc.Location = new Point(124, 266);
            txtBox_Desc.Name = "txtBox_Desc";
            txtBox_Desc.Size = new Size(100, 23);
            txtBox_Desc.TabIndex = 9;
            txtBox_Desc.TextChanged += txtBox_Desc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 205);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 12;
            // 
            // label_Turno
            // 
            label_Turno.AutoSize = true;
            label_Turno.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Turno.Location = new Point(390, 191);
            label_Turno.Name = "label_Turno";
            label_Turno.Size = new Size(49, 19);
            label_Turno.TabIndex = 13;
            label_Turno.Text = "Turno";
            // 
            // label_Aula
            // 
            label_Aula.AutoSize = true;
            label_Aula.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Aula.Location = new Point(153, 315);
            label_Aula.Name = "label_Aula";
            label_Aula.Size = new Size(40, 19);
            label_Aula.TabIndex = 14;
            label_Aula.Text = "Aula";
            // 
            // txtBox_Aula
            // 
            txtBox_Aula.Location = new Point(124, 352);
            txtBox_Aula.Name = "txtBox_Aula";
            txtBox_Aula.Size = new Size(100, 23);
            txtBox_Aula.TabIndex = 15;
            txtBox_Aula.TextChanged += txtBox_Aula_TextChanged;
            // 
            // label_Dia
            // 
            label_Dia.AutoSize = true;
            label_Dia.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Dia.Location = new Point(398, 271);
            label_Dia.Name = "label_Dia";
            label_Dia.Size = new Size(31, 19);
            label_Dia.TabIndex = 16;
            label_Dia.Text = "Día";
            // 
            // comboBox_Dia
            // 
            comboBox_Dia.FormattingEnabled = true;
            comboBox_Dia.Location = new Point(363, 307);
            comboBox_Dia.Name = "comboBox_Dia";
            comboBox_Dia.Size = new Size(100, 23);
            comboBox_Dia.TabIndex = 17;
            comboBox_Dia.SelectedIndexChanged += comboBox_Dia_SelectedIndexChanged;
            // 
            // comboBox_Horarios
            // 
            comboBox_Horarios.FormattingEnabled = true;
            comboBox_Horarios.Location = new Point(363, 227);
            comboBox_Horarios.Name = "comboBox_Horarios";
            comboBox_Horarios.Size = new Size(100, 23);
            comboBox_Horarios.TabIndex = 18;
            comboBox_Horarios.SelectedIndexChanged += comboBox_Horarios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(234, 26);
            label2.Name = "label2";
            label2.Size = new Size(115, 26);
            label2.TabIndex = 19;
            label2.Text = "Editar Curso";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_UTN_Avellaneda_1;
            pictureBox1.Location = new Point(434, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 76);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(593, 522);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(comboBox_Horarios);
            Controls.Add(comboBox_Dia);
            Controls.Add(label_Dia);
            Controls.Add(txtBox_Aula);
            Controls.Add(label_Aula);
            Controls.Add(label_Turno);
            Controls.Add(label1);
            Controls.Add(txtBox_Desc);
            Controls.Add(txtBox_Codigo);
            Controls.Add(txtBox_Nombre);
            Controls.Add(txtBox_CupoMax);
            Controls.Add(label_CupoMax);
            Controls.Add(label_Desc);
            Controls.Add(label_Codigo);
            Controls.Add(label_Nombre);
            Controls.Add(button_Volver);
            Controls.Add(button_Confirmar);
            Name = "FormEditarCurso";
            Text = "Editar Curso";
            Load += FormEditarCurso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Confirmar;
        private Button button_Volver;
        private Label label_Nombre;
        private Label label_Codigo;
        private Label label_Desc;
        private Label label_CupoMax;
        private TextBox txtBox_CupoMax;
        private TextBox txtBox_Nombre;
        private TextBox txtBox_Codigo;
        private TextBox txtBox_Desc;
        private Label label1;
        private Label label_Turno;
        private Label label_Aula;
        private TextBox txtBox_Aula;
        private Label label_Dia;
        private ComboBox comboBox_Dia;
        private ComboBox comboBox_Horarios;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
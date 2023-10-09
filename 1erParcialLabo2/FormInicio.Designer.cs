namespace _1erParcialLabo2
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            button_LogAdmins = new Button();
            button_LogEstudiantes = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button_LogAdmins
            // 
            button_LogAdmins.Location = new Point(527, 265);
            button_LogAdmins.Name = "button_LogAdmins";
            button_LogAdmins.Size = new Size(202, 36);
            button_LogAdmins.TabIndex = 1;
            button_LogAdmins.Text = "Inicio sesión administrador";
            button_LogAdmins.UseVisualStyleBackColor = true;
            button_LogAdmins.Click += button_LogAdmins_Click;
            // 
            // button_LogEstudiantes
            // 
            button_LogEstudiantes.Location = new Point(44, 265);
            button_LogEstudiantes.Name = "button_LogEstudiantes";
            button_LogEstudiantes.Size = new Size(202, 36);
            button_LogEstudiantes.TabIndex = 0;
            button_LogEstudiantes.Text = "Inicio sesión Estudiante";
            button_LogEstudiantes.UseVisualStyleBackColor = true;
            button_LogEstudiantes.Click += button_LogEstudiantes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(642, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 78);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(83, 100);
            label1.Name = "label1";
            label1.Size = new Size(621, 29);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido al Sistema de Administración (SySacad) de la UTN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(267, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 212);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button_LogAdmins);
            Controls.Add(button_LogEstudiantes);
            ForeColor = SystemColors.ControlText;
            Name = "FormInicio";
            Text = "Inicio";
            Load += FormInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_LogAdmins;
        private Button button_LogEstudiantes;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
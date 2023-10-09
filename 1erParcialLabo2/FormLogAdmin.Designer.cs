namespace _1erParcialLabo2
{
    partial class FormLogAdmin
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
            txtBox_Usuario = new TextBox();
            label1 = new Label();
            label_pass = new Label();
            txtBox_Pass = new TextBox();
            button_IngresarAdmin = new Button();
            Button_Volver = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBox_Usuario
            // 
            txtBox_Usuario.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Usuario.ForeColor = SystemColors.Desktop;
            txtBox_Usuario.Location = new Point(42, 197);
            txtBox_Usuario.Name = "txtBox_Usuario";
            txtBox_Usuario.Size = new Size(130, 23);
            txtBox_Usuario.TabIndex = 0;
            txtBox_Usuario.TextChanged += txtBox_Usuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 159);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 1;
            label1.Text = "Mail";
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_pass.Location = new Point(46, 238);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(86, 19);
            label_pass.TabIndex = 2;
            label_pass.Text = "Contraseña";
            // 
            // txtBox_Pass
            // 
            txtBox_Pass.BackColor = SystemColors.GradientInactiveCaption;
            txtBox_Pass.ForeColor = SystemColors.Desktop;
            txtBox_Pass.Location = new Point(42, 273);
            txtBox_Pass.Name = "txtBox_Pass";
            txtBox_Pass.Size = new Size(130, 23);
            txtBox_Pass.TabIndex = 3;
            txtBox_Pass.TextChanged += txtBox_Pass_TextChanged;
            // 
            // button_IngresarAdmin
            // 
            button_IngresarAdmin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_IngresarAdmin.Location = new Point(307, 379);
            button_IngresarAdmin.Name = "button_IngresarAdmin";
            button_IngresarAdmin.Size = new Size(75, 23);
            button_IngresarAdmin.TabIndex = 4;
            button_IngresarAdmin.Text = "Ingresar";
            button_IngresarAdmin.UseVisualStyleBackColor = true;
            button_IngresarAdmin.Click += button_IngresarAdmin_Click;
            // 
            // Button_Volver
            // 
            Button_Volver.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Volver.Location = new Point(42, 379);
            Button_Volver.Name = "Button_Volver";
            Button_Volver.Size = new Size(75, 23);
            Button_Volver.TabIndex = 5;
            Button_Volver.Text = "Volver";
            Button_Volver.UseVisualStyleBackColor = true;
            Button_Volver.Click += Button_Volver_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Location = new Point(326, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(277, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 19);
            label2.TabIndex = 7;
            label2.Text = "Código Administrador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 84);
            label3.Name = "label3";
            label3.Size = new Size(258, 19);
            label3.TabIndex = 8;
            label3.Text = "Complete los campos para continuar";
            // 
            // FormLogAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(448, 487);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Button_Volver);
            Controls.Add(button_IngresarAdmin);
            Controls.Add(txtBox_Pass);
            Controls.Add(label_pass);
            Controls.Add(label1);
            Controls.Add(txtBox_Usuario);
            Name = "FormLogAdmin";
            Text = "Ingreso Administrador";
            Load += FormLogAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_Usuario;
        private Label label1;
        private Label label_pass;
        private TextBox txtBox_Pass;
        private Button button_IngresarAdmin;
        private Button Button_Volver;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}
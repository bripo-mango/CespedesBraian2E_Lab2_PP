namespace _1erParcialLabo2
{
    partial class FormLogEstudiante
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
            txtBox_Mail = new TextBox();
            txtBox_Pass = new TextBox();
            label1 = new Label();
            label_Pass = new Label();
            button_Volver = new Button();
            button_Ingresar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBox_Mail
            // 
            txtBox_Mail.Location = new Point(116, 119);
            txtBox_Mail.Name = "txtBox_Mail";
            txtBox_Mail.Size = new Size(100, 23);
            txtBox_Mail.TabIndex = 0;
            txtBox_Mail.TextChanged += txtBox_Legajo_TextChanged_1;
            // 
            // txtBox_Pass
            // 
            txtBox_Pass.Location = new Point(116, 204);
            txtBox_Pass.Name = "txtBox_Pass";
            txtBox_Pass.Size = new Size(100, 23);
            txtBox_Pass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 88);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 2;
            label1.Text = "Mail";
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Pass.Location = new Point(123, 167);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(86, 19);
            label_Pass.TabIndex = 3;
            label_Pass.Text = "Contraseña";
            // 
            // button_Volver
            // 
            button_Volver.Location = new Point(32, 283);
            button_Volver.Name = "button_Volver";
            button_Volver.Size = new Size(75, 23);
            button_Volver.TabIndex = 4;
            button_Volver.Text = "Volver";
            button_Volver.UseVisualStyleBackColor = true;
            button_Volver.Click += button_Volver_Click;
            // 
            // button_Ingresar
            // 
            button_Ingresar.Location = new Point(262, 283);
            button_Ingresar.Name = "button_Ingresar";
            button_Ingresar.Size = new Size(75, 23);
            button_Ingresar.TabIndex = 5;
            button_Ingresar.Text = "Ingresar";
            button_Ingresar.UseVisualStyleBackColor = true;
            button_Ingresar.Click += button_Ingresar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(340, 26);
            label2.TabIndex = 6;
            label2.Text = "Ingrese los campos de inicio de sesión";
            // 
            // FormLogEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(379, 368);
            Controls.Add(label2);
            Controls.Add(button_Ingresar);
            Controls.Add(button_Volver);
            Controls.Add(label_Pass);
            Controls.Add(label1);
            Controls.Add(txtBox_Pass);
            Controls.Add(txtBox_Mail);
            Name = "FormLogEstudiante";
            Text = "Ingreso Estudiante";
            Load += FormLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_Mail;
        private TextBox txtBox_Pass;
        private Label label1;
        private Label label_Pass;
        private Button button_Volver;
        private Button button_Ingresar;
        private Label label2;
    }
}
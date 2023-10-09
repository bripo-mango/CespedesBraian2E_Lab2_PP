namespace _1erParcialLabo2
{
    partial class FormEstudianteLogeado
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
            components = new System.ComponentModel.Container();
            dataGridView_CursosEstudiante = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoDisponibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baseDatosCursosBindingSource = new BindingSource(components);
            button_InscribirseCursos = new Button();
            button_Horarios = new Button();
            button_RealizarPagos = new Button();
            button_Salir = new Button();
            label_BienvenidaEstudiante = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CursosEstudiante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_CursosEstudiante
            // 
            dataGridView_CursosEstudiante.AutoGenerateColumns = false;
            dataGridView_CursosEstudiante.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView_CursosEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CursosEstudiante.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, cupoDisponibleDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn });
            dataGridView_CursosEstudiante.DataMember = "Cursos";
            dataGridView_CursosEstudiante.DataSource = baseDatosCursosBindingSource;
            dataGridView_CursosEstudiante.Location = new Point(32, 85);
            dataGridView_CursosEstudiante.Name = "dataGridView_CursosEstudiante";
            dataGridView_CursosEstudiante.RowTemplate.Height = 25;
            dataGridView_CursosEstudiante.Size = new Size(446, 277);
            dataGridView_CursosEstudiante.TabIndex = 0;
            dataGridView_CursosEstudiante.CellContentClick += dataGridView_CursosEstudiante_CellContentClick;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoMaximoDataGridViewTextBoxColumn
            // 
            cupoMaximoDataGridViewTextBoxColumn.DataPropertyName = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.HeaderText = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.Name = "cupoMaximoDataGridViewTextBoxColumn";
            cupoMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDisponibleDataGridViewTextBoxColumn
            // 
            cupoDisponibleDataGridViewTextBoxColumn.DataPropertyName = "CupoDisponible";
            cupoDisponibleDataGridViewTextBoxColumn.HeaderText = "CupoDisponible";
            cupoDisponibleDataGridViewTextBoxColumn.Name = "cupoDisponibleDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            aulaDataGridViewTextBoxColumn.DataPropertyName = "Aula";
            aulaDataGridViewTextBoxColumn.HeaderText = "Aula";
            aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            aulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseDatosCursosBindingSource
            // 
            baseDatosCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.BaseDatosCursos);
            // 
            // button_InscribirseCursos
            // 
            button_InscribirseCursos.Location = new Point(569, 143);
            button_InscribirseCursos.Name = "button_InscribirseCursos";
            button_InscribirseCursos.Size = new Size(135, 29);
            button_InscribirseCursos.TabIndex = 1;
            button_InscribirseCursos.Text = "Inscribirse a cursos";
            button_InscribirseCursos.UseVisualStyleBackColor = true;
            button_InscribirseCursos.Click += button_InscribirseCursos_Click;
            // 
            // button_Horarios
            // 
            button_Horarios.Location = new Point(569, 222);
            button_Horarios.Name = "button_Horarios";
            button_Horarios.Size = new Size(135, 23);
            button_Horarios.TabIndex = 2;
            button_Horarios.Text = "Consultar Horarios";
            button_Horarios.UseVisualStyleBackColor = true;
            button_Horarios.Click += button_Horarios_Click;
            // 
            // button_RealizarPagos
            // 
            button_RealizarPagos.Location = new Point(569, 299);
            button_RealizarPagos.Name = "button_RealizarPagos";
            button_RealizarPagos.Size = new Size(135, 23);
            button_RealizarPagos.TabIndex = 3;
            button_RealizarPagos.Text = "Realizar Pagos";
            button_RealizarPagos.UseVisualStyleBackColor = true;
            button_RealizarPagos.Click += button_RealizarPagos_Click;
            // 
            // button_Salir
            // 
            button_Salir.Location = new Point(32, 399);
            button_Salir.Name = "button_Salir";
            button_Salir.Size = new Size(75, 23);
            button_Salir.TabIndex = 4;
            button_Salir.Text = "Salir";
            button_Salir.UseVisualStyleBackColor = true;
            button_Salir.Click += button_Salir_Click;
            // 
            // label_BienvenidaEstudiante
            // 
            label_BienvenidaEstudiante.AutoSize = true;
            label_BienvenidaEstudiante.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_BienvenidaEstudiante.Location = new Point(354, 22);
            label_BienvenidaEstudiante.Name = "label_BienvenidaEstudiante";
            label_BienvenidaEstudiante.Size = new Size(0, 29);
            label_BienvenidaEstudiante.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_UTN_Avellaneda_1;
            pictureBox1.Location = new Point(641, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormEstudianteLogeado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label_BienvenidaEstudiante);
            Controls.Add(button_Salir);
            Controls.Add(button_RealizarPagos);
            Controls.Add(button_Horarios);
            Controls.Add(button_InscribirseCursos);
            Controls.Add(dataGridView_CursosEstudiante);
            Name = "FormEstudianteLogeado";
            Text = "Menu Estudiante";
            Load += FormEstudianteLogeado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_CursosEstudiante).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_CursosEstudiante;
        private BindingSource baseDatosCursosBindingSource;
        private Button button_InscribirseCursos;
        private Button button_Horarios;
        private Button button_RealizarPagos;
        private Button button_Salir;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private Label label_BienvenidaEstudiante;
        private PictureBox pictureBox1;
    }
}
namespace _1erParcialLabo2
{
    partial class FormCurso
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
            dataGrid_Cursos = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoMaximoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupoDisponibleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baseDatosCursosBindingSource = new BindingSource(components);
            button_AgregarCurso = new Button();
            button_EditarGrupo = new Button();
            button_EliminarCurso = new Button();
            button_Salir = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Cursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_Cursos
            // 
            dataGrid_Cursos.AutoGenerateColumns = false;
            dataGrid_Cursos.BackgroundColor = SystemColors.ActiveCaption;
            dataGrid_Cursos.BorderStyle = BorderStyle.Fixed3D;
            dataGrid_Cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Cursos.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn, cupoMaximoDataGridViewTextBoxColumn, cupoDisponibleDataGridViewTextBoxColumn, turnoDataGridViewTextBoxColumn, aulaDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn });
            dataGrid_Cursos.DataMember = "Cursos";
            dataGrid_Cursos.DataSource = baseDatosCursosBindingSource;
            dataGrid_Cursos.Location = new Point(12, 78);
            dataGrid_Cursos.Name = "dataGrid_Cursos";
            dataGrid_Cursos.RowTemplate.Height = 25;
            dataGrid_Cursos.Size = new Size(626, 287);
            dataGrid_Cursos.TabIndex = 0;
            dataGrid_Cursos.CellContentClick += dataGrid_Cursos_CellContentClick;
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
            codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            descripcionDataGridViewTextBoxColumn.Width = 120;
            // 
            // cupoMaximoDataGridViewTextBoxColumn
            // 
            cupoMaximoDataGridViewTextBoxColumn.DataPropertyName = "CupoMaximo";
            cupoMaximoDataGridViewTextBoxColumn.FillWeight = 60F;
            cupoMaximoDataGridViewTextBoxColumn.HeaderText = "Cupo Máximo";
            cupoMaximoDataGridViewTextBoxColumn.Name = "cupoMaximoDataGridViewTextBoxColumn";
            cupoMaximoDataGridViewTextBoxColumn.ReadOnly = true;
            cupoMaximoDataGridViewTextBoxColumn.Width = 70;
            // 
            // cupoDisponibleDataGridViewTextBoxColumn
            // 
            cupoDisponibleDataGridViewTextBoxColumn.DataPropertyName = "CupoDisponible";
            cupoDisponibleDataGridViewTextBoxColumn.HeaderText = "Cupo Disponible";
            cupoDisponibleDataGridViewTextBoxColumn.Name = "cupoDisponibleDataGridViewTextBoxColumn";
            cupoDisponibleDataGridViewTextBoxColumn.Width = 70;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            turnoDataGridViewTextBoxColumn.ReadOnly = true;
            turnoDataGridViewTextBoxColumn.Width = 60;
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            aulaDataGridViewTextBoxColumn.DataPropertyName = "Aula";
            aulaDataGridViewTextBoxColumn.HeaderText = "Aula";
            aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            aulaDataGridViewTextBoxColumn.ReadOnly = true;
            aulaDataGridViewTextBoxColumn.Width = 50;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            diaDataGridViewTextBoxColumn.ReadOnly = true;
            diaDataGridViewTextBoxColumn.Width = 70;
            // 
            // baseDatosCursosBindingSource
            // 
            baseDatosCursosBindingSource.DataSource = typeof(Libreria_Clases_TP_SYSACAD.BaseDatosCursos);
            // 
            // button_AgregarCurso
            // 
            button_AgregarCurso.Location = new Point(720, 115);
            button_AgregarCurso.Name = "button_AgregarCurso";
            button_AgregarCurso.Size = new Size(102, 30);
            button_AgregarCurso.TabIndex = 1;
            button_AgregarCurso.Text = "Agregar Curso";
            button_AgregarCurso.UseVisualStyleBackColor = true;
            button_AgregarCurso.Click += button_AgregarCurso_Click;
            // 
            // button_EditarGrupo
            // 
            button_EditarGrupo.Location = new Point(720, 194);
            button_EditarGrupo.Name = "button_EditarGrupo";
            button_EditarGrupo.Size = new Size(102, 30);
            button_EditarGrupo.TabIndex = 2;
            button_EditarGrupo.Text = "Editar Curso";
            button_EditarGrupo.UseVisualStyleBackColor = true;
            button_EditarGrupo.Click += button_EditarGrupo_Click;
            // 
            // button_EliminarCurso
            // 
            button_EliminarCurso.Location = new Point(720, 273);
            button_EliminarCurso.Name = "button_EliminarCurso";
            button_EliminarCurso.Size = new Size(102, 30);
            button_EliminarCurso.TabIndex = 3;
            button_EliminarCurso.Text = "Eliminar Curso";
            button_EliminarCurso.UseVisualStyleBackColor = true;
            button_EliminarCurso.Click += button_EliminarCurso_Click;
            // 
            // button_Salir
            // 
            button_Salir.Location = new Point(12, 399);
            button_Salir.Name = "button_Salir";
            button_Salir.Size = new Size(75, 23);
            button_Salir.TabIndex = 4;
            button_Salir.Text = "Salir";
            button_Salir.UseVisualStyleBackColor = true;
            button_Salir.Click += button_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 22);
            label1.Name = "label1";
            label1.Size = new Size(516, 29);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido al sistema de administración de cursos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_UTN_Avellaneda_1;
            pictureBox1.Location = new Point(729, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 77);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(889, 458);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_Salir);
            Controls.Add(button_EliminarCurso);
            Controls.Add(button_EditarGrupo);
            Controls.Add(button_AgregarCurso);
            Controls.Add(dataGrid_Cursos);
            Name = "FormCurso";
            Text = "Cursos";
            Load += FormCurso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Cursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseDatosCursosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_Cursos;
        private BindingSource baseDatosCursosBindingSource;
        private Button button_AgregarCurso;
        private Button button_EditarGrupo;
        private Button button_EliminarCurso;
        private Button button_Salir;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoMaximoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupoDisponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
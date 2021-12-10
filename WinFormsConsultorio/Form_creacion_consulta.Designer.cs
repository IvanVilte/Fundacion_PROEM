
namespace WinFormsConsultorio {
    partial class Form_creacion_consulta {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_creacion_consulta));
            this.lbl_consulta = new System.Windows.Forms.Label();
            this.lbl_paciente = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.label_dni = new System.Windows.Forms.Label();
            this.lbl_cobertura = new System.Windows.Forms.Label();
            this.label_cobertura = new System.Windows.Forms.Label();
            this.lbl_medico = new System.Windows.Forms.Label();
            this.data_GV_medicos_Disponibles = new System.Windows.Forms.DataGridView();
            this.lbl_nombre_doctor = new System.Windows.Forms.Label();
            this.txt_nombre_medico = new System.Windows.Forms.TextBox();
            this.lbl_apellido_medico = new System.Windows.Forms.Label();
            this.txt_apellido_medico = new System.Windows.Forms.TextBox();
            this.combo_box_especialidad = new System.Windows.Forms.ComboBox();
            this.btn_crear_consulta = new System.Windows.Forms.Button();
            this.btn_buscar_medicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_GV_medicos_Disponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_consulta
            // 
            this.lbl_consulta.AutoSize = true;
            this.lbl_consulta.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_consulta.Location = new System.Drawing.Point(9, 5);
            this.lbl_consulta.Name = "lbl_consulta";
            this.lbl_consulta.Size = new System.Drawing.Size(121, 37);
            this.lbl_consulta.TabIndex = 0;
            this.lbl_consulta.Text = "Consulta";
            // 
            // lbl_paciente
            // 
            this.lbl_paciente.AutoSize = true;
            this.lbl_paciente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_paciente.Location = new System.Drawing.Point(12, 42);
            this.lbl_paciente.Name = "lbl_paciente";
            this.lbl_paciente.Size = new System.Drawing.Size(84, 28);
            this.lbl_paciente.TabIndex = 1;
            this.lbl_paciente.Text = "Paciente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(31, 80);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 15);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre: ";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nombre.Location = new System.Drawing.Point(92, 80);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(0, 15);
            this.label_nombre.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(155, 80);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(215, 80);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(0, 15);
            this.label_apellido.TabIndex = 5;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(291, 80);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 6;
            this.lbl_dni.Text = "DNI:";
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Location = new System.Drawing.Point(328, 80);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(0, 15);
            this.label_dni.TabIndex = 7;
            // 
            // lbl_cobertura
            // 
            this.lbl_cobertura.AutoSize = true;
            this.lbl_cobertura.Location = new System.Drawing.Point(397, 80);
            this.lbl_cobertura.Name = "lbl_cobertura";
            this.lbl_cobertura.Size = new System.Drawing.Size(89, 15);
            this.lbl_cobertura.TabIndex = 8;
            this.lbl_cobertura.Text = "Tipo Cobertura:";
            // 
            // label_cobertura
            // 
            this.label_cobertura.AutoSize = true;
            this.label_cobertura.Location = new System.Drawing.Point(493, 79);
            this.label_cobertura.Name = "label_cobertura";
            this.label_cobertura.Size = new System.Drawing.Size(0, 15);
            this.label_cobertura.TabIndex = 9;
            // 
            // lbl_medico
            // 
            this.lbl_medico.AutoSize = true;
            this.lbl_medico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_medico.Location = new System.Drawing.Point(12, 138);
            this.lbl_medico.Name = "lbl_medico";
            this.lbl_medico.Size = new System.Drawing.Size(78, 28);
            this.lbl_medico.TabIndex = 10;
            this.lbl_medico.Text = "Medico";
            // 
            // data_GV_medicos_Disponibles
            // 
            this.data_GV_medicos_Disponibles.AllowUserToAddRows = false;
            this.data_GV_medicos_Disponibles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_GV_medicos_Disponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_GV_medicos_Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_GV_medicos_Disponibles.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_GV_medicos_Disponibles.Location = new System.Drawing.Point(12, 249);
            this.data_GV_medicos_Disponibles.Name = "data_GV_medicos_Disponibles";
            this.data_GV_medicos_Disponibles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_GV_medicos_Disponibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_GV_medicos_Disponibles.RowTemplate.Height = 25;
            this.data_GV_medicos_Disponibles.Size = new System.Drawing.Size(375, 150);
            this.data_GV_medicos_Disponibles.TabIndex = 11;
            // 
            // lbl_nombre_doctor
            // 
            this.lbl_nombre_doctor.AutoSize = true;
            this.lbl_nombre_doctor.Location = new System.Drawing.Point(12, 192);
            this.lbl_nombre_doctor.Name = "lbl_nombre_doctor";
            this.lbl_nombre_doctor.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre_doctor.TabIndex = 12;
            this.lbl_nombre_doctor.Text = "Nombre:";
            // 
            // txt_nombre_medico
            // 
            this.txt_nombre_medico.Location = new System.Drawing.Point(72, 189);
            this.txt_nombre_medico.Name = "txt_nombre_medico";
            this.txt_nombre_medico.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre_medico.TabIndex = 13;
            // 
            // lbl_apellido_medico
            // 
            this.lbl_apellido_medico.AutoSize = true;
            this.lbl_apellido_medico.Location = new System.Drawing.Point(196, 191);
            this.lbl_apellido_medico.Name = "lbl_apellido_medico";
            this.lbl_apellido_medico.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido_medico.TabIndex = 14;
            this.lbl_apellido_medico.Text = "Apellido:";
            // 
            // txt_apellido_medico
            // 
            this.txt_apellido_medico.Location = new System.Drawing.Point(256, 188);
            this.txt_apellido_medico.Name = "txt_apellido_medico";
            this.txt_apellido_medico.Size = new System.Drawing.Size(100, 23);
            this.txt_apellido_medico.TabIndex = 15;
            // 
            // combo_box_especialidad
            // 
            this.combo_box_especialidad.FormattingEnabled = true;
            this.combo_box_especialidad.Items.AddRange(new object[] {
            "Pediatria",
            "Radiologia",
            "Traumatologia",
            "Psiquiatria",
            "Infectologia",
            "Cardiologia",
            "Endicronologia",
            "Neurologia"});
            this.combo_box_especialidad.Location = new System.Drawing.Point(387, 188);
            this.combo_box_especialidad.Name = "combo_box_especialidad";
            this.combo_box_especialidad.Size = new System.Drawing.Size(121, 23);
            this.combo_box_especialidad.TabIndex = 16;
            // 
            // btn_crear_consulta
            // 
            this.btn_crear_consulta.Location = new System.Drawing.Point(440, 359);
            this.btn_crear_consulta.Name = "btn_crear_consulta";
            this.btn_crear_consulta.Size = new System.Drawing.Size(149, 37);
            this.btn_crear_consulta.TabIndex = 17;
            this.btn_crear_consulta.Text = "Crear";
            this.btn_crear_consulta.UseVisualStyleBackColor = true;
            this.btn_crear_consulta.Click += new System.EventHandler(this.btn_crear_consulta_Click);
            // 
            // btn_buscar_medicos
            // 
            this.btn_buscar_medicos.Location = new System.Drawing.Point(548, 188);
            this.btn_buscar_medicos.Name = "btn_buscar_medicos";
            this.btn_buscar_medicos.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_medicos.TabIndex = 18;
            this.btn_buscar_medicos.Text = "Buscar";
            this.btn_buscar_medicos.UseVisualStyleBackColor = true;
            this.btn_buscar_medicos.Click += new System.EventHandler(this.btn_buscar_medicos_Click);
            // 
            // Form_creacion_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 408);
            this.Controls.Add(this.btn_buscar_medicos);
            this.Controls.Add(this.btn_crear_consulta);
            this.Controls.Add(this.combo_box_especialidad);
            this.Controls.Add(this.txt_apellido_medico);
            this.Controls.Add(this.lbl_apellido_medico);
            this.Controls.Add(this.txt_nombre_medico);
            this.Controls.Add(this.lbl_nombre_doctor);
            this.Controls.Add(this.data_GV_medicos_Disponibles);
            this.Controls.Add(this.lbl_medico);
            this.Controls.Add(this.label_cobertura);
            this.Controls.Add(this.lbl_cobertura);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_paciente);
            this.Controls.Add(this.lbl_consulta);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_creacion_consulta";
            this.Text = "Crear Consulta";
            this.Load += new System.EventHandler(this.Form_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GV_medicos_Disponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_consulta;
        private System.Windows.Forms.Label lbl_paciente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label lbl_cobertura;
        private System.Windows.Forms.Label label_cobertura;
        private System.Windows.Forms.Label lbl_medico;
        private System.Windows.Forms.DataGridView data_GV_medicos_Disponibles;
        private System.Windows.Forms.Label lbl_nombre_doctor;
        private System.Windows.Forms.TextBox txt_nombre_medico;
        private System.Windows.Forms.Label lbl_apellido_medico;
        private System.Windows.Forms.TextBox txt_apellido_medico;
        private System.Windows.Forms.ComboBox combo_box_especialidad;
        private System.Windows.Forms.Button btn_crear_consulta;
        private System.Windows.Forms.Button btn_buscar_medicos;
    }
}
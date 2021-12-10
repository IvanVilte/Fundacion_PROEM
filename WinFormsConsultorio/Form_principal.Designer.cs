
namespace WinFormsConsultorio {
    partial class Form_principal {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.btn_pacientes = new System.Windows.Forms.Button();
            this.label_paciente = new System.Windows.Forms.Label();
            this.lbl_medicos = new System.Windows.Forms.Label();
            this.btn_mostrar_medicos = new System.Windows.Forms.Button();
            this.lbl_consultas = new System.Windows.Forms.Label();
            this.btn_mostrar_consultas = new System.Windows.Forms.Button();
            this.lbl_estadisticas = new System.Windows.Forms.Label();
            this.btn_mostrar_estadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.Location = new System.Drawing.Point(44, 56);
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.Size = new System.Drawing.Size(109, 30);
            this.btn_pacientes.TabIndex = 0;
            this.btn_pacientes.Text = "Mostrar Pacientes";
            this.btn_pacientes.UseVisualStyleBackColor = true;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_pacientes_Click);
            // 
            // label_paciente
            // 
            this.label_paciente.AutoSize = true;
            this.label_paciente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_paciente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_paciente.Location = new System.Drawing.Point(13, 13);
            this.label_paciente.Name = "label_paciente";
            this.label_paciente.Size = new System.Drawing.Size(102, 28);
            this.label_paciente.TabIndex = 1;
            this.label_paciente.Text = "Pacientes";
            // 
            // lbl_medicos
            // 
            this.lbl_medicos.AutoSize = true;
            this.lbl_medicos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_medicos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_medicos.Location = new System.Drawing.Point(13, 123);
            this.lbl_medicos.Name = "lbl_medicos";
            this.lbl_medicos.Size = new System.Drawing.Size(91, 28);
            this.lbl_medicos.TabIndex = 2;
            this.lbl_medicos.Text = "Medicos";
            // 
            // btn_mostrar_medicos
            // 
            this.btn_mostrar_medicos.Location = new System.Drawing.Point(44, 164);
            this.btn_mostrar_medicos.Name = "btn_mostrar_medicos";
            this.btn_mostrar_medicos.Size = new System.Drawing.Size(109, 28);
            this.btn_mostrar_medicos.TabIndex = 3;
            this.btn_mostrar_medicos.Text = "Mostrar Medicos";
            this.btn_mostrar_medicos.UseVisualStyleBackColor = true;
            this.btn_mostrar_medicos.Click += new System.EventHandler(this.btn_mostrar_medicos_Click);
            // 
            // lbl_consultas
            // 
            this.lbl_consultas.AutoSize = true;
            this.lbl_consultas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_consultas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_consultas.Location = new System.Drawing.Point(13, 236);
            this.lbl_consultas.Name = "lbl_consultas";
            this.lbl_consultas.Size = new System.Drawing.Size(103, 28);
            this.lbl_consultas.TabIndex = 4;
            this.lbl_consultas.Text = "Consultas";
            // 
            // btn_mostrar_consultas
            // 
            this.btn_mostrar_consultas.Location = new System.Drawing.Point(44, 278);
            this.btn_mostrar_consultas.Name = "btn_mostrar_consultas";
            this.btn_mostrar_consultas.Size = new System.Drawing.Size(120, 26);
            this.btn_mostrar_consultas.TabIndex = 5;
            this.btn_mostrar_consultas.Text = "Mostrar Consultas";
            this.btn_mostrar_consultas.UseVisualStyleBackColor = true;
            this.btn_mostrar_consultas.Click += new System.EventHandler(this.btn_mostrar_consultas_Click);
            // 
            // lbl_estadisticas
            // 
            this.lbl_estadisticas.AutoSize = true;
            this.lbl_estadisticas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_estadisticas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadisticas.Location = new System.Drawing.Point(13, 330);
            this.lbl_estadisticas.Name = "lbl_estadisticas";
            this.lbl_estadisticas.Size = new System.Drawing.Size(122, 28);
            this.lbl_estadisticas.TabIndex = 6;
            this.lbl_estadisticas.Text = "Estadisticas";
            // 
            // btn_mostrar_estadisticas
            // 
            this.btn_mostrar_estadisticas.Location = new System.Drawing.Point(44, 374);
            this.btn_mostrar_estadisticas.Name = "btn_mostrar_estadisticas";
            this.btn_mostrar_estadisticas.Size = new System.Drawing.Size(120, 28);
            this.btn_mostrar_estadisticas.TabIndex = 7;
            this.btn_mostrar_estadisticas.Text = "Mostrar Estadisticas";
            this.btn_mostrar_estadisticas.UseVisualStyleBackColor = true;
            this.btn_mostrar_estadisticas.Click += new System.EventHandler(this.btn_mostrar_estadisticas_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mostrar_estadisticas);
            this.Controls.Add(this.lbl_estadisticas);
            this.Controls.Add(this.btn_mostrar_consultas);
            this.Controls.Add(this.lbl_consultas);
            this.Controls.Add(this.btn_mostrar_medicos);
            this.Controls.Add(this.lbl_medicos);
            this.Controls.Add(this.label_paciente);
            this.Controls.Add(this.btn_pacientes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_principal";
            this.Text = "Clinica PROEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pacientes;
        private System.Windows.Forms.Label label_paciente;
        private System.Windows.Forms.Label lbl_medicos;
        private System.Windows.Forms.Button btn_mostrar_medicos;
        private System.Windows.Forms.Label lbl_consultas;
        private System.Windows.Forms.Button btn_mostrar_consultas;
        private System.Windows.Forms.Label lbl_estadisticas;
        private System.Windows.Forms.Button btn_mostrar_estadisticas;
    }
}


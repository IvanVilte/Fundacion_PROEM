
namespace WinFormsConsultorio {
    partial class Form_pacientes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pacientes));
            this.dataGV_pacientes = new System.Windows.Forms.DataGridView();
            this.btn_asignar_medico = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_pacientes
            // 
            this.dataGV_pacientes.AllowUserToAddRows = false;
            this.dataGV_pacientes.AllowUserToDeleteRows = false;
            this.dataGV_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_pacientes.Location = new System.Drawing.Point(13, 27);
            this.dataGV_pacientes.Name = "dataGV_pacientes";
            this.dataGV_pacientes.ReadOnly = true;
            this.dataGV_pacientes.RowTemplate.Height = 25;
            this.dataGV_pacientes.Size = new System.Drawing.Size(684, 275);
            this.dataGV_pacientes.TabIndex = 1;
            this.dataGV_pacientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_pacientes_CellContentDoubleClick);
            // 
            // btn_asignar_medico
            // 
            this.btn_asignar_medico.Location = new System.Drawing.Point(13, 324);
            this.btn_asignar_medico.Name = "btn_asignar_medico";
            this.btn_asignar_medico.Size = new System.Drawing.Size(99, 33);
            this.btn_asignar_medico.TabIndex = 2;
            this.btn_asignar_medico.Text = "Asignar Medico";
            this.btn_asignar_medico.UseVisualStyleBackColor = true;
            this.btn_asignar_medico.Click += new System.EventHandler(this.btn_asignar_medico_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(118, 324);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(113, 33);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Nuevo Paciente";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_pacientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Se asigna medico segun el orden de llagada";
            // 
            // Form_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_asignar_medico);
            this.Controls.Add(this.dataGV_pacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Form_pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV_pacientes;
        private System.Windows.Forms.Button btn_asignar_medico;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
    }
}
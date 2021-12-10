
namespace WinFormsConsultorio {
    partial class Form_consultas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_consultas));
            this.label1 = new System.Windows.Forms.Label();
            this.data_GV_consultas = new System.Windows.Forms.DataGridView();
            this.lbl_estado_consulta = new System.Windows.Forms.Label();
            this.combo_box_estados = new System.Windows.Forms.ComboBox();
            this.btn_estado = new System.Windows.Forms.Button();
            this.lbl_informativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_GV_consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultas";
            // 
            // data_GV_consultas
            // 
            this.data_GV_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GV_consultas.Location = new System.Drawing.Point(13, 53);
            this.data_GV_consultas.Name = "data_GV_consultas";
            this.data_GV_consultas.RowTemplate.Height = 25;
            this.data_GV_consultas.Size = new System.Drawing.Size(511, 150);
            this.data_GV_consultas.TabIndex = 3;
            this.data_GV_consultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GV_consultas_CellContentClick);
            // 
            // lbl_estado_consulta
            // 
            this.lbl_estado_consulta.AutoSize = true;
            this.lbl_estado_consulta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_estado_consulta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estado_consulta.Location = new System.Drawing.Point(13, 226);
            this.lbl_estado_consulta.Name = "lbl_estado_consulta";
            this.lbl_estado_consulta.Size = new System.Drawing.Size(313, 28);
            this.lbl_estado_consulta.TabIndex = 4;
            this.lbl_estado_consulta.Text = "Modificar Estado de la Consulta";
            this.lbl_estado_consulta.Visible = false;
            // 
            // combo_box_estados
            // 
            this.combo_box_estados.FormattingEnabled = true;
            this.combo_box_estados.Items.AddRange(new object[] {
            "En Curso",
            "Finalizado"});
            this.combo_box_estados.Location = new System.Drawing.Point(13, 266);
            this.combo_box_estados.Name = "combo_box_estados";
            this.combo_box_estados.Size = new System.Drawing.Size(121, 23);
            this.combo_box_estados.TabIndex = 7;
            this.combo_box_estados.Visible = false;
            // 
            // btn_estado
            // 
            this.btn_estado.Location = new System.Drawing.Point(192, 266);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(75, 23);
            this.btn_estado.TabIndex = 8;
            this.btn_estado.Text = "Aceptar";
            this.btn_estado.UseVisualStyleBackColor = true;
            this.btn_estado.Visible = false;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // lbl_informativo
            // 
            this.lbl_informativo.AutoSize = true;
            this.lbl_informativo.Location = new System.Drawing.Point(530, 53);
            this.lbl_informativo.Name = "lbl_informativo";
            this.lbl_informativo.Size = new System.Drawing.Size(258, 15);
            this.lbl_informativo.TabIndex = 9;
            this.lbl_informativo.Text = "*Hacer Click en la consulta que desea modificar";
            this.lbl_informativo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.lbl_informativo);
            this.Controls.Add(this.btn_estado);
            this.Controls.Add(this.combo_box_estados);
            this.Controls.Add(this.lbl_estado_consulta);
            this.Controls.Add(this.data_GV_consultas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.data_GV_consultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_GV_consultas;
        private System.Windows.Forms.Label lbl_estado_consulta;
        private System.Windows.Forms.ComboBox combo_box_estados;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Label lbl_informativo;
    }
}

namespace WinFormsConsultorio {
    partial class Form_medicos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_medicos));
            this.dataGV_medicos = new System.Windows.Forms.DataGridView();
            this.lbl_medicos = new System.Windows.Forms.Label();
            this.check_medicos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_medicos
            // 
            this.dataGV_medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_medicos.Location = new System.Drawing.Point(37, 72);
            this.dataGV_medicos.Name = "dataGV_medicos";
            this.dataGV_medicos.RowTemplate.Height = 25;
            this.dataGV_medicos.Size = new System.Drawing.Size(586, 255);
            this.dataGV_medicos.TabIndex = 0;
            // 
            // lbl_medicos
            // 
            this.lbl_medicos.AutoSize = true;
            this.lbl_medicos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_medicos.Location = new System.Drawing.Point(13, 13);
            this.lbl_medicos.Name = "lbl_medicos";
            this.lbl_medicos.Size = new System.Drawing.Size(86, 28);
            this.lbl_medicos.TabIndex = 1;
            this.lbl_medicos.Text = "Medicos";
            // 
            // check_medicos
            // 
            this.check_medicos.AutoSize = true;
            this.check_medicos.Location = new System.Drawing.Point(664, 40);
            this.check_medicos.Name = "check_medicos";
            this.check_medicos.Size = new System.Drawing.Size(135, 19);
            this.check_medicos.TabIndex = 2;
            this.check_medicos.Text = "Medicos Disponibles";
            this.check_medicos.UseVisualStyleBackColor = true;
            this.check_medicos.CheckedChanged += new System.EventHandler(this.check_medicos_CheckedChanged);
            // 
            // Form_medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_medicos);
            this.Controls.Add(this.lbl_medicos);
            this.Controls.Add(this.dataGV_medicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_medicos";
            this.Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_medicos;
        private System.Windows.Forms.Label lbl_medicos;
        private System.Windows.Forms.CheckBox check_medicos;
    }
}
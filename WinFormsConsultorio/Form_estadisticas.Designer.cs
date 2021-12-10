
namespace WinFormsConsultorio {
    partial class Form_estadisticas {
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
            this.data_gv_estadisticas = new System.Windows.Forms.DataGridView();
            this.checkList_estadisticas = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_estadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // data_gv_estadisticas
            // 
            this.data_gv_estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv_estadisticas.Location = new System.Drawing.Point(13, 13);
            this.data_gv_estadisticas.Name = "data_gv_estadisticas";
            this.data_gv_estadisticas.RowTemplate.Height = 25;
            this.data_gv_estadisticas.Size = new System.Drawing.Size(762, 268);
            this.data_gv_estadisticas.TabIndex = 0;
            // 
            // checkList_estadisticas
            // 
            this.checkList_estadisticas.FormattingEnabled = true;
            this.checkList_estadisticas.Items.AddRange(new object[] {
            "Lista de Profesionales por cantidad de Pacientes",
            "Médico que más pacientes atendió",
            "Especialidad con mas consultas",
            "Médico que menos pacientes atendio"});
            this.checkList_estadisticas.Location = new System.Drawing.Point(13, 315);
            this.checkList_estadisticas.Name = "checkList_estadisticas";
            this.checkList_estadisticas.Size = new System.Drawing.Size(302, 94);
            this.checkList_estadisticas.TabIndex = 2;
            this.checkList_estadisticas.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form_estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkList_estadisticas);
            this.Controls.Add(this.data_gv_estadisticas);
            this.Name = "Form_estadisticas";
            this.Text = "Form_estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.data_gv_estadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_gv_estadisticas;
        private System.Windows.Forms.CheckedListBox checkList_estadisticas;
    }
}
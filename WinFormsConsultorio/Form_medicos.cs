using Consultorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsConsultorio {
    public partial class Form_medicos : Form {
        private DataTable dt_medicos;
        public Form_medicos() {
            InitializeComponent();

            dt_medicos = new DataTable();

            dt_medicos.Columns.Add("Nombre");
            dt_medicos.Columns.Add("Apellido");
            dt_medicos.Columns.Add("Especialidad");

            DataRow row;
            foreach (Medico medicos in ClinicaEstatica.medicos) {
                row = dt_medicos.NewRow();
                row["Nombre"] = medicos.Nombre;
                row["Apellido"] = medicos.Apellido;
                row["Especialidad"] = medicos.Tipo_Especialidad;

                dt_medicos.Rows.Add(row);
            }

            dataGV_medicos.DataSource = dt_medicos;
        }

        private void check_medicos_CheckedChanged(object sender, EventArgs e) {
            
            if(check_medicos.Checked){
                dt_medicos.Clear();

                DataRow row;
                foreach (Medico medico in ClinicaEstatica.medicos) {
                    if (!medico.Atendiendo) {
                        row = dt_medicos.NewRow();
                        row["Nombre"] = medico.Nombre;
                        row["Apellido"] = medico.Apellido;
                        row["Especialidad"] = medico.Tipo_Especialidad;

                        dt_medicos.Rows.Add(row);
                    }
                }
            } else {
                dt_medicos.Clear();
                DataRow row;
                foreach (Medico medicos in ClinicaEstatica.medicos) {
                    row = dt_medicos.NewRow();
                    row["Nombre"] = medicos.Nombre;
                    row["Apellido"] = medicos.Apellido;
                    row["Especialidad"] = medicos.Tipo_Especialidad;

                    dt_medicos.Rows.Add(row);
                }
            }
        }
    }
}

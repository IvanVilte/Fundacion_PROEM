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
    public partial class Form_estadisticas : Form {
        private DataTable dt_estadistica;
        public Form_estadisticas() {
            InitializeComponent();
            dt_estadistica = new DataTable();

            data_gv_estadisticas.DataSource = dt_estadistica;
        }

        private void Actualizar_dataGridView(List<Tuple<int, Medico>> medicos) {
            dt_estadistica.Columns.Add("Medico");
            dt_estadistica.Columns.Add("Cant de Pacientes");

            DataRow row;

            foreach(Tuple<int, Medico> medico in medicos) {
                row = dt_estadistica.NewRow();

                row["Medico"] = medico.Item2.Nombre + " " + medico.Item2.Apellido;
                row["Cant de Pacientes"] = medico.Item1;

                dt_estadistica.Rows.Add(row);
            }

        }
        private void Actualizar_dataGridView(Tuple<int, Medico> medico) {
            dt_estadistica.Columns.Add("Medico");
            dt_estadistica.Columns.Add("Cant de Pacientes");

            DataRow row;

            row = dt_estadistica.NewRow();

            row["Medico"] = medico.Item2.Nombre + " " + medico.Item2.Apellido;
            row["Cant de Pacientes"] = medico.Item1;

            dt_estadistica.Rows.Add(row);

        }
        public void Actualizar_dataGridViewEspecialidad(Tuple<int, Especialidad> especialidad) {
            dt_estadistica.Columns.Add("Especialidad");
            dt_estadistica.Columns.Add("Cant de Pacientes");

            DataRow row;

            row = dt_estadistica.NewRow();

            row["Especialidad"] = especialidad.Item2;
            row["Cant de Pacientes"] = especialidad.Item1;
            

            dt_estadistica.Rows.Add(row);
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (checkList_estadisticas.SelectedIndex) {
                case 0:
                    dt_estadistica.Clear();
                    dt_estadistica.Columns.Clear();
                    Actualizar_dataGridView(ClinicaEstatica.Lista_Medicos_ordenada_paciente());
                    break;
                case 1:
                    dt_estadistica.Clear();
                    dt_estadistica.Columns.Clear();
                    Actualizar_dataGridView(ClinicaEstatica.Medico_conmas_pacientes());
                    break;
                case 2:
                    dt_estadistica.Clear();
                    dt_estadistica.Columns.Clear();
                    Actualizar_dataGridViewEspecialidad(ClinicaEstatica.Especialidad_mas_solicitada());
                    break;
                case 3:
                    dt_estadistica.Clear();
                    dt_estadistica.Columns.Clear();
                    Actualizar_dataGridView(ClinicaEstatica.Medico_conmenos_pacientes());
                    break;
                default:
                    break;
            }
        }
    }
}

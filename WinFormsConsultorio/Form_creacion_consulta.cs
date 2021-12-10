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
    public partial class Form_creacion_consulta : Form {
        DataTable dt_medicos_filtrados;
        Paciente paciente;
        public Form_creacion_consulta(Paciente paciente) {
            this.dt_medicos_filtrados = new DataTable();
            this.paciente = paciente;
            InitializeComponent();

            data_GV_medicos_Disponibles.DataSource = dt_medicos_filtrados;
        }

        private void Form_consulta_Load(object sender, EventArgs e) {
            label_nombre.Text = paciente.Nombre;
            label_apellido.Text = paciente.Apellido;
            label_dni.Text = paciente.DNI.ToString();
            label_cobertura.Text = paciente.TipoCobertura.ToString();

            this.dt_medicos_filtrados.Columns.Add("Nombre");
            this.dt_medicos_filtrados.Columns.Add("Apellido");
            this.dt_medicos_filtrados.Columns.Add("Especialidad");
        }

        private void lbl_nombre_Click(object sender, EventArgs e) {

        }

        private void btn_buscar_medicos_Click(object sender, EventArgs e) {
            string nombre = txt_nombre_medico.Text;
            string apellido = txt_apellido_medico.Text;
            Especialidad especialidad = EncontrarEspecialidad.Buscar_especialidad(combo_box_especialidad.Text);

            if (nombre != "") {
                combo_box_especialidad.SelectedIndex = -1;
                if(apellido != "") {
                    Modificar_gridView_medicos(ClinicaEstatica.Buscar_medicos(nombre, apellido));
                } else {
                    Modificar_gridView_medicos(ClinicaEstatica.Buscar_medicos(nombre));
                }
            }
            else if(especialidad.ToString() != "") {
                Modificar_gridView_medicos(ClinicaEstatica.Buscar_medicos(especialidad));
            }
        }

        private void Modificar_gridView_medicos(List<Medico> medicos) {
            dt_medicos_filtrados.Clear();
            DataRow row;
            foreach (Medico medico in medicos) {
                row = dt_medicos_filtrados.NewRow();

                row["Nombre"] = medico.Nombre;
                row["Apellido"] = medico.Apellido;
                row["Especialidad"] = medico.Tipo_Especialidad;

                dt_medicos_filtrados.Rows.Add(row);
            }

        }

        private void btn_crear_consulta_Click(object sender, EventArgs e) {
            try {
                if (data_GV_medicos_Disponibles.CurrentCell.RowIndex >= 0) {
                    ClinicaEstatica.Obtener_siguiente_paciente();
                    string nombre = (string)data_GV_medicos_Disponibles.CurrentRow.Cells["Nombre"].Value;
                    string apellido = (string)data_GV_medicos_Disponibles.CurrentRow.Cells["Apellido"].Value;
                    Especialidad especialidad = EncontrarEspecialidad.Buscar_especialidad((string)data_GV_medicos_Disponibles.CurrentRow.Cells["Especialidad"].Value);
                    Medico medico_seleccionado = ClinicaEstatica.Buscar_medico(nombre, apellido, especialidad);

                    ClinicaEstatica.Crear_consulta(medico_seleccionado, this.paciente);
                    Close();
                } else {
                    MessageBox.Show("No se selecciono ningun medico");
                }
            }
            catch (NullReferenceException) {
                MessageBox.Show("No selecciono ningun médico");
            }
            
        }
    }
}

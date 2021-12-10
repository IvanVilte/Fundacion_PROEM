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
    public partial class Form_pacientes : Form {

        private DataTable dt_pacientes;

        public Form_pacientes() {
            InitializeComponent();

            //Incializamos el DataTable
            dt_pacientes = new DataTable();

            dataGV_pacientes.DataSource = dt_pacientes;
        }
        private void btn_agregar_pacientes_Click(object sender, EventArgs e) {
            Form_agregar_paciente agregar_Paciente = new Form_agregar_paciente(dt_pacientes);
            agregar_Paciente.ShowDialog();
            Actualizar_pacientes();
            
        }

        private void dataGV_pacientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            long dni = long.Parse((string)dataGV_pacientes.CurrentRow.Cells["DNI"].Value);
            Paciente paciente = ClinicaEstatica.Buscar_paciente(dni);
            if( paciente != null) {
                Form_creacion_consulta consulta = new Form_creacion_consulta(paciente);
                consulta.ShowDialog();
            } else {
                MessageBox.Show("El paciente no esta registrado para ser atendido");
            }
            
        }
        private void Actualizar_pacientes() {
            dt_pacientes.Clear();
            DataRow row;
            int ord_llegada = 1;
            //Agregamos los usuarios predeterminados al DataTable
            foreach (Paciente paciente in ClinicaEstatica.pacientes) {
                row = dt_pacientes.NewRow();
                row["Orden de Llegada"] = ord_llegada++;
                row["DNI"] = paciente.DNI;
                row["Nombre"] = paciente.Nombre;
                row["Apellido"] = paciente.Apellido;
                row["Edad"] = paciente.Edad;
                row["Cobertura"] = paciente.TipoCobertura;

                dt_pacientes.Rows.Add(row);
            }
        }
        private void btn_asignar_medico_Click(object sender, EventArgs e) {
            //Paciente paciente = ClinicaEstatica.Obtener_siguiente_paciente();
            long dni = long.Parse(dataGV_pacientes.Rows[0].Cells["DNI"].Value.ToString());
            Paciente paciente = ClinicaEstatica.Buscar_paciente(dni);
            Form_creacion_consulta crear_consulta = new Form_creacion_consulta(paciente);
            crear_consulta.ShowDialog();
            Actualizar_pacientes();
        }

        private void Form_pacientes_Load(object sender, EventArgs e) {
            //Agregamos columnas al DataTable
            dt_pacientes.Columns.Add("Orden de LLegada");
            dt_pacientes.Columns.Add("DNI");
            dt_pacientes.Columns.Add("Nombre");
            dt_pacientes.Columns.Add("Apellido");
            dt_pacientes.Columns.Add("Edad");
            dt_pacientes.Columns.Add("Cobertura");

            Actualizar_pacientes();
        }
    }
}

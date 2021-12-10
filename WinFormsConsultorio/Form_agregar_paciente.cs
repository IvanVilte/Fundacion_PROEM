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
    public partial class Form_agregar_paciente : Form {
        private DataTable dt_pacientes;
        public Form_agregar_paciente(DataTable dt_paciente) {
            InitializeComponent();
            this.dt_pacientes = dt_paciente;
        }

        private void Form_agregar_paciente_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                long dni = long.Parse(txt_dni.Text);
                int edad = int.Parse(num_edad.Value.ToString());
                string cobertura = cb_cobertura.Text;

                ClinicaEstatica.agregar_paciente(new Paciente(nombre, apellido, dni, edad, cobertura));

                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_dni.Clear();
                num_edad.ResetText();
                cb_cobertura.SelectedIndex = -1;

                DataRow new_row = dt_pacientes.NewRow();

                new_row["DNI"] = dni;
                new_row["Nombre"] = nombre;
                new_row["Apellido"] = apellido;
                new_row["Edad"] = edad;
                new_row["Cobertura"] = cobertura;

                dt_pacientes.Rows.Add(new_row);

            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
                txt_dni.Focus();
                return;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

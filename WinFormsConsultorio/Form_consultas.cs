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
    public partial class Form_consultas : Form {
        DataTable dt_consultas;
        public Form_consultas() {
            InitializeComponent();
            dt_consultas = new DataTable();

            dt_consultas.Columns.Add("Nro Consulta");
            dt_consultas.Columns.Add("Medico");
            dt_consultas.Columns.Add("Paciente");
            dt_consultas.Columns.Add("Estado");
            dt_consultas.Columns.Add("Diagnostico");

            data_GV_consultas.DataSource = dt_consultas;

            Cargar_consultas();
        }

        private void Cargar_consultas() {
            DataRow row;

            foreach (Consulta consulta in ClinicaEstatica.consultas) {
                row = dt_consultas.NewRow();
                row["Nro Consulta"] = consulta.NroConsulta;
                row["Medico"] = consulta.Nombre_medico();
                row["Paciente"] = consulta.Nombre_paciente();
                row["Estado"] = consulta.EnCurso ? "En Curso" : consulta.Finalizo ? "Finalizo" : "Pendiente";
                row["Diagnostico"] = consulta.Obetener_diagnostico();
                 dt_consultas.Rows.Add(row);
                
            }
        }

        private void data_GV_consultas_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            lbl_estado_consulta.Visible = true;
            combo_box_estados.Visible = true;
            btn_estado.Visible = true;
        }
        private void limpiar_controles() {
            lbl_estado_consulta.Visible = false;
            combo_box_estados.Visible = false;
            combo_box_estados.SelectedIndex = -1;
            btn_estado.Visible = false;
        }
        private void btn_estado_Click(object sender, EventArgs e) {
            bool finalizado = (data_GV_consultas.CurrentRow.Cells["Estado"].Value).Equals("Finalizado") ? true : false;
            //Vemos si la consulta no esta finalizada, ya que si finalizo no podemos elegir otra opcion
            if (!finalizado) {
                bool en_curso = (data_GV_consultas.CurrentRow.Cells["Estado"].Value).Equals("En Curso") ? true : false;
                //si la consulta esta en curso, solo podemos finalizarla
                if (en_curso) {
                    //vemos si el usuario eligio o no finalizar la cosulta
                    if (combo_box_estados.SelectedItem.ToString().Equals("Finalizado")) {
                        Consulta consulta_seleccionada = ClinicaEstatica.Buscar_consulta_NroConsulta(int.Parse(data_GV_consultas.CurrentRow.Cells["Nro Consulta"].Value.ToString()));
                        consulta_seleccionada.finalizar_consulta();
                        limpiar_controles();
                        data_GV_consultas.CurrentRow.Cells["Estado"].Value = "Finalizado";
                        data_GV_consultas.CurrentRow.Cells["Diagnostico"].Value = consulta_seleccionada.Obetener_diagnostico();

                    } else {
                        MessageBox.Show("La consulta esta en curso, Solo puede finalizarla");
                        limpiar_controles();
                    }
                } else {
                    //Vemos si la consulta esta Pendiente
                    bool pendiente = (data_GV_consultas.CurrentRow.Cells["Estado"].Value).Equals("Pendiente") ? true : false;
                    if (pendiente) {
                        //Si el usuario eligo iniciar la consulta tendremos que checkear algunas cosas
                        if(combo_box_estados.SelectedItem.ToString().Equals("En Curso")) {
                            int nroConsulta = int.Parse(data_GV_consultas.CurrentRow.Cells["Nro Consulta"].Value.ToString());
                            Consulta consulta = ClinicaEstatica.Buscar_consulta_NroConsulta(nroConsulta);
                            if (consulta.Iniciar_consulta()) {
                                MessageBox.Show("Consulta Iniciadad");
                                data_GV_consultas.CurrentRow.Cells["Estado"].Value = "En Curso";
                                limpiar_controles();
                            } else {
                                MessageBox.Show("La consulta no pudo ser iniciada");
                                limpiar_controles();
                            }
                        //Una consulta pendiente solo se puede iniciar, dadas ciertas condiciones
                        } else {
                            MessageBox.Show("Esta consulta solo se puede iniciar");
                            limpiar_controles();
                        }
                    }
                }
            } else {
                MessageBox.Show("Esta consulta ya fianlizo no se puede modificar");
                limpiar_controles();
            }
        }
    }
}

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
    public partial class Form_principal : Form {

        //public Clinica clinica_PROEM;

        public Form_principal() {
            InitializeComponent();

            //Cola de pacientes predeterminada
            Queue<Paciente> pacientes = new Queue<Paciente>();
            ClinicaEstatica.agregar_paciente(new Paciente("Pepito", "Arevalos", 26323712, 12, "NoTiene"));
            ClinicaEstatica.agregar_paciente(new Paciente("Jose", "Arcadio", 87927354, 21, "CoberturaBasica"));
            ClinicaEstatica.agregar_paciente(new Paciente("Pepe", "Ceballos", 57486123, 30, "CobreturaCompleta"));
            ClinicaEstatica.agregar_paciente(new Paciente("Asterix", "Cat", 10203034, 25, "NoTiene"));
            ClinicaEstatica.agregar_paciente(new Paciente("Tony", "Star", 47515359, 27, "NoTiene"));
            ClinicaEstatica.agregar_paciente(new Paciente("Tim", "Barton", 50217896, 32, "CoberturaBasica"));
            ClinicaEstatica.agregar_paciente(new Paciente("Pedro", "Picapiedra", 20147893, 28, "CoberturaBasica"));
            ClinicaEstatica.agregar_paciente(new Paciente("Pablo", "Morza", 36987410, 25, "CobreturaCompleta"));
            ClinicaEstatica.agregar_paciente(new Paciente("Timmy", "Turner", 15975346, 24, "CobreturaCompleta"));
            ClinicaEstatica.agregar_paciente(new Paciente("Noel", "Silva", 85296374, 20, "CobreturaCompleta"));

            //Lista de Medicos predeterminada 
            List<Medico> medicos = new List<Medico>();
            ClinicaEstatica.medicos.Add(new Medico("Shaun", "Murphy", Especialidad.Traumatologia, 111111));
            ClinicaEstatica.medicos.Add(new Medico("Meredith", "Grey", Especialidad.Cardiologia, 222222));
            ClinicaEstatica.medicos.Add(new Medico("Gregory", "House", Especialidad.Traumatologia, 333333));
            ClinicaEstatica.medicos.Add(new Medico("Leonard", "McCoy", Especialidad.Neurologia, 444444));
            ClinicaEstatica.medicos.Add(new Medico("John", "Watson", Especialidad.Traumatologia, 555555));
            ClinicaEstatica.medicos.Add(new Medico("Alexander", "Fleming", Especialidad.Infectologia, 666666));
            ClinicaEstatica.medicos.Add(new Medico("Edward", "Jenner", Especialidad.Pediatria, 777777));
            ClinicaEstatica.medicos.Add(new Medico("William", "Osler", Especialidad.Psiquiatria, 8888888));
            ClinicaEstatica.medicos.Add(new Medico("Louis", "Pasteur", Especialidad.Radiologia, 9999999));



            //Inicializamos la el objeto Clinica
            //this.clinica_PROEM = new Clinica(medicos, pacientes);

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btn_pacientes_Click(object sender, EventArgs e) {
            Form_pacientes pacientes = new Form_pacientes();
            pacientes.ShowDialog();
        }

        private void btn_mostrar_medicos_Click(object sender, EventArgs e) {
            Form_medicos medicos = new Form_medicos();
            medicos.ShowDialog();
        }

        private void btn_mostrar_consultas_Click(object sender, EventArgs e) {
            Form_consultas consultas = new Form_consultas();
            consultas.ShowDialog();
        }

        private void btn_mostrar_estadisticas_Click(object sender, EventArgs e) {
            Form_estadisticas estadisticas = new Form_estadisticas();
            estadisticas.ShowDialog();

        }
    }
}

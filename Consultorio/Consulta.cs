using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio {
    public class Consulta {
        private static int count = 1;
        private int nro_consulta;
        private Medico medico;
        private Paciente paciente;
        private Diagnostico diagnostico;
        public bool Finalizo { get; set; }
        public bool EnCurso { get; set; }

        public Consulta(Medico medico, Paciente paciente) {
            this.nro_consulta = count++;
            this.medico = medico;
            this.paciente = paciente;
            this.Finalizo = false;
            this.EnCurso = false;
            this.diagnostico = Diagnostico.SinDiagnostico;
        }
        public Diagnostico Obetener_diagnostico() {
            return this.diagnostico;
        }
        public Medico Consultar_medico() {
            return this.medico;
        }
        public Paciente Consultar_Paciente() {
            return this.paciente;
        }
        public int NroConsulta { 
            get { return this.nro_consulta; }
        }
        public bool Iniciar_consulta() {
            if (this.medico.Atendiendo) {
                return false;
            }
            this.medico.atender_paciente(this.paciente);
            this.EnCurso = true;
            return true;

        }
        public bool Consulta_Finalizada() {
            return this.Finalizo;
        }
        public bool Consulta_en_Curso() {
            return this.EnCurso;
        }

        public int Obetener_NroConsulta() {
            return this.nro_consulta;
        }

        public void finalizar_consulta() {
            Finalizo = true;
            EnCurso = false;
            this.medico.Atendiendo = false;
            this.medico.Asignar_diagnostico(this.paciente);
            this.diagnostico = this.paciente.ResultadoConsulta;
        }
        public string Nombre_medico() {
            return this.medico.Nombre + " " + this.medico.Apellido;
        }

        public string Nombre_paciente() {
            return this.paciente.Nombre + " " + this.paciente.Apellido;
        }


    }
}

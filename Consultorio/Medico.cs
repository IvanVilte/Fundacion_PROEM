using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio {

    public enum Especialidad { Pediatria, Radiologia, Traumatologia, Psiquiatria, Infectologia, Cardiologia, Endicronologia, Neurologia }
    public enum Diagnostico { Derivacion , Estudios, Internacion, Cirugia, Tratamiento, Aislamiento, Medicacion, SinDiagnostico }
    public class Medico : Persona{
        private Boolean atendiendo;
        private long matricula;

        public Medico(string nombre, string apellido, Especialidad especialidad, long matricula): 
            base(nombre, apellido) {
            Tipo_Especialidad = especialidad;
            this.atendiendo = false;
            this.matricula = matricula;
        }
        public long Matricula { get; }
        public Especialidad Tipo_Especialidad { get; set; }
        public Boolean Atendiendo { 
            get { return this.atendiendo; } 
            set { this.atendiendo = value; } 
        }
        public override string ToString() {
            return "DOCTOR\n"+ base.ToString() +"Especialidad: " + Tipo_Especialidad.ToString();
        }

        public void atender_paciente(Paciente paciente) {
            Atendiendo = (!Atendiendo);
        }
        public void Asignar_diagnostico(Paciente paciente) {
            Array diagnosticos = Enum.GetValues(typeof(Diagnostico)); 
            Random random = new Random(Environment.TickCount);
            paciente.ResultadoConsulta = (Diagnostico)(diagnosticos.GetValue(random.Next(diagnosticos.Length -1)));
        }
    }
}

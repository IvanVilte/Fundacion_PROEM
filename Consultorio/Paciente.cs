using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio {

    public enum Cobertura { NoTiene, CoberturaBasica, CobreturaCompleta }
    public class Paciente : Persona {

        private int edad;

        public Diagnostico ResultadoConsulta { get; set; }

        public Paciente(string nombre, string apellido, long dni, int edad, string cobertura) :
            base(nombre, apellido) {
            TipoCobertura = EncontrarCobertura.obtenerCobertura(cobertura);
            DNI = dni;
            Edad = edad;
        }
        public Cobertura TipoCobertura { get; set; }
        public long DNI { get; set; }
        public int Edad { 
            get { return this.edad; }
            set {
                if(value < 0 || value > 150) {
                    throw new Exception("Edad no válida"); 
                }
                this.edad = value;
            }
        }

        public override string ToString() {
            return "PACIENTE \n" + base.ToString() + "Edad: " + Edad + "\nCobertura: " + TipoCobertura.ToString() + "\n";
        }
    }
}

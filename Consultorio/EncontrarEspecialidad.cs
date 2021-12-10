using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio {
    public static class EncontrarEspecialidad {
        //Pediatria, Radiologia, Traumatologia, Psiquiatria, Infectologia, Cardiologia, Endicronologia, Neurologia
        public static Especialidad Buscar_especialidad(string especialidad) {
            if (esPediatra(especialidad)) {
                return Especialidad.Pediatria;
            }
            else if (esRadiologia(especialidad)) {
                return Especialidad.Radiologia;
            }
            else if (esTraumatologia(especialidad)) {
                return Especialidad.Traumatologia;
            }
            else if (esPsiquiatria(especialidad)) {
                return Especialidad.Psiquiatria;
            }
            else if (esInfectologia(especialidad)) {
                return Especialidad.Infectologia;
            }
            else if (esCardiologia(especialidad)) {
                return Especialidad.Cardiologia;
            }
            else if(esEndicronologia(especialidad)) {
                return Especialidad.Endicronologia;
            }
            else if(esNeurologia(especialidad)) {
                return Especialidad.Neurologia;
            }
            else {
                return 0;
            }
        }

        private static bool esNeurologia(string especialidad) {
            return especialidad.Equals(Especialidad.Neurologia.ToString());
        }

        private static bool esEndicronologia(string especialidad) {
            return especialidad.Equals(Especialidad.Endicronologia.ToString());
        }

        private static bool esCardiologia(string especialidad) {
            return especialidad.Equals(Especialidad.Cardiologia.ToString());
        }

        private static bool esInfectologia(string especialidad) {
            return especialidad.Equals(Especialidad.Infectologia.ToString());
        }

        private static bool esPsiquiatria(string especialidad) {
            return especialidad.Equals(Especialidad.Psiquiatria.ToString());
        }

        private static bool esTraumatologia(string especialidad) {
            return especialidad.Equals(Especialidad.Traumatologia.ToString());
        }

        private static bool esRadiologia(string especialidad) {
            return especialidad.Equals(Especialidad.Radiologia.ToString());
        }

        private static bool esPediatra(string especialidad) {
            return especialidad.Equals(Especialidad.Pediatria.ToString());
        }
    }
}

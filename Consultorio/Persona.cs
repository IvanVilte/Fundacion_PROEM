using System;

namespace Consultorio {
    public abstract class Persona {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido) {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString() {
            return "Nombre: " + Nombre + " \nApellido: " + Apellido + "\n";
        }
    }
}

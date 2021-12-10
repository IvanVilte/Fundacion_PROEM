using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio {
    public static class EncontrarCobertura {

        public static Cobertura obtenerCobertura(string tipo_cobertura) {

            if (esBasica(tipo_cobertura)) {
                return Cobertura.CoberturaBasica;
            } else if (esCompleta(tipo_cobertura)) {
                return Cobertura.CobreturaCompleta;
            } else
                return Cobertura.NoTiene;
        }

        private static bool esBasica(string tipo_cobertura) {
            return (Cobertura.CoberturaBasica.ToString()).Equals(tipo_cobertura);
        }

        private static bool esCompleta(string tipo_cobertura) {
            return (Cobertura.CobreturaCompleta.ToString()).Equals(tipo_cobertura);
        }
    }

}

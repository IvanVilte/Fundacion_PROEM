using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio {
    public static class ClinicaEstatica {

        public static Queue<Paciente> pacientes = new Queue<Paciente>();
        public static List<Medico> medicos = new List<Medico>();
        public static List<Consulta> consultas = new List<Consulta>();

        public static int Cantidad_consultas(Medico medico) {
            int cant_consultas = 0;
            foreach (Consulta consulta in consultas) {
                if (consulta.Consultar_medico().Equals(medico)) {
                    cant_consultas++;
                }
            }

            return cant_consultas;
        }
        public static List<Tuple<int, Medico>> Lista_Medicos_ordenada_paciente() {
            List<Medico> lista_medico = new List<Medico>();
            List<Tuple<int, Medico>> lista_ordenada_medicos = new List<Tuple<int, Medico>>();

            foreach (Medico medico in medicos) {
                lista_ordenada_medicos.Add(new Tuple<int, Medico>(Cantidad_consultas(medico), medico));
            }

            lista_ordenada_medicos.Sort((x, y) => y.Item1.CompareTo(x.Item1));

            foreach (Tuple<int, Medico> tupla in lista_ordenada_medicos) {
                lista_medico.Add(tupla.Item2);
            }
            return lista_ordenada_medicos;
        } 
        public static Tuple<int,Medico> Medico_conmas_pacientes() {
            return Lista_Medicos_ordenada_paciente()[0];
        }
        public static Tuple<int, Medico> Medico_conmenos_pacientes() {
            return Lista_Medicos_ordenada_paciente().Last();
        }
        public static int Cantidad_consultas_especialidad(Especialidad especialidad) {
            int cant_consultas_especialidad = 0;
            foreach (Consulta consulta in consultas) {
                if (consulta.Consultar_medico().Tipo_Especialidad.Equals(especialidad)) {
                    cant_consultas_especialidad++;
                }
            }

            return cant_consultas_especialidad;
        }
        public static Tuple<int, Especialidad> Especialidad_mas_solicitada() {
            Array especialidades = Enum.GetValues(typeof(Especialidad));
            List<Tuple<int, Especialidad>> especialidades_ordenadas = new List<Tuple<int, Especialidad>>();

            foreach (Especialidad especialidad in especialidades) {
                especialidades_ordenadas.Add(new Tuple<int, Especialidad>(Cantidad_consultas_especialidad(especialidad), especialidad));
            }

            especialidades_ordenadas.Sort((x, y) => y.Item1.CompareTo(x.Item1));

            return especialidades_ordenadas[0];
            
        }
       
        public static void Crear_consulta(Medico medico) {
            Consulta consulta;
            Paciente paciente = pacientes.Dequeue();

            consulta = new Consulta(medico, paciente);

            consultas.Add(consulta);
        }
        public static void Finalizar_Consulta(int NroConsulta) {
            Consulta consulta = Buscar_consulta_NroConsulta(NroConsulta);
            
            if(consulta != null) {
                consulta.finalizar_consulta();
            }
        }
        public static Consulta Buscar_consulta_NroConsulta(int nroConsulta) {
            Consulta consulta_buscada = null;

            bool encontrada = false;
            int index = 0;
            while (index < consultas.Count && !encontrada) {
                if (consultas[index].NroConsulta.Equals(nroConsulta)) {
                    consulta_buscada = consultas[index];
                    encontrada = true;
                    
                }
                index++;
            }

            return consulta_buscada;
        }
        public static Paciente Obtener_siguiente_paciente() {
            return pacientes.Dequeue();
        }
        public static void Crear_consulta(Medico medico, Paciente paciente) {
            Consulta consulta = new Consulta(medico, paciente);

            consultas.Add(consulta);
        }



        public static List<Medico> obtener_medico_con_especialidad(Especialidad especialidad) {
            List<Medico> medicos_con_especialidad = new List<Medico>();

            foreach (Medico medico in medicos) {
                if (medico.Tipo_Especialidad.Equals(especialidad)) {
                    medicos_con_especialidad.Add(medico);
                }
            }
            return medicos_con_especialidad;
        }
        public static bool estado_doctor(string nombre, string apellido, Especialidad especialidad) {
            return Buscar_medico(nombre, apellido, especialidad).Atendiendo;
        }
        public static Medico Buscar_medico(string nombre, string apellido, Especialidad especialidad) {
            foreach (Medico medico in medicos) {
                if (medico.Nombre == nombre) {
                    if (medico.Apellido == apellido) {
                        if (medico.Tipo_Especialidad.Equals(especialidad)) {
                            return medico;
                        }
                    }
                }
            }
            return null;
        }
        public static List<Medico> Buscar_medicos(string nombre) {
            List<Medico> medicos_result = new List<Medico>();
            foreach (Medico medico in medicos) {
                if (medico.Nombre.Equals(nombre)) {
                    medicos_result.Add(medico);
                }
            }
            return medicos_result;
        }

        public static List<Medico> Buscar_medicos(string nombre, string apellido) {
            List<Medico> medicos_result = new List<Medico>();
            foreach (Medico medico in medicos) {
                if(medico.Nombre.Equals(nombre) && medico.Apellido.Equals(apellido)) {
                    medicos_result.Add(medico);
                }
            }

            return medicos_result;
        }

        public static List<Medico> Buscar_medicos(Especialidad especialidad) {
            List<Medico> medicos_result = new List<Medico>();
            foreach (Medico medico in medicos) {
                if (medico.Tipo_Especialidad.Equals(especialidad)) {
                    medicos_result.Add(medico);
                }
            }

            return medicos_result;
        }

        public static Paciente Buscar_paciente(long dni) {
            foreach (Paciente paciente in pacientes) {
                if (paciente.DNI.Equals(dni)) {
                    return paciente;
                }
            }
            return null;
        }
        public static void agregar_paciente(Paciente paciente) {
            pacientes.Enqueue(paciente);
        }

        public static void mostrar_pacientes() {
            foreach (Paciente paciente in pacientes) {
                Console.WriteLine(paciente);
            }
        }

        public static void mostrar_medicos() {
            foreach (Medico medico in medicos) {
                Console.WriteLine(medico);
            }
        }
        public static void mostrar_medicos_disponibles() {
            foreach (Medico medico in medicos) {
                if (!medico.Atendiendo) {
                    Console.WriteLine(medico);
                }
            }
        }
    }
}

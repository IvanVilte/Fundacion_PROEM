using System;
using System.Collections.Generic;
using Consultorio;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            DateTime fecha_nacimiento = new DateTime(1996,11,26);
            List<Medico> medicos = new List<Medico>();

            Medico medico1 = new Medico("Shaun", "Murphy", Especialidad.Traumatologia, 111111);
            Medico medico2 = new Medico("Meredith", "Grey", Especialidad.Cardiologia, 222222);
            Medico medico3 = new Medico("Gregory ", "House", Especialidad.Traumatologia, 333333);
            Medico medico4 = new Medico("Leonard", "McCoy", Especialidad.Neurologia, 444444);
            Medico medico5 = new Medico("John", "Watson", Especialidad.Traumatologia, 555555);

            medicos.Add(medico1);
            medicos.Add(medico2);
            medicos.Add(medico3);
            medicos.Add(medico4);
            medicos.Add(medico5);

            Paciente paciente1 = new Paciente("Pepito", "Arevalos", 26323712, 21, "NoTiene");
            Paciente paciente2 = new Paciente("Jose", "Arcadio", 87927354, 22, "CoberturaBasica");
            Paciente paciente3 = new Paciente("Pepe", "Ceballos", 57486123, 23, "CobreturaCompleta");
            Paciente paciente4 = new Paciente("Asterix", "Cat", 10203034, 34, "NoTiene");
            Paciente paciente5 = new Paciente("Tony", "Star", 47515359, 54, "NoTiene");
            Paciente paciente6 = new Paciente("Tim", "Barton", 50217896, 24, "CoberturaBasica");
            Paciente paciente7 = new Paciente("Pedro", "Picapiedra", 20147893, 14, "CoberturaBasica");
            Paciente paciente8 = new Paciente("Pablo", "Morza", 36987410, 18, "CobreturaCompleta");
            Paciente paciente9 = new Paciente("Timmy", "Turner", 15975346, 19, "CobreturaCompleta");
            Paciente paciente10 = new Paciente("Noel", "Silva", 85296374, 22, "CobreturaCompleta");
            
            Clinica clinica = new Clinica(medicos);
            clinica.agregar_paciente(paciente1);
            clinica.agregar_paciente(paciente2);
            clinica.agregar_paciente(paciente3);
            clinica.agregar_paciente(paciente4);
            clinica.agregar_paciente(paciente5);
            clinica.agregar_paciente(paciente6);
            clinica.agregar_paciente(paciente7);
            clinica.agregar_paciente(paciente8);
            clinica.agregar_paciente(paciente9);
            clinica.agregar_paciente(paciente10);

            clinica.mostrar_pacientes();
            
            clinica.atender_pacientes();
            //Console.WriteLine("Médicos de la Clinica");
            //clinica.mostrar_medicos();
            //Console.WriteLine("\nMédicos Disponibles");
            //clinica.mostrar_medicos_disponibles();

            List<Medico> medicos_con_especialidad = clinica.obtener_medico_con_especialidad(Especialidad.Traumatologia);
            foreach (Medico medico in medicos_con_especialidad) {
                Console.WriteLine(medico);
            }
        }
    }
}

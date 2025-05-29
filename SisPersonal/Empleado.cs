using System.Security.Cryptography;

namespace EspacioEmpleados
{
    public enum Cargos
    {
        Administrativo,
        Auxiliar,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime FechaNacimiento;
        public char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        public Cargos cargo;

        public String Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }



        public int Edad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento1.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento1.DayOfYear)
            {
                edad--;
            }
            return edad;
        }

        public int CalcularAntiguedad()
        {
            int antiguedad = DateTime.Now.Year - FechaIngreso.Year;
            if (DateTime.Now.DayOfYear < FechaIngreso.DayOfYear)
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public double salario()
        {
            double adicional = 0;
            int antiguedad = CalcularAntiguedad();
            if (antiguedad <= 20)
            {
                adicional += SueldoBasico * 0.01 * antiguedad;
            }
            else
            {
                adicional += SueldoBasico * 0.25;
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            if (estadoCivil == 'C')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
        }

        public int jubilarse()
        {
            int jubliacion = 65 - Edad();
            return jubliacion;
        }
    }

}
namespace EmpresaPersonal
{
    public class Empleado
    {
        // Enumeración dentro de la clase
        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        // Atributos privados
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        // Constructor
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        // Propiedades públicas para acceder (con la sintaxis que preferís)
        public string Nombre
        {
            get => nombre;
        }

        public string Apellido
        {
            get => apellido;
        }

        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
        }

        public char EstadoCivil
        {
            get => estadoCivil;
        }

        public DateTime FechaIngreso
        {
            get => fechaIngreso;
        }

        public double SueldoBasico
        {
            get => sueldoBasico;
        }

        public Cargos Cargo
        {
            get => cargo;
        }

        // Métodos
        public int ObtenerAntiguedad()
        {
            return DateTime.Today.Year - fechaIngreso.Year;
        }

        public int ObtenerEdad()
        {
            return DateTime.Today.Year - fechaNacimiento.Year;
        }

        public int AniosParaJubilarse()
        {
            return 65 - ObtenerEdad();
        }

        public double CalcularSalario()
        {
            double adicional;

            int antiguedad = ObtenerAntiguedad();

            // 1% por año hasta 20, luego fijo 25%
            if (antiguedad <= 20)
                adicional = sueldoBasico * (antiguedad * 0.01);
            else
                adicional = sueldoBasico * 0.25;

            // 50% extra si es Ingeniero o Especialista
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
                adicional *= 1.5;

            // Si es casado, $150000 más
            if (estadoCivil == 'C' || estadoCivil == 'c')
                adicional += 150000;

            return sueldoBasico + adicional;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}");
            Console.WriteLine($"Edad: {ObtenerEdad()} años");
            Console.WriteLine($"Antigüedad: {ObtenerAntiguedad()} años");
            Console.WriteLine($"Años para jubilarse: {AniosParaJubilarse()}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salario total: ${CalcularSalario():N2}");
            Console.WriteLine("---------------");
        }
    }
}

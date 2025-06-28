// Declaramos el espacio de nombres (namespace) llamado EspacioCalculadora.
// Esto es como una "carpeta lógica" para organizar el código.
namespace EspacioCalculadora
{
    // Definimos una clase pública llamada Calculadora.
    // Una clase es una plantilla para crear objetos con datos (atributos) y acciones (métodos).
    public class Calculadora
    {
        // Campo privado de tipo double que almacena el valor actual.
        // Se inicializa automáticamente en 0.
        private double resultado;

        // Propiedad pública de solo lectura (solo tiene get).
        // Permite consultar el valor actual de 'resultado' desde afuera de la clase.
        public double Resultado
        {
            get => resultado; // Sintaxis simplificada para devolver el valor de 'resultado'
        }

        // Método público que suma un valor al resultado.
        // Un método es una acción que puede ejecutar un objeto.
        public void Sumar(double termino)
        {
            resultado += termino; // Se le suma el parámetro 'termino' al resultado actual
        }

        // Método que resta un valor del resultado.
        public void Restar(double termino)
        {
            resultado -= termino;
        }

        // Método que multiplica el resultado por el valor dado.
        public void Multiplicar(double termino)
        {
            resultado *= termino;
        }

        // Método que divide el resultado por el valor dado.
        public void Dividir(double termino)
        {
            // Validamos que no sea división por cero
            if (termino != 0)
            {
                resultado /= termino;
            }
            else
            {
                // Si el valor es 0, mostramos un mensaje de error
                Console.WriteLine("No valida la division por 0");
            }
        }

        // Método que reinicia el resultado a 0
        public void Limpiar()
        {
            resultado = 0;
        }
    }
}

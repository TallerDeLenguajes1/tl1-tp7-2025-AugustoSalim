// Importamos el espacio de nombres para poder usar la clase Calculadora
using EspacioCalculadora;

// Declaramos las variables necesarias
int eleccion = 1;       // Se usará para guardar la opción del usuario
double numero = 0;      // Se usará para guardar el número ingresado por el usuario

// Instanciamos un objeto de la clase Calculadora.
// Esto significa crear un objeto real en memoria basado en la plantilla 'Calculadora'.
Calculadora calculadora = new Calculadora();

// Iniciamos un bucle do-while que se repite hasta que el usuario elija salir (opción 0)
do
{
    // Mostramos el menú de operaciones posibles
    Console.WriteLine("Ingrese la operacion que quiere realizar:");
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicacion");
    Console.WriteLine("4) Division");
    Console.WriteLine("5) Limpiar");
    Console.WriteLine("0) Salir");

    // Leemos la opción del usuario como texto
    string choice = Console.ReadLine();

    // Intentamos convertir el texto a número entero
    // Si se puede convertir, se guarda en 'eleccion'
    bool esNumeroEleccion = int.TryParse(choice, out eleccion);

    // Si la opción requiere un número (Suma, Resta, Multiplicación o División)
    if (eleccion == 1 || eleccion == 2 || eleccion == 3 || eleccion == 4)
    {
        // Pedimos al usuario que ingrese un número
        Console.WriteLine("Ingrese el numero con el que quiere trabajar");
        string num = Console.ReadLine();

        // Intentamos convertir el texto a número decimal (double)
        bool esNumero = double.TryParse(num, out numero);
    }

    // Usamos un switch para ejecutar el método correspondiente según la elección
    switch (eleccion)
    {
        case 1:
            // Llama al método Sumar de la calculadora
            calculadora.Sumar(numero);
            break;

        case 2:
            // Llama al método Restar
            calculadora.Restar(numero);
            break;

        case 3:
            // Llama al método Multiplicar
            calculadora.Multiplicar(numero);
            break;

        case 4:
            // Verificamos si se intenta dividir por cero
            if (numero == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
            else
            {
                // Si no, llamamos al método Dividir
                calculadora.Dividir(numero);
            }
            break;

        case 5:
            // Llama al método Limpiar para reiniciar el resultado
            calculadora.Limpiar();
            break;

        case 0:
            // Opción para salir del programa, no hace nada
            break;

        default:
            // Si se ingresa una opción no válida, lo informamos
            Console.WriteLine("Operacion no valida.");
            break;
    }

    // Mostramos el resultado actual usando la propiedad Resultado
    Console.WriteLine(calculadora.Resultado.ToString());

    // Preguntamos al usuario si quiere seguir haciendo operaciones
    int nEleccion = 3; // Variable auxiliar para repetir la pregunta

    do
    {
        Console.WriteLine("Quiere seguir? 1)- Si 0)- No");
        choice = Console.ReadLine();
        bool nuevaEleccion = int.TryParse(choice, out nEleccion);
    } while (nEleccion != 1 && nEleccion != 0); // Repite hasta que elija 1 o 0

    eleccion = nEleccion; // Actualizamos la variable principal para continuar o salir

} while (eleccion != 0); // Si elige 0, se termina el programa

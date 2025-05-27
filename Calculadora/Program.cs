using EspacioCalculadora;

int eleccion = 1;
double numero = 0;

//Lo declaro y le hago new antes de usarlo porque sino el objeto no existe, similar a lo que pasaba con puntero
Calculadora calculadora = new Calculadora();

do
{
    Console.WriteLine("Ingrese la operacion que quiere realizar:");
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicacion");
    Console.WriteLine("4) Division");
    Console.WriteLine("5) Limpiar");
    Console.WriteLine("0) Salir");

    string choice = Console.ReadLine();
    bool esNumeroEleccion = int.TryParse(choice, out eleccion);

    if (eleccion != 0 || eleccion != 5)
    {
        Console.WriteLine("Ingrese el numero con el que quiere trabajar");
        string num = Console.ReadLine();
        bool esNumero = double.TryParse(num, out numero);  
    }

    switch (eleccion)
    {
        case 1:
            calculadora.Sumar(numero);
            break;
        case 2:
            calculadora.Restar(numero);
            break;
        case 3:
            calculadora.Multiplicar(numero);
            break;
        case 4:
            if (numero == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
            else
            {
                calculadora.Dividir(numero);
            }
            break;
        case 5:
            calculadora.Limpiar();
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Operacion no valida.");
            break;
    }

    Console.WriteLine(calculadora.Resultado.ToString());
    Console.WriteLine("Quiere seguir? 1)- Si 0)- No");
    choice = Console.ReadLine();
    bool nuevaEleccion = int.TryParse(choice, out eleccion);

} while (eleccion != 0);

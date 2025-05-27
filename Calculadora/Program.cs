using EspacioCalculadora;

//Lo declaro y le hago new antes de usarlo porque sino el objeto no existe, similar a lo que pasaba con puntero
Calculadora calculadora = new Calculadora();

Console.WriteLine(calculadora.Resultado.ToString());
calculadora.Sumar(10);
Console.WriteLine(calculadora.Resultado.ToString());


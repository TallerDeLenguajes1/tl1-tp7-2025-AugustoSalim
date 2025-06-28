namespace EspacioCalculadora;
//campos con minuscula - Metodo y Propiedades con Mayuscula la primera
//Linea para probar gitlens
public class Calculadora
{
    private double resultado;//por defecto se inicializa en 0

    public double Resultado { get => resultado; }

    public void Sumar(double termino)
    {
        resultado += termino;
    }
    public void Restar(double termino)
    {
        resultado -= termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            resultado /= termino;
        }
        else
        {
            Console.WriteLine("No valida la division por 0");
        }
    }
    public void Multiplicar(double termino)
    {
        resultado *= termino;
    }
    public void Limpiar()
    {
        resultado = 0;
    }
}
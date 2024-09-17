ng System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un numero de hasta 8 cifras: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero) && numero >= 0 && numero <= 99999999)
        {
            int resultado = SumarDigitosHastaUnSoloDigito(numero);
            Console.WriteLine("El numero que dio como resultado es: " + resultado);
        }
        else
        {
            Console.WriteLine("Numero Inválido.");
        }
    }

    static int SumarDigitosHastaUnSoloDigito(int numero)
    {
        while (numero >= 10)
        {
            int suma = 0;
            while (numero > 0) 
            {
                suma += numero % 10; 
                numero /= 10; 
            }
            numero = suma; 
        }
        return numero; 
    }
}
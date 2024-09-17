
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una oracion (string): ");
        string input = Console.ReadLine();

        bool esPalindromo = EsPalindromo(input);
        if (esPalindromo)
        {
            Console.WriteLine("El string es un palindromo.");
        }
        else
        {
            Console.WriteLine("El string no es un palindromo.");
        }
    }

    static bool EsPalindromo(string str)
    {
        string stringLimpio = new string(str
            .Where(c => Char.IsLetterOrDigit(c))
            .ToArray())
            .ToLower();
       
        string alreves = new string(stringLimpio.Reverse().ToArray());

        return stringLimpio == alreves;
    }
}

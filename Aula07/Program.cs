namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===Operadores de atribuição===");

        //Inicializar a variável

        int x = 10;
        Console.WriteLine("\nValor inicial da variável de x: " + x);

        //Operador de atribuição simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Valor de X: " + x);

        //Atribuição composta (incremento) (++)
        x++; // Equivale a x = x + 1

        Console.WriteLine("\nAtribuição composta incremento (++)");
        Console.WriteLine("Novo valor de x: (++)" + x);

        //Atribuição composta (+=)
        x += 10; // Equivale a x = x + 10

        Console.WriteLine("\nAtribuição composta (+=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição composta (-=)
        x -= 10; // Equivale a x = x - 10

        Console.WriteLine("\nAtribuição composta (-=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição composta (*=)
        x *= 10; // Equivale a x = x * 10

        Console.WriteLine("\nAtribuição composta (*=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição composta (/=)
        x /= 10; // Equivale a x = x / 10

        Console.WriteLine("\nAtribuição composta (/=)");
        Console.WriteLine("Novo valor de x: " + x);
    }
}
namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===Verificador de número pares e ímpares=====");
        Console.WriteLine("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = num % 2;

        if (result == 0)
        {
            Console.WriteLine($"O número {num} é par.");
        }
        else
        {
            Console.WriteLine($"O número {num} é ímpar.");
        }
    }
}
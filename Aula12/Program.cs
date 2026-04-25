namespace Aula12;

public class Program
{
    public static void Main()
    {
        /*
        EX1:
        int i = 0;

        while (i <= 10000)
        {
            Console.WriteLine(i);
            i++;
        }
        
        EX2:
        */
        double budget = 100;

        while (budget > 0)
        {
            Console.WriteLine(budget);
            budget--;
        }
        Console.WriteLine("Saldo insuficiente");
    }
}
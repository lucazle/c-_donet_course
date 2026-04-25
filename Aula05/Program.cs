namespace Aula05;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("=====Calculadora=====");

        Console.WriteLine("Digite o primeiro número:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Digite o primeiro número:");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int sum = n1 + n2;
        int subtraction = n1 - n2;
        int multiplication = n1 * n2;
        int division = n1 / n2;
        int module = n1 % n2;

        Console.WriteLine("O valor da soma é " + sum);
        Console.WriteLine("O valor da subtração é " + subtraction);
        Console.WriteLine("O valor da multiplicação é " + multiplication);
        Console.WriteLine("O valor da divisão é " + division);
    }
}
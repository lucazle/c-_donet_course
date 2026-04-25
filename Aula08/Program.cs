namespace Aula08;

public class Program
{
    static void Main()
    {
        Console.WriteLine("====Operadores relacionais====");
        Console.WriteLine("Digite o primeiro número");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        //Operador de comparação (==)
        if (x == y)
        {
            result = "X is equal to Y";
        }
        else
        {
            result = "X its no equal to Y";
        }
        Console.WriteLine("\nIgualdade (==): " + result);

        //Operador de diferença (!=)
        if (x != y)
        {
            result = "X is different from Y";

        }
        else
        {
            result = "X is equal to Y";
        }
        Console.WriteLine("\nDiferença (!=): " + result);

        //Operador maior que (>)
        if (x > y)
        {
            result = "X is greater than Y";
        }
        else
        {
            result = "X is not greater than Y";
        }
        Console.WriteLine("\nMaior que (>): " + result);

        //Operador menor que (<)
        if (x < y)
        {
            result = "X é menor que Y";
        }
        else
        {
            result = "X não é menor que Y";
        }
        Console.WriteLine("\nMenor que (<): " + result);

        //Operador maior ou igual (>=)
        if (x >= y)
        {
            result = "X is greater than or equal to Y";
        }
        else
        {
            result = "X its not greater than or equal Y";
        }
        Console.WriteLine("\nMaior ou igual que (>=): " + result);

        //Operador menor ou igual (<=)
        if (x <= y)
        {
            result = "X é menor ou igual a Y";
        }
        else
        {
            result = "X não é menor ou igual a Y";
        }
        Console.WriteLine("\nMenor ou igual que (<=): " + result);


    }   
}
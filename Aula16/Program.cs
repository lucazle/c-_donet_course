namespace Aula16;

public class Program
{
    public static void Main(string[] args)
    {
        var separador = "-----------------------------";
        //1. Declaração de um array inicializando com valores
        String[] fruits = { "Maçã", "Banana", "Caju", "Manga" };

        //2. Acessar os elementos do array
        Console.WriteLine(fruits[0]);

        Console.WriteLine(separador);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separador);

        //3. Contagem de elementos
        Console.WriteLine("Quantidade de índices: " + fruits.Length);

        Console.WriteLine(separador);

        //4. Alterar um elemento do array
        Console.WriteLine("Valor antes da alteração " + fruits[1]);
        fruits[1] = "Abacaxi";
        Console.WriteLine("Valor após a alteração " + fruits[1]);

        Console.WriteLine(separador);

        //5. Declaração de um array sem inicializar com valores
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
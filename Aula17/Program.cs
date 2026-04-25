namespace Aula17;

public class program
{
    public static void Main()
    {

        string separador = "-----------------------------";

        //1. Declaração com inicialização de valores 
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pera"
        };
        //2. Acessar elementos da lista
        Console.WriteLine(fruits[2]);

        Console.WriteLine(separador);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separador);
        //3. Adicionar elementos à lista
        fruits.Add("Banana");
        fruits.Add("Maçã");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separador);
        //4. Remover elementos da lista
        fruits.Remove("Abacate");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separador);
        //5. Contagem de elementos

        Console.WriteLine("Contagem de frutas: " + fruits.Count);

        Console.WriteLine(separador);
        //6. Modificar um elemento

        fruits[2] = "Maracujá";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separador);
        //7. Limpar a lista
        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separador);
        //8. Declarar sem inicializar
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(separador);

    }
}
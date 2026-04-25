namespace Aula11;

public class Program
{
    public static void Main()
    {
        /*
        EX1:
        int number = 2;

        switch (number)
        {
            case 1:
                Console.WriteLine("O número é 1");
                break;

            case 2:
                Console.WriteLine("O número é 2");
                break;
        }
        
        EX2:
        Console.WriteLine("====Dia da semana===");
        Console.WriteLine("Digite um número de 1 a 7");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-Feira");
                break;
            case 3:
                Console.WriteLine("Terça-Feira");
                break;
            case 4:
                Console.WriteLine("Quarta-Feira");
                break;
            case 5:
                Console.WriteLine("Quinta-Feira");
                break;
            case 6:
                Console.WriteLine("Sexta-Feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Dia inválido");
                break;
        }
        
        EX3
        */
        Console.WriteLine("===Desempenho escolar===");
        Console.WriteLine("Digite sua nota");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score)
        {
            case 10:
            case 9:
                Console.WriteLine("ótimo");
                break;

            case 8:
            case 7:
                Console.WriteLine("boa");
                break;

            case 6:
                Console.WriteLine("regular");
                break;

            case 5:
                Console.WriteLine("ruim");
                break;

            default:
                Console.WriteLine("horrível");
                break;
                
        }
    }

}
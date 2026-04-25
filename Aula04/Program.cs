namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("----CDASTRO DE USUÁRIO----");

        //Solicitar o nome de usuário
        Console.WriteLine("Digite seu nome de usuário: ");
        string name = Console.ReadLine();

        //Solicitar idade do usuário
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------------");

        Console.WriteLine("Nome de usuário: " + name);
        Console.WriteLine("Idade: " + age);

    }
}
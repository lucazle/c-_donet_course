namespace Aula10;

public class Program
{
    public static void Main()
    {

        bool varContinue = true;

        while (varContinue){
            Console.WriteLine("===Calculadora Simples===\n");

            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecione o tipo de operação

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("Digite o número da operação: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double res = 0;
            //Condições
            if (operation == 1)
            {
                res = num1 + num2;
            }
            else if (operation == 2)
            {
                res = num1 - num2;
            }
            else if (operation == 3)
            {
                res = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
            Console.WriteLine("\n O resultado é: " + res + "\n");

            Console.WriteLine("\n Deseja realizar outra operação? (s/n)\n");

            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }
        }

        Console.WriteLine("Obrigado por usar a calculadora! Até a próxima.");

    }
}

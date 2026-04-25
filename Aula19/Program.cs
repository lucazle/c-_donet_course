namespace Aula19;

using System.Globalization;
using System.IO;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        //1. Estrutura
        string path = @"C:\Users\lucas\source\repos\course\Aula19\";
        string fileName = "Lista_de_Compras.txt";
        string filePath = path + fileName;

        List<string> shoopingList = new List<string>();

        //2. Lógica
        if (File.Exists(filePath))
        {
            shoopingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n=== Lista de Compras===");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir Lista");
            Console.WriteLine("4. Limpar Lista");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Escolha um número para continuar");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("\nDigite o nome do item para adicionar: ");
                    string itemInsert = Console.ReadLine();
                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoopingList.Add(itemInsert);
                        Console.WriteLine($"\nItem '{itemInsert}' adicionado com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Item inválido. Tente novamente.");
                    }
                break;
                
                case "2":
                    Console.WriteLine("\nDigite o nome do item para remover: ");
                    string itemDelete = Console.ReadLine();
                    if (shoopingList.Remove(itemDelete))
                    {
                        Console.WriteLine($"\nItem '{itemDelete}' removido com sucesso");

                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemDelete}' não encontrado na lista.");
                    }
                break;

                case "3":
                    Console.WriteLine("\nItens na sua lista de compras");
                    if (shoopingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista de compras está vazia");
                    }
                    else
                    {
                        for(int i = 0; i < shoopingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoopingList[i]}");
                        }
                    }
                break;

                case "4":
                    shoopingList.Clear();
                    Console.WriteLine("\nLista de compras limpa com sucesso");
                    break;

                case "5":
                    File.WriteAllLines(filePath, shoopingList);
                    Console.WriteLine("Lista de compras salva. Saindo do programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                break;
            }
        }
    }
}
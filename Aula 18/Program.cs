namespace Aula18;
using System.IO;


public class Program
{
    public static void Main()
    {
        /*1. Criar um arquivo

        string content = "Hello World!";

        System.IO.File.WriteAllText("file2.txt", content);

        Console.WriteLine("Arquivo criado com sucesso!");

        2. Criar um arquivo em local específico
        

        string path = @"C:\\Users\\lucas\\source\\repos\\course\\Aula 18\fileName.txt";

        string content = "Hello World!";

        File.WriteAllText(path, content);

        Console.WriteLine("Arquivo criado com sucesso!");

        3. Criar um arquivo Word
        
        string path = @"C:\\Users\\lucas\\source\\repos\\course\\Aula 18\";
        string fileName = "myDocument.Doc";
        string filePath = path + fileName;

        string content = "Hello World!";

        File.WriteAllText(filePath, content);

        Console.WriteLine("Arquivo Word criado com sucesso!");


        //4. Inserir um texto em um arquivo existente
        
        string path = @"C:\\Users\\lucas\\source\\repos\\course\\Aula 18\";
        string fileName = "fileName.txt";
        string filePath = path + fileName;

        string additionalContent = "Curso de C# e .NET";

        File.AppendAllText(filePath, additionalContent); 

        Console.WriteLine("Arquivo atualizado com sucesso!");

        //5. Ler o conteúdo de um arquivo
        */

        string path = @"C:\\Users\\lucas\\source\\repos\\course\\Aula 18\";
        string fileName = "fileName.txt";
        string filePath = path + fileName;
         
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);



    }
}
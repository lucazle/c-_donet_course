namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===Operadores Lógicos===");

        bool isLogged = true;
        bool isAdmin = false;

        Console.WriteLine("Informações do usuário:");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso de administrador: " + isAdmin);

        Console.WriteLine("\nPermissões");

        //Operador OR (||)
        if (isLogged || isAdmin)
        {
            Console.WriteLine("Acesso concedido.");
        }
        else
        {
            Console.WriteLine("Acesso negado.");
        }

        //Operador AND (&&)
        if (isLogged && isAdmin)
        {
            Console.WriteLine("Acesso ao painel de administração concedido.");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de administraçã negado.");
        }

        //Operador NOT (!)
        if (!isLogged)
        {
            Console.WriteLine("Usuário não logado.");
        }
        else
        {
            Console.WriteLine("Usuário logado.");
        }

    }
}
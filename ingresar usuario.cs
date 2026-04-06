using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string a;
        Console.WriteLine("USUARIO");
        Console.WriteLine("INGRESE LA CONTRASEÑA");
        a = Console.ReadLine();
        if (a == "Password123")
            Console.WriteLine("BIENVENIDO USUARIO");
        else
            Console.WriteLine("ACCESO DENEGADO");



    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DIAS DE LA SEMANA");
        Console.WriteLine("INGRESA UN NUMERO DEL 1 AL 7");
        double a;
        a = double.Parse(Console.ReadLine());
        if (a >= 1 && a <= 5)
            Console.WriteLine("ES UN DIA ENTRE SEMANA\n");
        else if (a == 6 || a == 7)
            Console.WriteLine("ES FIN DE SEMANA\n");


    }
}
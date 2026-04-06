internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SI LA EDAD ES MAYOR DE 18 LA PERSONA ES MAYOR DE EDAD");
        Console.WriteLine("ESCRIBE TU EDAD");
        double a;
        a = double.Parse(Console.ReadLine());
        if (a >= 17)
            Console.WriteLine("eres mayor de edad");
        else
            Console.WriteLine("eres menor de edad");
    }
}
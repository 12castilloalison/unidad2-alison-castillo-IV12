internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ALUMNO APROBADO O REPROBADO");
        Console.WriteLine("COLOQUE SU NOTA");
        double a;
        a = double.Parse(Console.ReadLine());
        if (a <= 70)
            Console.WriteLine("ESTA REPROBADO");
        else
            Console.WriteLine("ESTA APROBADO");


    }
}
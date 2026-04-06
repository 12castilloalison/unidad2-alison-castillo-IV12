internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SE CALCULA QUE TAN EFICIENTE ES UNA CALIFICACION");
        Console.WriteLine("ESCRIBE LA CALIFICACION");
        double a;
        a = double.Parse(Console.ReadLine());
        if (a <= 60)
            Console.WriteLine("la calificaciones deficiente");
        else if (a <= 70)
            Console.WriteLine("la calificacion es regular");
        else if (a <= 80)
            Console.WriteLine(" la calificacion es buena");
        else if (a <= 90)
            Console.WriteLine(" la calificacion es buena");
        else
            Console.WriteLine(" la calificacion es excelente");
        


    }
}
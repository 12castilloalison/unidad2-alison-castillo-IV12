internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TRIANGULO EQUILATERO ESCALENO O ISOCELES");
        Console.WriteLine("ANGULO 1");
        double a, b, c;
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("angulo 2");
        b= double.Parse(Console.ReadLine());
        Console.WriteLine("ANGULO 3");
        c = double.Parse(Console.ReadLine());
        if (a + b + c == 180)
            if (a == b && b == c)
                Console.WriteLine("ES UN TRTIANGULO EQULATERO");
            else if (a == b || a == c || b == c)
                Console.WriteLine("ES UN TRIANGULO ISOCELES");
            else
                Console.WriteLine("ES UN TRIANGULO ESCALENO");
        else
            Console.WriteLine(" EL TRIANGULO NO ES VALIDO");




    }
}
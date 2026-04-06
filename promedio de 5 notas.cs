internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("SI LA EDAD ES MAYOR DE 18 LA PERSONA ES MAYOR DE EDAD");
        Console.WriteLine("INGRESE LA NOTA 1 ");
        double a, b,c,d,e, promedio;
        a= double.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE LA NOTA 2 ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE LA NOTA 3 ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE LA NOTA 4 ");
        d = double.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE LA NOTA 5 ");
        e = double.Parse(Console.ReadLine());
        promedio = (a + b + c + d + e) / 5;
        Console.WriteLine("su promedio es de: " + promedio);

        if (a >=61)
            Console.WriteLine("APROBADO");
        else
            Console.WriteLine("REPROBADO");
           
        
        }

    }
            

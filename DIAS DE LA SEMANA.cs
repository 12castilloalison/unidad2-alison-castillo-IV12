internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NUMEROS DE LOS DIAS DE LA SEMANA");
        Console.WriteLine("INGRESE LOS NUMEROS DE LOS DIAS DE LA SEMANA(1-7)");
        double a;
        a = double.Parse(Console.ReadLine());
        if (a== 1)
            Console.WriteLine("HOY ES LUNES");
        else if ( a== 2)
            Console.WriteLine("HOY ES MARTES");
        else if (a == 3)
            Console.WriteLine("HOY ES MIERCOLES");
        else if ( a==4)
            Console.WriteLine("HOY ES JUEVES");
        else if ( a == 5)
            Console.WriteLine("HOY ES VIERNES");
        else if ( a== 6)
            Console.WriteLine("HOY ES SABADO");
        else if ( a == 7)
            Console.WriteLine("HOY ES DOMINGO");







    }





}

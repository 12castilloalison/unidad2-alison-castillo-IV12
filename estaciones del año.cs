internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("INGRESE EL DIA");
        double dia, mes;
        dia = double.Parse(Console.ReadLine());
        Console.WriteLine("INGRSE EL MES (1-12)");
        mes = double.Parse(Console.ReadLine());
        if (mes == 12)
            if (dia >= 21)
                Console.WriteLine("verano");
            else
                Console.WriteLine("primavera");
        else if (mes == 1 || mes == 2)
            Console.WriteLine("verano");
        else if (mes == 3)
            if (dia >= 21)
                Console.WriteLine("otoño");
            else
                Console.WriteLine("verano");
        else if (mes == 4 || mes == 5)
            Console.WriteLine("otoño");
        else if (mes == 6)
            if (dia >= 21)
                Console.WriteLine("invierno");
            else
                Console.WriteLine("otoño");
        else if (mes == 7 || mes == 8)
            Console.WriteLine("invierno");
        else if (mes == 9)
            if (dia >= 21)
                Console.WriteLine("primavera");
            else
                Console.WriteLine("invierno");
        else if (mes == 10 || mes == 11)
            Console.WriteLine("primavera");
        else
            Console.WriteLine("el mes colocado no es valido");




    }
}
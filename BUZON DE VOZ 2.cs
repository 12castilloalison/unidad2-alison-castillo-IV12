using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        double a;
        Console.WriteLine("BUZÓN DE VOZ");
        Console.WriteLine("OPCIONES GENERALES");
        Console.WriteLine("1.Ventas");
        Console.WriteLine("2.Recepcción");
        Console.WriteLine("3.Dirección");
        Console.WriteLine("4.Compras");
        Console.WriteLine("Seleccione la opción que desse (1-4)");
        a = Double.Parse(Console.ReadLine());
        if (a == 1)
            Console.WriteLine("Bienvenido a ventas\n Encargado: Juan perez\n Correo: ventas@gmail.com");
        else if (a == 2)
            Console.WriteLine("Bienvenido a recepción\n Encargado: María Lopez\n Correo: recepcion@gmail.com");
        else if (a == 3)
            Console.WriteLine("Bienvenido a recepcion\n Encargado: Carlos Gomez\n Correo: direccion@gmail.com");
        else if (a == 4)
            Console.WriteLine("Bienvenido a compras\n Encargado: Ana Martinez\n Correo: compras@gmail.com");

       










    }
}
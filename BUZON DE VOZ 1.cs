internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BUZON DE VOZ");
        Console.WriteLine("OPCIONES GENERALES");
        Console.WriteLine("1.PRODUCTOS");
        Console.WriteLine("2.SOPORTE TECNICO");
        Console.WriteLine("INFORMACION SOBRE NUESTRO NEGOCIO");
        Console.WriteLine("COMUNICARSE DIRECTAMENTE CON UN OPERADOR");
        Console.WriteLine("SELECCIONAR LA OPCION QUE DESEE (1-4");
        double a;
        a = double.Parse(Console.ReadLine());
        if (a == 1)
            Console.WriteLine("En un segundo se le estaran mostrando los productos...");
        else if (a == 2)
            Console.WriteLine(" En breve le atenderá nuestro equipo de soporte tecnico");
        else if (a == 3)
            Console.WriteLine("Estamos ubicados en la 29 calle 1-78 zona 1, horario de 7am-10pm");
        else if (a == 4)
            Console.WriteLine("En breve le comunicaremos con un operador ..");









    }
}
    using System;

class Problema02
{
    static void Main(string[] args)
    {
        //Variable
        int n1, n2, c, r;

        //Entra
        Console.WriteLine("Numero 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero 2: ");
        n2 = int.Parse(Console.ReadLine());

        //Proceso
        c = n1 / n2;
        r = n1 % n2;

        //Salida
        Console.WriteLine("");
        Console.WriteLine("Cociente : "+ c);
        Console.WriteLine("Residuo: "+ r);
        Console.ReadLine();
    }
}
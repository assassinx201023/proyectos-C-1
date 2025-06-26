using System;

class Program03
{

    static void Main(string[] args)

    {
        //VARIABLES
        float vv, igv, pv;

        //Entrada de datos
        Console.Write("Valor de venta: ");
        vv = float.Parse(Console.ReadLine());

        //Proceso
        igv = vv * 0.19f;
        pv = vv + igv;

        //Salida de datos
        Console.WriteLine(" ");
        Console.WriteLine("IGV: " + igv);
        Console.WriteLine("Precio de venta: " + pv);
        Console.ReadLine();

    }
}
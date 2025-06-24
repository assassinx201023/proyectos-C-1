class problema01
{
    static void Main(string[] args)
    {
        //VARIABLES
        int n1, n2, s;

        //ENTRADA DE DADOS
        System.Console.Write("Numero 1: ");
        n1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Numero 2: ");
        n2 = int.Parse(System.Console.ReadLine());

        //PROCESSAMENTO
        s = n1 + n2;

        //SAIDA DE DADOS
        System.Console.WriteLine("");
        System.Console.WriteLine("SUMA = " + s);
        System.Console.ReadLine();
    }
}

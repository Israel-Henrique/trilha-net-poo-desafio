using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
internal static class Program
{
    public static void Main(string[] args)
    {
        Smartphone celular = new Iphone("4002-8922", "iPhone SE", "o que é isso?", 99);
        celular.Ligar();
        celular.ReceberLigacao();
        celular.InstalarAplicativo("Sonic Runners");
        celular = new Nokia("0500 2012-007", "para doar 7 reais", "ainda não sei o que é isso", 8);
        celular.InstalarAplicativo("Skyline Skaters");
    }
}
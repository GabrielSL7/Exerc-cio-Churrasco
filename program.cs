using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Churrasco ---");

        Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
        int adultosComBebida = int.Parse(Console.ReadLine());

        Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
        int adultosSemBebida = int.Parse(Console.ReadLine());

        Console.Write("Crianças........................................: ");
        int criancas = int.Parse(Console.ReadLine());

        int totalAdultos = adultosComBebida + adultosSemBebida;

        double carne = totalAdultos * 400 + criancas * 200; // em gramas
        double acompanhamento = totalAdultos * 200 + criancas * 200; // em gramas
        double cerveja = adultosComBebida * 2; // em litros
        double refrigerante = adultosSemBebida * 0.5 + criancas * 0.5; // em litros
        double agua = totalAdultos * 0.4 + criancas * 0.4; // em litros

        Console.WriteLine();
        Console.WriteLine($"Carne.............: {carne / 1000:F1}kg");
        Console.WriteLine($"Acompanhamentos...: {acompanhamento / 1000:F1}kg");
        Console.WriteLine($"Cerveja...........: {cerveja:F1}l");
        Console.WriteLine($"Refrigerante......: {refrigerante:F1}l");
        Console.WriteLine($"Água..............: {agua:F1}l");
    }
}

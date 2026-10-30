using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Hechos iniciales
        var hechos = new HashSet<string> { "TienePlumas" };
        Console.WriteLine("Hecho inicial: TienePlumas");

        Console.WriteLine("\nAplicando reglas:");
        //Si tiene plumas es un ave
        if (hechos.Contains("TienePlumas"))
        {
            hechos.Add("EsUnAve");
            Console.WriteLine("Deducción: Es un ave");
        }
        //Si es un ave tiene pico
        if (hechos.Contains("EsUnAve"))
        {
            hechos.Add("TienePico");
            Console.WriteLine("Deducción: Tiene pico");
        }
        //Resultado final (conocimiento acumulado)
        Console.WriteLine("\nBase de hechos final:");
        foreach (var h in hechos)
        {
            Console.WriteLine($"{h}");
        }
    }
}
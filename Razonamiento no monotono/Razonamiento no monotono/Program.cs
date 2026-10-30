using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Razonamiento no monótono:\n");

        // Hechos iniciales
        List<string> hechos = new List<string> { "EsUnAve" };
        Console.WriteLine("HECHO INICIAL:");
        Console.WriteLine("Es un ave");

        // Conclusión inicial
        hechos.Add("Vuela");
        Console.WriteLine("\nDEDUCCIÓN PROVISIONAL (Por defecto):");
        Console.WriteLine("Como es un ave, se asume que: Vuela");

        // Nueva información
        Console.WriteLine("\nNUEVA INFORMACIÓN:");
        hechos.Add("EsPingüino");
        Console.WriteLine("Se descubre que: Es un pingüino");

        // Ajuste y Retractación
        Console.WriteLine("\nAPLICANDO REGLAS DE AJUSTE:");
        if (hechos.Contains("EsPingüino"))
        {
            // Se borra la deducción anterior
            hechos.Remove("Vuela");
            hechos.Add("NoVuela");
            Console.WriteLine("Por ser pingüino, se cancela la deducción 'Vuela'.");
        }

        // Conclusión final
        Console.WriteLine("\nCONCLUSIÓN FINAL:");

        if (hechos.Contains("EsPingüino") && hechos.Contains("NoVuela"))
        {
            Console.WriteLine("RESULTADO: El animal es un ave, pero al ser un");
            Console.WriteLine("           pingüino, la conclusión final es que NO VUELA.");
        }
        else if (hechos.Contains("Vuela"))
        {
            Console.WriteLine("RESULTADO: El animal es un ave y SÍ VUELA.");
        }
    }
}
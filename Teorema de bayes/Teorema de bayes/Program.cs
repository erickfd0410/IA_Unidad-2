using System;

class Program
{
    static void Main()
    {
        // 1. Servidor
        double pCaida = 0.05;                 // P(Caída)
        double pNormal = 0.95;                // P(Normal)
        double pPicoDadoCaida = 0.90;         // P(Pico | Caída)
        double pPicoDadoNormal = 0.15;        // P(Pico | Normal)

        double pPico = pPicoDadoCaida * pCaida + pPicoDadoNormal * pNormal;   // P(Pico)
        double r1 = (pPicoDadoCaida * pCaida) / pPico;                        // P(Caída | Pico)
        Console.WriteLine("1. P(Caída | Pico) = " + (r1 * 100).ToString("F2") + "%");

        // 2. Spam
        double pSpam = 0.40;                  // P(Spam)
        double pNoSpam = 0.60;                // P(No Spam)
        double pMsgDadoSpam = 0.80 * 0.70;    // P(Gana y Dinero | Spam)
        double pMsgDadoNoSpam = 0.10 * 0.05;  // P(Gana y Dinero | No Spam)

        double pMsg = pMsgDadoSpam * pSpam + pMsgDadoNoSpam * pNoSpam;        // P(Mensaje)
        double r2 = (pMsgDadoSpam * pSpam) / pMsg;                            // P(Spam | Mensaje)
        Console.WriteLine("2. P(Spam | Gana Dinero) = " + (r2 * 100).ToString("F2") + "%");

        // 3. Urnas
        double pUrna = 1.0 / 3.0;             // P(A) = P(B) = P(C)
        double pRojaDadoA = 3.0 / 8.0;        // P(Roja | A)
        double pRojaDadoB = 2.0 / 3.0;        // P(Roja | B)
        double pRojaDadoC = 2.0 / 5.0;        // P(Roja | C)

        double pRoja = pRojaDadoA * pUrna + pRojaDadoB * pUrna + pRojaDadoC * pUrna;  // P(Roja)
        double r3 = (pRojaDadoA * pUrna) / pRoja;                                     // P(A | Roja)
        Console.WriteLine("3. P(Urna A | Roja) = " + (r3 * 100).ToString("F2") + "%");
    }
}
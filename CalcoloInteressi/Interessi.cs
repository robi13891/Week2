using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scrivere una funzione che dato un importo di denaro iniziale,
// un interesse annuo e un numero di anni permette di calcolare
// l’importo di denaro accresciuto degli interessi dopo il numero di anni passati
// Esempio
// Voglio vincolare 10000 euro per 3 anni con un interesse del 3%
// Dopo 1 anno : 10000 + (10000 * 3 / 100) = 10000 + 300 = 10300
// Dopo 2 anni : 10300 + (10300 * 3 / 100) = 10300 + 309 = 10609
// Dopo 3 anni : 10609 + (10609 * 3 / 100) = 10609 + 318,27 = 10609 

namespace CalcoloInteressi
{
    class Interessi
    {
        internal static void Start()
        {
            
            Console.WriteLine("Inserisci l'importo iniziale");
            float importoIniziale = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'interesse in percentuale");
            int interesse = int.Parse(Console.ReadLine());
            Console.WriteLine("Per quanti anni vorresti investire?");
            int anni = int.Parse(Console.ReadLine());
            
            float totaleIt = CalcoloCifraTotaleIt(importoIniziale, interesse, anni);
            Console.WriteLine("Totale metodo iterativo: " + totaleIt);
            float totaleRi = CalcoloCifraTotaleRi(importoIniziale, interesse, anni);
            Console.WriteLine("Totale metodo ricorsivo: " + totaleRi);
        }

        private static float CalcoloCifraTotaleRi(float importoIniziale, int interesse, int anni)
        {

            if (anni == 1)
            {
                float totale = importoIniziale + (importoIniziale * interesse/100);
                return totale;
            }
            else
            {
                return CalcoloCifraTotaleRi(importoIniziale + (importoIniziale * interesse / 100), interesse, (anni - 1));
            }
                
                
        }

        private static float CalcoloCifraTotaleIt(float importoIniziale, int interesse, int anni)
        {
            float importoParziale = importoIniziale;
            float interesseParziale = 0;
            for (int i = 1; i <= anni; i++)
            {

                interesseParziale = (importoParziale * interesse) / 100;
                importoParziale = importoParziale + interesseParziale;

            }
            
            return importoParziale;
        }
    }
}

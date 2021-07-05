using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciIterationCalculator
    {
        internal static void Start()
        {
            Console.WriteLine("Quale numero di Fibonacci vuoi calcolare?");
            int indice = int.Parse(Console.ReadLine());
            int risultatoIt = FibonacciIterazione(indice);
            Console.WriteLine("Risultato calcolato con metodo iterativo: " + risultatoIt);
            int risultatoRi = FibonacciRicorsione(indice);
            Console.WriteLine("Risultato calcolato con metodo ricorsivo: " + risultatoRi);
        }

        private static int FibonacciRicorsione(int indice)
        {
            if(indice==1 || indice == 2)
            {
                return 1;
            }
            else
            {
                int prec1 = FibonacciRicorsione(indice - 1); 
                int prec2 = FibonacciRicorsione(indice - 2);
                return prec1 + prec2;
            }
        }

        private static int FibonacciIterazione(int numero)
        {
            if (numero == 1 || numero == 2)
            {
                return 1;
            }
            else
            {
                int prec1 = 1;
                int prec2 = 1;
                int i = 2;
                int risultato = 0;
                while (i < numero)
                {
                    risultato = prec1 + prec2;
                    prec1 = prec2;
                    prec2 = risultato;
                    i++;
                }
                return risultato;
            }
            
        }
    }
}

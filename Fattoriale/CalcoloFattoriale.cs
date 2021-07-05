using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoriale
{
    class CalcoloFattoriale
    {
        internal static void Start()
        {
            Console.WriteLine("Inserisci il numero di cui vuoi calcolare il fattoriale");
            int numero = int.Parse(Console.ReadLine());
            int risultatoIt = FattorialeIterazione(numero);
            Console.WriteLine("Risultato fattoriale con metodo iterativo: " + risultatoIt);
            int risultatoRi = FattorialeRicorsione(numero);
            Console.WriteLine("Risultato fattoriale con metodo ricorsivo: " + risultatoRi);
        }

        private static int FattorialeRicorsione(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                return numero*FattorialeRicorsione(numero-1);
            }
        }

        private static int FattorialeIterazione(int numero)
        {
            if(numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                int risultato = 1;
                for(int i = 2; i <= numero; i++)
                {
                    risultato = risultato * i;
                }
                return risultato;
            }
        }
    }
}

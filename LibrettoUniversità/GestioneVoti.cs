using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Scrivere un programma che gestisca i voti degli esami di uno studente.
//In particolare chieda in ingresso un nome, un cognome e i voti degli esami sostenuti e ne calcoli la media

//Stampa a video:
//Nome: Arianna
//Cognome: Bolzoni
//Media: 22,6


namespace LibrettoUniversità
{
    class GestioneVoti
    {
        internal static void Start()
        {
            Console.WriteLine("Inserisci nome studente");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome studente");
            string cognome = Console.ReadLine();
            List<int> voti = new List<int>();
            
            int somma = GestioneVoti(ref voti);
            float media = CalcoloMedia();
            Stampa(nome, cognome, media);

        }

        private static int GestioneVoti(ref List<int> voti)
        {
            int KeepGoing = 1;
            int counter = 0;
            int somma = 0;
            while(KeepGoing == 1)
            {
                Console.WriteLine("Inserisci un voto:");
                int voto = int.Parse(Console.ReadLine());
                somma = somma + voto;
                voti.Add(voto);
                counter++;
                Console.WriteLine("Se vuoi inserire un altro voto premi 1, altrimenti premi 0");
                KeepGoing = int.Parse(Console.ReadLine());
            }
            return somma;
        }

        private static void Stampa(string nome, string cognome, float media)
        {
            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Cognome:" + cognome);
            Console.WriteLine("Media:" + media);
        }

        private static float CalcoloMedia()
        {
            int KeepGoing = 1;
            float media = 0;
            int somma = 0;
            int counter = 0;
            while (KeepGoing == 1)
            {
                Console.WriteLine("Inserisci un voto:");
                int voto = int.Parse(Console.ReadLine());
                counter++;
                somma = somma + voto;
                Console.WriteLine("Se vuoi inserire un altro voto premi 1, altrimenti premi 0");
                KeepGoing = int.Parse(Console.ReadLine());
            }
            media = somma / counter;
            return media;
        }
    }
}

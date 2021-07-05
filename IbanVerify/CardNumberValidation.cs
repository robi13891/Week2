using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbanVerify
{
    class CardNumberValidation
    {

        public static void Start()
        {
            int[] cardNumber = InsertCardNumber();
            int sumCardNumber = SumCardNumber(cardNumber);
            VerifyCardNumber(sumCardNumber);
        }
        public static int[] InsertCardNumber()
        {
            int[] cardNumber = new int[16];
            Console.WriteLine("Inserisci le cifre della carta");
            for (int i = 0; i < cardNumber.Length; i++)
            {
                Console.Write((i + 1) + ": ");
                cardNumber[i] = int.Parse(Console.ReadLine());
            }
            return cardNumber;
        }

        public static int SumCardNumber(int[] cardNumber)
        {

            for (int i = 0; i < cardNumber.Length; i++)
            {
                cardNumber[i] = cardNumber[i] * 2;
                if (cardNumber[i] >= 10)
                {
                    cardNumber[i] = cardNumber[i] - 9;
                }
            }
            int sumCardNumber = 0;
            for (int j = 0; j < cardNumber.Length; j++)
            {
                sumCardNumber = sumCardNumber + cardNumber[j];
            }
            return sumCardNumber;
        }

        public static void VerifyCardNumber(int sumCardNumber)
        {
            if (sumCardNumber % 10 == 0)
            {
                Console.WriteLine("Carta Valida");
            }
            else
            {
                Console.WriteLine("Carta non valida");
            }
        }
    }
}

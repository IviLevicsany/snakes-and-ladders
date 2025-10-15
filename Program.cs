using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_ladders
{
    internal class Program
    {
        const int palya = 100;
        Random rnd = new Random();
        int hely = 1;
        public Program()
        {
            Console.WriteLine(Letra(12));
        }

        public void Kigyo(int i)
        {
            int[] kigyo_hely = {34,16,90,67,23};
            int[] kigyo_ertek = {8,6,10,12,5};
            for (int i = 0; i < 5; i++)
            {
                if (hely == kigyo_hely[i])
                {
                    hely -= kigyo_ertek[i];
                }
            }
        }
        /*public void Letra(int i)
        {
            int[] letra_hely = {53,26,71,86,12};
            int[] letra_ertek = {11,3,15,6,9};
            foreach (int n in letra_hely)
                if (i.)
            {
                hely += letra_ertek[i];
            }
        }
        */
        public int Letra(int i)
        {
            int[] letra_hely = { 53, 26, 71, 86, 12 };
            int[] letra_ertek = { 11, 3, 15, 6, 9 };

            for (int index = 0; index < letra_hely.Length; index++)
            {
                if (i == letra_hely[index])
                {
                    i += letra_ertek[index];
                    break; // megtaláltuk, nem kell tovább keresni
                }
            }

            return i;
        }


        public void Jatek()
        {
            int dobas = rnd.Next(1, 13);
            while (hely < palya)
            {
                hely += dobas;
                if (hely > palya)
                {
                    hely -= dobas;
                }
                Kigyo();
                Letra();
                Console.WriteLine("A te helyed: " + hely);
            }

        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }

    }  
}

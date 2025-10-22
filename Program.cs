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
        int p1_hely = 0;
        int p2_hely = 0;
        public Program()
        {
            Jatek();
        }

        public int Kigyo(int h)
        {
            int[] kigyo_hely = { 34, 16, 90, 67, 23 };
            int[] kigyo_ertek = { 8, 6, 10, 12, 5 };
            for (int i = 0; i < kigyo_hely.Length; i++)
            {
                if (h == kigyo_hely[i])
                {
                    h -= kigyo_ertek[i];
                    Console.WriteLine($"{kigyo_hely[i]} -as helyen kígyóra léptél, {h} -ra csúsztál le!");
                    break;
                }
            }
            
            return h;
        }
        public int Letra(int h)
        {
            int[] letra_hely = { 53, 25, 71, 86, 12 };
            int[] letra_ertek = { 11, 3, 15, 6, 9 };
            for (int i = 0; i < letra_hely.Length; i++)
            {
                if (h == letra_hely[i])
                {
                    h += letra_ertek[i];
                    Console.WriteLine($"{letra_hely[i]} -as helyen létrára léptél, {h} -ra másztál fel!");
                    break;
                }
            }
            return h;
        }

        public void Jatek()
        {
            
            while (p1_hely < palya && p2_hely < palya)
            {
                int dobas1 = rnd.Next(1, 13);
                int dobas2 = rnd.Next(1, 13);
                p1_hely += dobas1;
                p2_hely += dobas2;

                p1_hely = Kigyo(p1_hely);
                p1_hely = Letra(p1_hely);
                Console.WriteLine("1. játékos helye: " + p1_hely);

                p2_hely = Kigyo(p2_hely);
                p2_hely = Letra(p2_hely);
                Console.WriteLine("2. játékos helye: " + p2_hely);

                if (p1_hely >= palya)
                {
                    p1_hely = 100;
                    Console.WriteLine("1. játékos nyert!");
                }
                else if (p2_hely >= palya)
                {
                    p2_hely = 100;
                    Console.WriteLine("2. játékos nyert!");
                }
                Console.WriteLine();
                Console.ReadKey(intercept: true);
            }
            

        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }

    }  
}

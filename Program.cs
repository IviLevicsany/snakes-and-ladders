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
        string p1_nev = "";
        string p2_nev = "";
        public Program()
        {
            Bevezeto();
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
                    if (kigyo_hely[i] == p1_hely)
                    {
                        Console.WriteLine($"{kigyo_hely[i]} -as helyen {p1_nev} kígyóra lépett, {h} -ra csúszott le!");
                    }
                    else if (kigyo_hely[i] == p2_hely)
                    {
                        Console.WriteLine($"{kigyo_hely[i]} -as helyen {p2_nev} kígyóra lépett, {h} -ra csúszott le!");
                    }
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
                    if (letra_hely[i] == p1_hely)
                    {
                        Console.WriteLine($"{letra_hely[i]} -as helyen {p1_nev} létrára lépett, {h} -ra mászott fel!");
                    }
                    else if (letra_hely[i] == p2_hely)
                    {
                        Console.WriteLine($"{letra_hely[i]} -as helyen {p2_nev} létrára lépett, {h} -ra mászott fel!");
                    }
                    break;
                }
            }
            return h;
        }

        public void Bevezeto()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Snakes and Ladders / Kígyók és létrák:");
            Console.WriteLine("A játek lényege az, hogy valamelyik játékos elérje a 100. helyet.");
            Console.WriteLine("A két játékos egy 12-es dobókockával lép előre.");
            Console.WriteLine("A pályán vannak létrák, amikre ha rálépsz felmászol a tetejére és vannak kígyók, amikre ha rálépsz lecsúszol az aljára.");
            Console.WriteLine("A két játékosnak meg kell adniuk a nevüket, majd utánna a gombnyomással halad tovább a játék!");
            Console.WriteLine("Jó szórakozást kívánünk!");
            Console.WriteLine("Készitette: Levi, Norbi, Szabi");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }

        public void Jatek()
        {
            Console.Write("Add meg az első játékos nevét: ");
            p1_nev = Console.ReadLine();
            Console.Write("Add meg a második játékos nevét: ");
            p2_nev = Console.ReadLine();

            while (p1_hely < palya && p2_hely < palya)
            {
                int dobas1 = rnd.Next(1, 13);
                int dobas2 = rnd.Next(1, 13);
                p1_hely += dobas1;
                p2_hely += dobas2;

                p1_hely = Kigyo(p1_hely);
                p1_hely = Letra(p1_hely);
                Console.WriteLine(p1_nev + " helye: " + p1_hely);

                p2_hely = Kigyo(p2_hely);
                p2_hely = Letra(p2_hely);
                Console.WriteLine(p2_nev + " helye: " + p2_hely);

                if (p1_hely >= palya)
                {
                    p1_hely = 100;
                    Console.WriteLine(p1_nev + " nyert!");
                }
                else if (p2_hely >= palya)
                {
                    p2_hely = 100;
                    Console.WriteLine(p2_nev + " nyert!");
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
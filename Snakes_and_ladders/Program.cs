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
        int ossz = 1;
        public Program()
        {
            Kocka();
        }

        public void Kocka()
        {
            int dobas = rnd.Next(1, 13);
        }

        public void Kigyo()
        {
            int[] kigyo_hely = {34, 16, 90, 67, 23};
            int[] kigyo_ertek = {8, 6, 10, 12, 5};
            for (int i = 0; i < palya; i++)
            {
                if (ossz == kigyo_hely[i])
                {
                    ossz -= kigyo_ertek[i];
                }
            }
        }
        public void Letra()
        {
            int[] kigyo_hely = { 53, 26, 71, 86, 12 };
            int[] kigyo_ertek = { 11, 3, 15, 6, 9 };
            for (int i = 0; i < palya; i++)
            {
                if (ossz == kigyo_hely[i])
                {
                    ossz += kigyo_ertek[i];
                }
            }
        }

        public void Jatek()
        {


        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }

    }  
}

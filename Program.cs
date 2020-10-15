using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Ovning2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabler
            int speed;
            string userInput = "";

            //input till speed
            Console.WriteLine("Hur snabbt kör du? ");
            userInput = Console.ReadLine();
            speed = Convert.ToInt32(userInput);

            //checka hur snabbt/vilket straff
            if (speed <= 30)
            {
                Console.WriteLine("Du kör lagligt!!");
            }
            else if (speed > 30 && speed <= 40)
            {
                Console.WriteLine("Du har kört för fort, böter 2000kr.");
            }
            else if ( speed > 40 && speed <= 50)
            {
                Console.WriteLine("Du har kört för fort, böter 3000kr.");
            }
            else if (speed > 50 )
            {
                Console.WriteLine("Du har kört för fort, böter 10000kr. Dessutom blir du av med bilen");
                // räkna ut nhur mycket för snabbt du kör
                int speedDiff = speed - 30;
                // ränka ut hur många månader det motsvarar som du blir av med körkortet
                int months = CardMonths(speedDiff);

                Console.WriteLine("Du blir också av med körkortet i {0} måndader", months);


            }



        Console.ReadKey();
        }
        static int CardMonths(int num)
        {
            if (num > 16 && num <= 20 )
            {
                return 1;
            }
            else if ( num > 20 && num <= 30 )
            {
                return 2;
            }
            else if ( num > 30 && num <= 40 )
            {
                return 3;
            }
            else if ( num > 40 && num <= 50 )
            {
                return 4;
            }
            else if ( num > 50 && num <= 60 )
            {
                return 5;
            }
            else if ( num > 60 && num <= 70 )
            {
                return 6;
            }
            else if ( num > 70 )
            {
                return 100;
            }

            return 0;
        }
    }
}

using System;

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
            if ( speed <= 30 ) {
                Console.WriteLine("Du kör lagligt!!");
            }
            else if (speed <= 40 ) {
                Console.WriteLine("Du har kört för fort, böter 2000kr.");
            }
            else if (speed <= 50 ) {
                Console.WriteLine("Du har kört för fort, böter 3000kr.");
            }
            else {
                Console.WriteLine("Du har kört för fort, böter 10000kr. Dessutom blir du av med bilen");
            }


            Console.ReadKey();
        }
    }
}

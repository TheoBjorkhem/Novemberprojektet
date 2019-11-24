using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variabler
            int tickWin = 0;
            bool alive = true;

            /*
            //Tests
            Tamagotchi t1 = new Tamagotchi();
            t1.name = Console.ReadLine();
            Console.WriteLine("It's name is " + t1.name + ".");


            Laazy l1 = new Laazy();
            l1.name = Console.ReadLine();
            Console.WriteLine("It's name is " + l1.name + ".");

            t1.Feed();
            l1.Feed();

            t1.PrintStats();
            */

            Console.WriteLine("Your job is to take care of these Tamagotchies." +
            "\nThere are 3 different species, Smorts, Angorys and Laazys." +
            //"\nLet's start with one to make it easy." +
            "\nWhich one do you choose?");
            
            Tamagotchi yours = Controll();

            Console.WriteLine("You can use different commands to interact with you Tamagotchi. They are:" +
            "\n1. Feed - You get to feed your Tamagotchi so it doesn't starve." +
            "\n2. Teach - You get to choose a word to tach your Tamagotchi." +
            "\n3. Hi - You Tamagotchi says a word you learned it back. Reduces boredom (which will also kill them)." +
            "\n4. Stats - Shows you the stats of your Tamagotchi(s)." +
            "\n5. Help - Tells you the commands again.");

            while (tickWin < 100 && alive == true)
            {
                Console.WriteLine("Write the number to the option you want to choose.");
                int number = Action();
                if (number == 1)
                {
                    yours.Feed();
                }
                else if (number == 2)
                {
                    yours.Teach();
                }
                else if (number == 3)
                {
                    yours.Hi();
                }
                else if (number == 4)
                {
                    yours.PrintStats();
                }
                else if (number == 5)
                {
                    Help();
                }
                alive = yours.GetAlive();

                tickWin++;
            }

            if(alive == true && tickWin >= 10)
            {
                Console.WriteLine("You Won!");
            }
            else if (alive == false)
            {
                Console.WriteLine(yours.name + " died. You Lose");
            }
            
            //Tamagotchi t1 = new Tamagotchi();
            //t1.name = Controll();
            
            Console.ReadLine();



        }

        //Metoder
        static Tamagotchi Controll()
        {
            string type = " ";
            string[] answers = { "smort", "angory", "laazy", "smorts", "angorys", "laazys", };

            while(!answers.Contains(type))
            {
                type = Console.ReadLine();
                type = type.ToLower();

                if(!answers.Contains(type))
                {
                    Console.WriteLine("That's not a one of the types.");
                    Console.WriteLine("Try again:");
                }
            }

            Console.WriteLine("You choose a " + type + " type.");
            //Tamagotchi yours;

            if (type == "smort")
            {
                Smort yours = new Smort();
                Console.WriteLine("Time to name it.");
                yours.name = Console.ReadLine();
                Console.WriteLine("It's name is " + yours.name + ".");
                return yours;

            }
            else if (type == "angory")
            {
                Angory yours = new Angory();
                Console.WriteLine("Time to name it.");
                yours.name = Console.ReadLine();
                Console.WriteLine("It's name is " + yours.name + ".");
                return yours;

            }
            else
            {
                Laazy yours = new Laazy();
                Console.WriteLine("Time to name it.");
                yours.name = Console.ReadLine();
                Console.WriteLine("It's name is " + yours.name + ".");
                return yours;
            }
            //return yours;
        }
        static void Help()
        {
            Console.WriteLine("You can use different commands to interact with you Tamagotchi. They are:" +
            "\n1. Feed - You get to feed your Tamagotchi so it doesn't starve." +
            "\n2. Teach - You get to choose a word to tach your Tamagotchi." +
            "\n3. Hi - You Tamagotchi says a word you learned it back. Reduces boredom (which will also kill them)." +
            "\n4. Stats - Shows you the stats of your Tamagotchi(s)." +
            "\n5. Help - Tells you the commands again." +
            "\nWrite the number to the option you want to choose.");
        }
        static int Action()
        {
            int numberOut = 0;
            bool succes = false;
            string numberIn = " ";
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            while (succes != true)
            {
                numberIn = Console.ReadLine();
                succes = int.TryParse(numberIn, out numberOut);
                if (!numbers.Contains(numberOut))
                {
                    Console.WriteLine("That's not a valid number. Try again:");
                    succes = false;
                }
            }
            return numberOut;
        }
    }
}

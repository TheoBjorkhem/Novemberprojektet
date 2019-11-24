using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Tamagotchi
    {
        //Variabler
        protected int hunger = 10;
        protected int boredom = 0;
        protected bool isAlive = true;
        static protected Random generator = new Random();
        protected List<string> words = new List<string>();
        static protected List<Tamagotchi> tamagotchiList = new List<Tamagotchi>();
        public string name = " ";
        protected int ticks = 0;

        // statisk lista med alla tamagotchis

        // Konstruktor som lägger till this i listan
        //Metoder
        public Tamagotchi()
        {
            tamagotchiList.Add(this);
        }
        public void Hi()
        {
            TickAll();
            int i = generator.Next(0, words.Count);
            Console.WriteLine(name + ": " + words[i] + ".");
            ReduceBoredom();

        }
        public void Feed()
        {
            TickAll();
            hunger = hunger + 5;
            if (hunger > 10)
            {
                hunger = 10;
            }
            Console.WriteLine("You feed " + name + ". It's now has " + hunger + "/10 filled stomach.");
        }
        public void Teach()
        {
            Console.WriteLine("You decided to teach " + name + " a word. What will it be?");
            string e = Console.ReadLine();
            words.Add(e);
            TickAll();
        }
        public void PrintStats()
        {
            isAlive = GetAlive();
            if (isAlive == true)
            {
                Console.WriteLine("Hunger: " + hunger + "/10 \nBoredom: " + boredom + "/10 \n" + name + " is alive.");
            }
            else if (isAlive == false)
            {
                Console.WriteLine(name + " is not alive.");
            }
        }
        public bool GetAlive()
        {
            if (boredom < 9 && hunger > 0)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }

            return isAlive;
        }
        private void Tick()
        {
            hunger = hunger - 2;
            boredom = boredom + 2;
        }
        public void TickAll()
        {
            // Gå igenom alla, gör nedanstående med dem
            int i = 0;
            while (tamagotchiList.Count > i)
            {
                tamagotchiList[i].Tick();
                i++;
            }
        }

        private void ReduceBoredom()
        {
            TickAll();
            boredom = 0;
            Console.WriteLine(name + " now has a bordedom of " + boredom + "/10.");
        }
        
    }
}

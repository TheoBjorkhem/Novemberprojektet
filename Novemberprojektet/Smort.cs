using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Smort : Tamagotchi
    {

        private void Tick()
        {
            hunger = hunger - 1;
            boredom = boredom + 3;
        }
        public void Teach()
        {
            Console.WriteLine("You decided to teach " + name + " a word. What will it be?");
            string e = Console.ReadLine();
            words.Add(e);

            int i = generator.Next(0,2);

            if(i > 1)
            {
                Console.WriteLine("It wants to learn another word. What will it be?");
                e = Console.ReadLine();
                words.Add(e);
            }

            TickAll();
        }


    }
}

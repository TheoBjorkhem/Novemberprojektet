using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Angory : Tamagotchi
    {
        private void Tick()
        {
            hunger = hunger - 2;
            boredom = boredom + 2;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace hwOOP2
{
    interface IMammal
    {
       
        void Moves(string mammalName, int speed);

        void Sleeps(string mammalName, int hours);

        void Eats(string mammalName, string food);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Contraband
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passengers = generator.Next(1, 4);
            contrabandAmount = 0;
        }
    }
}

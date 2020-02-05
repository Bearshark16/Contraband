using System;
using System.Collections.Generic;
using System.Text;

namespace Contraband
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passengers = generator.Next(1, 5);
            contrabandAmount = generator.Next(1, 5);
        }
    }
}

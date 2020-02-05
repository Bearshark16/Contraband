using System;
using System.Collections.Generic;
using System.Text;

namespace Contraband
{
    class Car
    {
        public static Random generator = new Random();

        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;

        public bool Examine()
        {
            alreadyChecked = true;

            if (contrabandAmount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

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

        private int x;

        public bool Examine()
        {
            alreadyChecked = true;

            if (contrabandAmount == 0)
            {
                return false;
            }
            else
            {
                if (contrabandAmount == 1)
                {
                    x = generator.Next(1, 26);
                    if (x <= 10)
                        return false;
                    else
                        return true;
                }
                else if (contrabandAmount == 2)
                {
                    x = generator.Next(5, 21);
                    if (x <= 10)
                        return false;
                    else
                        return true;
                }
                else if (contrabandAmount == 3)
                {
                    x = generator.Next(10, 16);
                    if (x <= 10)
                        return false;
                    else
                        return true;
                }
                else if (contrabandAmount == 4)
                {
                    x = generator.Next(15, 16);
                    if (x <= 10)
                        return false;
                    else
                        return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

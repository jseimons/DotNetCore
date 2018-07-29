using System;

namespace ClassLibrary.ProjectEuler
{
    /* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
       ... What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */
    public static class SmallestMultiple
    {
        public static long Get(uint min, uint max)
        {
            long smallestMultiple = 1;

            NextNumber:
            for (uint i = min; i <= max; i++)
            {
                if (smallestMultiple % i != 0)
                {
                    smallestMultiple += 1;
                    goto NextNumber;
                }
            }
            
            return smallestMultiple;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class ProblemSeven
    {   
        public long Resolve()
        {
            int count = 0;

            for(int i=1; i<Int32.MaxValue; i++)
            {
                if(isPrime(i))
                {
                    count++;
                    if(count == 10001)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }

        private bool isPrime(long number)
        {
            if(number == 1)
                return false;

            if(number == 2)
                return true;

            for (long i = 2; i<number; i++)
            {
                if(number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
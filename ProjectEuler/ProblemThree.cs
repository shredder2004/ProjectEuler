using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class ProblemThree
    {
        public long Resolve()
        {
            long bigNumber = 600851475143;
            //long bigNumber = 326;

            List<long> listOfPrime = listOfPrimeNumbers(bigNumber);
            return listOfPrime[0];
        }

        List<long> listOfPrimeNumbers(long num)
        {
            List<long> listOfLongs = new List<long>();
            while(isPrime(num) == false)
            {
                for (long i=2; i<num; i++)
                {
                    if (num % i == 0)
                    {
                        listOfLongs.Add(i);
                        num = num / i;
                        break;
                    }
                }
            }
            listOfLongs.Add(num);
            listOfLongs.Reverse();
            return listOfLongs;
        }

        // divisible par 1 et lui même
        private bool isPrime(long number)
        {
            if(number == 1 || number == 2)
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
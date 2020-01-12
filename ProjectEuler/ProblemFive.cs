using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class ProblemFive
    {   
        static int Max = 20;
        public int Resolve()
        {
            for(int i=1; i<Int32.MaxValue; i++)
            {
                if(entirelyDividable(i))
                {
                    //printProof(i);
                    return i;
                }
            }

            return 0;
        }

        void printProof(int num)
        {
            for(int i=1; i<=Max; i++)
            {
                Console.WriteLine($"{num} / {i} = {num/i}");
            }
        }

        bool entirelyDividable(int num)
        {
            for(int i=1; i<=Max; i++)
            {
                if(num % i != 0)
                    return false;
            }

            return true;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class ProblemSix
    {   
        static int n = 100;
        public long Resolve()
        {
            return getSquareSums() - getSumSquares();
        }

        private long getSumSquares()
        {
            long sum = 0;

            for(int i = 1; i<=n; i++)
            {
                sum += (long)Math.Pow(i,2);
            }
            return sum;
        }

        private long getSquareSums()
        {
            long sum = 0;
            for(int i=1; i<=n; i++)
            {
                sum += i;
            }
            return (long)Math.Pow(sum, 2);
        }
    }
}
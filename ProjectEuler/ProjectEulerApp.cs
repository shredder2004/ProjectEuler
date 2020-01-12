using System;

namespace ProjectEuler
{
    class ProjectEulerApp
    {
        public int ProblemOne()
        {
            int sum = 0;

            for (int i = 0; i<1000; i++)
            {
                if ( i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public long ProblemTwo()
        {
            long sum = 0;
            int previous = 1;
            int current = 1;
            while(current < 4000000)
            {
                int nextPrevious = current;
                if(current % 2 == 0)
                {
                    sum += current;
                }

                current = current + previous;
                previous = nextPrevious;
            }

            return sum;
        }

        public long ProblemThree()
        {
            ProblemThree p3 = new ProblemThree();
            return p3.Resolve();
        }

        public long ProblemFour()
        {
            ProblemFour p4 = new ProblemFour();
            return p4.Resolve();
        }

        public long ProblemFive()
        {
            ProblemFive p5 = new ProblemFive();
            return p5.Resolve();
        }
    }
}
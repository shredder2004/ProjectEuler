using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class ProblemFour
    {   
        public int Resolve()
        {
            int biggestPalindrome = 0;

            for(int i =100; i<=999; i++)
            {
                for(int j = 100; j<=999; j++)
                {
                    int number = i * j;

                    if (isPalindromic(number))
                    {
                        if(number > biggestPalindrome)
                        {
                            biggestPalindrome = number;
                            //Console.WriteLine($"{i} x {j} = {biggestPalindrome}");
                        }
                    }
                }
            }

            return biggestPalindrome;
        }

        private bool isPalindromic(int num)
        {
            List<int> digits = listOfDigits(num);
            List<int> reverseDigits = new List<int>(digits);
            reverseDigits.Reverse();

            for (int i=0; i<digits.Count; i++)
            {
                if(digits[i] != reverseDigits[i])
                    return false;
            }

            return true;
        }

        List<int> listOfDigits(int num)
        {
            List<int> listOfInts = new List<int>();
            while(num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts;
        }
    }
}
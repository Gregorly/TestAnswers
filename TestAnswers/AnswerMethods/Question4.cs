using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question4
    {
        public static BigInteger PrimeFactor()
        {
            BigInteger number = 600881475143;
            BigInteger largestPF = 0;
            

            for(BigInteger x = 3; x <= number; x++)
            {
                if (x % 2 != 0 && x % 3 != 0 && x % 4 != 0 && x % 5 != 0 && x % 6 != 0 && x % 7 != 0 && x % 9 != 0 && x % 2 != 0 && x % 10 != 0 && number % x == 0)
                {
                    largestPF = x;
                }
                
            }
            return largestPF;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TestAnswers.Models;

namespace TestAnswers.AnswerMethods
{
    public static class Question8
    {
        public static double TenPrimeSum()
        {
            QuestionEight primeNumbers = new QuestionEight();

            primeNumbers.TenPrimeNumber = new List<double>();
            double sum = 0;

            for (double x = 1; x <= 10000; x++)
            {

                if (x % 2 != 0 && x % 3 != 0 && x % 4 != 0 && x % 5 != 0 && x % 6 != 0 && x % 7 != 0 && x % 9 != 0 && x % 2 != 0 && x % 10 != 0)
                {
                    primeNumbers.TenPrimeNumber.Add(x);
                }

            }

            for(int q = primeNumbers.TenPrimeNumber.Count - 10; q < primeNumbers.TenPrimeNumber.Count; q++)
            {
                if (primeNumbers.TenPrimeNumber.ToArray()[q] % 7 == 3)
                    sum += primeNumbers.TenPrimeNumber.ToArray()[q];
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question5
    {
        public static int SmallestInteger()
        {
            bool numberFound = true;
            //this is 39 because I already know without a doubt that the numbers within the range are not evenly divisible by anything below 40.
            int number = 39;

            while (numberFound)
            {
                number++;
                for (int x = 2; x <= 20; x++)
                { 
                    numberFound = false;
                    if (number % x != 0)
                    {
                        numberFound = true;
                        x = 21;
                    }
                        
                }
            }
            return number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question3
    {
        public static BigInteger Fibonacci()
        {
            int maxValue = 3000000;
            BigInteger sum = 0;
            BigInteger sequenceValue = 1;
            BigInteger firstSequenceValue = 0;

            //The while loop should not run if the sequenceValue and firstSequenceValue is bigger than 3 million.
            while (firstSequenceValue <= maxValue)
            {
                if (firstSequenceValue % 2 != 0 && firstSequenceValue < maxValue)
                {
                    sum += firstSequenceValue;
                }
                sequenceValue = firstSequenceValue + sequenceValue;
                firstSequenceValue = sequenceValue + firstSequenceValue;
                if (sequenceValue % 2 != 0 && sequenceValue < maxValue)
                {
                    sum += sequenceValue;
                }

            }
            return sum;
        }
    }
}

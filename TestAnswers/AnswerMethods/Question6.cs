using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question6
    {
        public static string TwoThousandDigits()
        {
            BigInteger sequenceValue = 1;
            BigInteger firstSequenceValue = 0;

            while (firstSequenceValue.ToString().Length <= 2001)
            {
                sequenceValue = firstSequenceValue + sequenceValue;
                firstSequenceValue = sequenceValue + firstSequenceValue;
            }

            return firstSequenceValue.ToString();
        }
    }
}

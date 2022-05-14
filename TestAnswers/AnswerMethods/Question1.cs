using System;
using System.Collections.Generic;
using System.Text;
using TestAnswers.Models;

namespace TestAnswers.AnswerMethods
{
    public static class Question1
    {
        public static QuestionOneSum MultipleSum()
        {
            //I created a model because I wanted to return more than one value.
            QuestionOneSum sum = new QuestionOneSum();
            for (int x = 0; x <= 900; x++)
            {
                if (x % 2 == 0)
                {
                    sum.SumOf2 += x;
                }

                if (x % 4 == 0)
                {
                    sum.SumOf4 += x;
                } 
            }
            return sum;
        }

    }
}

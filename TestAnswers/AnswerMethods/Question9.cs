using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question9
    {
        public static string MyLeastFavourite()
        {
            return $"I think the fact that you have to use special strongly typed data types for numbers that are exponentially large such as " +
                $"the data type BigInteger is annoying because if you are dealing with both small numbers and large numbers dynamically, " +
                $"you have to know from the start that you will be dealing with huge numbers bigger than what an integer or a double " +
                $"is able to handle. If you have a growing application that you have not taken into account that the data might one day reach these sizes you will run into problems." +
                $" I would make two general data types for digits that handles huge numbers, one would be signed and the other unsigned.";
        }
    }
}

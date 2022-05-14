using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question2
    {
        public static string OptimizationSteps()
        {
            return $"The first step that I would take is to check for best practice mistakes. This would " +
                $"involve checking for nested if statements, for loops and while loops.\n\n" +
                $"Step 2 would involve checking the way the XML is read. " +
                $"If the XML reading methods are best for the environment it is hosted in, I believe that this would be the " +
                $"biggest issue with performance as there are many way to read XML and some may not be efficient. " +
                $"Step 3 would be to make sure API methods are best practice and updated as getting the XML is the most important" +
                $" part of this system.";
        }
    }
}

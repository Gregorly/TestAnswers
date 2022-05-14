using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnswers.AnswerMethods
{
    public static class Question7
    {
        public static int Saturdays()
        {
            DateTime begin = new DateTime(1901, 01, 02);
            DateTime end = new DateTime(2000, 12, 31);
            int count = 0;

            while (begin <= end)
            {
                for (int x = 0; x < 12; x++) 
                {
                    if (begin.AddMonths(x).DayOfWeek.ToString() == "Saturday")
                    {
                        count++;
                    }
                    
                }
                begin = begin.AddYears(1);
            }
            return count;
        }

    }
}

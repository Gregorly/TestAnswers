using System;
using System.Collections.Generic;
using System.Text;

namespace TestAnswers.Models
{
    public class SumAnswers
    {
        public QuestionOneSum[] QuestionOneSum { get; set; }
    }

    public class QuestionOneSum
    {
        public int SumOf2 { get; set; }
        public int SumOf4 { get; set; }
    }
}

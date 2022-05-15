using System;
using System.Collections.Generic;
using System.Text;
using TestAnswers.Models;
using static TestAnswers.AnswerMethods.Question1;
using static TestAnswers.AnswerMethods.Question2;
using static TestAnswers.AnswerMethods.Question3;
using static TestAnswers.AnswerMethods.Question4;
using static TestAnswers.AnswerMethods.Question5;
using static TestAnswers.AnswerMethods.Question6;
using static TestAnswers.AnswerMethods.Question7;
using static TestAnswers.AnswerMethods.Question8;
using static TestAnswers.AnswerMethods.Question9;

namespace TestAnswers
{
    public static class ConsoleText
    {
        public static void Answers(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    QuestionOneSum sum = MultipleSum();
                    Question($"Question: What is the sum total of multiples below 900 of 2 or 4?\n\n");
                    AnswerColour("I didn't quite know if you wanted the sum of multiples of 2 AND 4 or the sum of muliples of 2 OR 4 so I did both");
                    AnswerColour("sum of multiples of 2 and 4: " + sum.SumOf2);
                    AnswerColour("sum of multiples of 4 " + sum.SumOf4);
                    Message();
                    break;

                case "2":
                    Console.Clear();
                    Question($"Question: You have inherited a secure web service component that handles a large volume payment commands across" +
                        $" disconnected environments. This web service has been optimized to use as little XML as possible and each message is smaller " +
                        $"than 10 KB.If the speed of this solution is considered to be a problem, what steps would you take to solve it ?\n\n");
                    AnswerColour(OptimizationSteps());
                    Message();
                    break;
                case "3":
                    Console.Clear();
                    Question($"Question: What is the sum total of the odd (1, 3, 5, ...) numbers within a Fibonacci sequence where the value is no larger than three million?\n\n");
                    AnswerColour(Fibonacci().ToString());
                    Message();
                    break;
                case "4":
                    Console.Clear();
                    Question($"Question: For the number 2310, the prime factors are 2, 3, 5, 7 and 11. For the number 600881475143, what is the largest prime factor?\n\n This may take a while...");
                    AnswerColour(PrimeFactor().ToString());
                    Message();
                    break;
                case "5":
                    Console.Clear();
                    Question($"Question: What is the smallest integer that you are able to evenly divide (I.e.: no remainder) using all numbers within range [1 .. 20]?\n\n");
                    AnswerColour(SmallestInteger().ToString());
                    Message(); 
                    break;
                case "6":
                    Console.Clear();
                    Question($"Question: Using a Fibonacci sequence, what is the second term to contain over two thousand individual digits?\n\n");
                    AnswerColour(TwoThousandDigits());
                    Message();
                    break;
                case "7":
                    Console.Clear();
                    Question($"Question:During the twentieth century how many Saturdays fell in the second of the month?\n\n");
                    AnswerColour(Saturdays().ToString());
                    Message();
                    break;
                case "8":
                    Console.Clear();
                    Question($"Question: Using the last 10 prime numbers below 10,000, sum the values which have a remainder of 3 when divided by 7.\n\n");
                    AnswerColour(TenPrimeSum().ToString());
                    Message();
                    break;
                case "9":
                    Console.Clear();
                    Question("Question: Identify and explain your least favourite feature within your favoured language and how you would rectify it.\n\n");
                    AnswerColour(MyLeastFavourite());
                    Message();
                    break;
                case "10":
                    Console.Clear();
                    Question("To View My Question 10 answer, please view the class called Question10 in my solution.");
                    Message();
                    break;
                case null:
                    Message();
                    break;

            }

        }

        public static void Clear()
        {
            Console.Clear();
        }
        public static void Message()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("To view my answers, enter a question number from 1-10");
            Answers(Console.ReadLine());
            
        }

        public static void Question(string question)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(question);
        }
        public static void AnswerColour(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(answer);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var question1 = new TrueFalseQuestion("Choose True / False");
            question1.Inquiry = "Everybody should like cats.";
            question1.Answer = "true";
            question1.Weight = 1;

            var quiz = new Quiz();
            quiz.Questions = new List<Question>();
            quiz.Questions.Add(question1);

            quiz.Run();

        }
    }
}

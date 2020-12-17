using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int Score { get; set; }

        public double Grade()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach(var question in Questions)
            {
                Console.WriteLine(question.Inquiry);
                var studentAnswer = Console.ReadLine();
                
                if (question.CheckAnswer(studentAnswer))
                {
                    Console.WriteLine("You answered correctly. Yay!");
                    Score = Score + question.Weight;
                } else
                {
                    Console.WriteLine("You answered incorrectly. Boo!");
                }
                Console.WriteLine($"Your score is now: {Score}");
            }
        }
    }
}

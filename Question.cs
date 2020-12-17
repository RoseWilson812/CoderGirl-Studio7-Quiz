using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        public Question(string instruction) 
        {
            Instruction = instruction;        
        }


        public string Answer { get; set; }
        public string Inquiry { get; set; }
        public string Instruction { get; set; }
        public int Weight { get; set; } = 0;

        public abstract bool CheckAnswer(string answer);

    }
}

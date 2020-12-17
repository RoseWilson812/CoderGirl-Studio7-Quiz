using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string instruction) : base(instruction)
        {

        }

        public override bool CheckAnswer(string answer)
        {
            return answer.ToLower() == this.Answer.ToLower();
        }
    }
}

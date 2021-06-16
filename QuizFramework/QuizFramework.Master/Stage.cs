using System;
using System.Collections.Generic;
using System.Text;

namespace QuizFramework.Master
{
    /// <summary>
    /// It contains question and answer variants to this one
    /// </summary>
    public class Stage
    {
        public readonly Question Question;

        public readonly Answer[] Answers;

        public Stage(Question question, Answer[] answers)
        {
            Question = question;
            Answers = answers;
        }
    }
}

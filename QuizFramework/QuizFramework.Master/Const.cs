using System;
using System.Collections.Generic;
using System.Text;

namespace QuizFramework.Master
{
    public static class Const
    {
        public static string GreetingMessage(string title) => "It's a \"" + title + "\" quiz!";

        //TODO: If a rightAnswerNumbers length is 0 or null?
        public static string NotRightAnswerMessage(params int[] rightAnswerNumbers)
        {
            // If rightAnswerNumbers more than 1, then ending of word "answer" below must be plural
            string answerEnding = rightAnswerNumbers.Length > 1 ? "s" : "";

            return "No, right answer" + answerEnding + " is " + string.Join(", ", rightAnswerNumbers) + ".";
        }

        public static string UserInputIsIncorrectMessage = "You need to write a number in range of numbers of answer variants.";

        public static string RightAnswerMessage = "Yes, you right!";

        public static string TotalMessage = "So, total of all this quiz below:";
    }
}

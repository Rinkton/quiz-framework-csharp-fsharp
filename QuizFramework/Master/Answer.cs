using System;
using System.Collections.Generic;
using System.Text;

namespace Master
{
    public class Answer
    {
        public readonly string Text;

        public readonly bool Right;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="right">Is answer is right?</param>
        public Answer(string text, bool right)
        {
            Text = text;
            Right = right;
        }
    }
}

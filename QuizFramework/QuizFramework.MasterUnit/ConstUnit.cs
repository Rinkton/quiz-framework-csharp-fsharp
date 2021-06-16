using System;
using Xunit;
using QuizFramework.Master;

namespace QuizFramework.MasterUnit
{
    public class ConstUnit
    {
        [Fact]
        public void GreetingMessageUnit()
        {
            string[] expectedVariants = new string[]
            {
                "It's a \"Test\" quiz!"
            };

            string[] actualVariants = new string[]
            {
                Const.GreetingMessage("Test")
            };

            Assert.Equal(expectedVariants, actualVariants);
        }

        [Fact]
        public void NotRightAnswerMessageUnit()
        {
            string[] expectedVariants = new string[]
            {
                "No, right answer is 1.",
                "No, right answers is 1, 4."
            };

            string[] actualVariants = new string[]
            {
                Const.NotRightAnswerMessage(1),
                Const.NotRightAnswerMessage(1, 4),
            };

            Assert.Equal(expectedVariants, actualVariants);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Slave;

namespace SlaveUnit
{
    public class FuncsUnit
    {
        [Fact]
        public void GetOutputAnswerTextsUnit()
        {
            string[] expectedVariants = new string[]
            {
                "1. test1\n" +
                "2. test2\n" +
                "3. test3"
            };

            string[] actualVariants = new string[]
            {
                Funcs.GetOutputAnswerTexts(new string[] { "test1", "test2", "test3" })
            };

            Assert.Equal(expectedVariants, actualVariants);
        }

        [Fact]
        public void UserInputIsCorrectUnit()
        {
            bool[] expectedVariants = new bool[]
            {
                true,
                true,
                false,
                false,
                false,
                false
            };

            bool[] actualVariants = new bool[]
            {
                Funcs.UserInputIsCorrect("1", 3),
                Funcs.UserInputIsCorrect("3", 3),
                Funcs.UserInputIsCorrect("4", 3),
                Funcs.UserInputIsCorrect("0", 3),
                Funcs.UserInputIsCorrect("a", 100),
                Funcs.UserInputIsCorrect("ab", 3)
            };

            Assert.Equal(expectedVariants, actualVariants);
        }

        [Fact]
        public void GetOutputTotalUnit()
        {
            string[] expectedVariants = new string[]
            {
                "",

                "1\n" +
                "-\n" +
                "V",

                "1\n" +
                "-\n" +
                "X",

                "1|2|3\n" +
                "-+-+-\n" +
                "V|X|V"
            };

            string[] actualVariants = new string[]
            {
                Funcs.GetOutputTotal(new bool[] { }),
                Funcs.GetOutputTotal(new bool[] { true }),
                Funcs.GetOutputTotal(new bool[] { false }),
                Funcs.GetOutputTotal(new bool[] { true, false, true })
            };

            Assert.Equal(expectedVariants, actualVariants);
        }
    }
}

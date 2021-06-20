using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slave;

namespace QuizFramework.Master
{
    public class Quiz
    {
        public readonly string Title;

        public readonly Stage[] Stages;

        private List<bool> stagesRightnessQueue;

        public Quiz(string title, Stage[] stages)
        {
            Title = title;
            Stages = stages;
        }

        public Result Run()
        {
            if(System.Diagnostics.Debugger.IsAttached)
            {
                runCode();
            }
            else
            {
                try
                {
                    runCode();
                }
                catch
                {
                    return Result.Error;
                }
            }

            return Result.Ok;
        }

        // TODO: It's need a better name
        private void runCode()
        {
            stagesRightnessQueue = new List<bool>();

            Console.WriteLine(Const.GreetingMessage(Title));
            Console.ReadKey();

            foreach (Stage stage in Stages)
            {
                restartIteration:
                Console.WriteLine(stage.Question.Text);
                Console.WriteLine(Funcs.GetOutputAnswerTexts(getAnswerTexts(stage.Answers)));

                string userInput = Console.ReadLine();

                if (Funcs.UserInputIsCorrect(userInput, stage.Answers.Length) == false)
                {
                    Console.WriteLine(Const.UserInputIsIncorrectMessage);
                    Console.ReadKey();
                    goto restartIteration;
                }

                int userChoice = Convert.ToInt32(userInput);

                bool isRight = stage.Answers[userChoice - 1].Right;
                stagesRightnessQueue.Add(isRight);

                if (isRight)
                {
                    Console.WriteLine(Const.RightAnswerMessage);
                }
                else
                {
                    //TODO: It possible to solve with FP way
                    List<int> rightAnswerNumbersList = new List<int>();
                    for (int i = 0; i < stage.Answers.Length; i++)
                    {
                        if (stage.Answers[i].Right)
                        {
                            rightAnswerNumbersList.Add(i+1);
                        }
                    }

                    Console.WriteLine(Const.NotRightAnswerMessage(rightAnswerNumbersList.ToArray()));
                }

                Console.ReadKey();
            }

            Console.WriteLine(Const.TotalMessage);
            Console.WriteLine(Funcs.GetOutputTotal(stagesRightnessQueue.ToArray()));

            Console.ReadKey();
        }

        private string[] getAnswerTexts(Answer[] answers)
        {
            // Yeeeeah, FP in C#
            return answers.Select(x => x.Text).ToArray();
        }
    }
}

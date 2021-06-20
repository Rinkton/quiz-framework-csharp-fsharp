using System;
using QuizFramework.Master;

namespace TestQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz
                (
                    "Test quiz",
                    new Stage[]
                    {
                        new Stage
                        (
                            new Question("Name of this quiz?"),
                            new Answer[]
                            {
                                new Answer("Test", false),
                                new Answer("Test quiz", true),
                                new Answer("Quiz", false),
                                new Answer("QuizQuiz", false)
                            }
                        ),
                        new Stage
                        (
                            new Question("In what programming languages written QuizFramework?"),
                            new Answer[]
                            {
                                new Answer("C, C++", false),
                                new Answer("Python", false),
                                new Answer("C#, Visual Basic", false),
                                new Answer("C#, F#", true)
                            }
                        ),
                        new Stage
                        (
                            new Question("First and second answers is right."),
                            new Answer[]
                            {
                                new Answer("First", true),
                                new Answer("Second", true),
                                new Answer("Third", false)
                            }
                        ),
                        new Stage
                        (
                            new Question("It's a last question?"),
                            new Answer[]
                            {
                                new Answer("Yes", true),
                                new Answer("No", false)
                            }
                        )
                    }
                );
            Quiz quiz2 = new Quiz
                (
                    "Test quiz2",
                    new Stage[] //Just for test that this break nothing
                    {
                    }
                );
            Result result = quiz.Run();
            if (result == Result.Error)
            {
                Console.WriteLine("Oh... something is wrong... sorry.");
            }
        }
    }
}

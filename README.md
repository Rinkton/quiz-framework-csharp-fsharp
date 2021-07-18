# quiz-framework-csharp-fsharp
It's a framework for creating quiz console games written on C# and F#.

It contains those projects in solution:
* QuizFramework.Master - A project you should reference if you want use framework (.NET Core C#)
* QuizFramework.MasterUnit - Unit tests for QuizFramework.Master (.NET Core C#)
* Slave - A project, that contains pure functions that QuizFramework.Master use for accomplish ownself tasks (.NET Standard F#)
* SlaveUnit - Unit tests for Slave (.NET Framework C#)
* TestQuiz - Contains test program(quiz), that using a QuizFramework.Master (.NET Core C#)

(More detailized description of those projects contains in their ownself README)

Conclusions I made that I think could improve the code:
* It's a good idea to feed Console.WriteLine already cooked strings
* I need something like a BCL project for Slave and Master to opportunity for them talk on same language(same classes)
* And, I guess, Const must belong to Slave, cuz project displayed me that in Const may be complicated functions that Master shouldn't to do
* Do I need to test code on one language on the same language?... EH, anyway, I don't do that, it's hard... C#... .NET Framework...
* No one can test Master (cuz it must don't have a functions that needed in some tests, you know)

namespace Slave
//TODO: Do not forget make conclusions.
module Funcs = 
    open System
    open System.Text
    open System

    let GetOutputAnswerTexts (answerTexts:string[]) = 
        let outputAnswerTextsSB = new StringBuilder()
        // There is useful an imperative way
        for i = 0 to answerTexts.Length-1 do
            outputAnswerTextsSB.Append(sprintf "%i. %s" (i+1) answerTexts.[i]) |> ignore
            if i <> answerTexts.Length-1 then outputAnswerTextsSB.Append("\n") |> ignore
        outputAnswerTextsSB.ToString()
    let UserInputIsCorrect (userInput:string) (answersCount:int) = 
        let isNumber() = 
            match Int32.TryParse userInput with
            | true, num -> true
            | _ -> false
        let isInRange() = (int userInput <= answersCount && int userInput > 0)
        (isNumber() && isInRange())
    let GetOutputTotal (stagesRightnessQueue:bool[]) = 
        let outputTotal = new StringBuilder()

        let getRow (elements:string[]) (separator:string) (afterThatNewLineIsNeeded:bool) = 
            if elements.Length > 0 then
                for i = 0 to elements.Length-1 do
                    outputTotal.Append(elements.[i]) |> ignore
                    if i <> elements.Length-1 
                    then outputTotal.Append(separator) |> ignore
                if afterThatNewLineIsNeeded then outputTotal.Append("\n") |> ignore

        let mutable elements1 = []
        for i = 1 to stagesRightnessQueue.Length do elements1 <- i.ToString() :: elements1
        getRow (List.toArray (elements1 |> List.rev)) "|" true

        let mutable elements2 = []
        for i = 1 to stagesRightnessQueue.Length do elements2 <- "-" :: elements2
        getRow (List.toArray (elements2 |> List.rev)) "+" true

        let mutable elements3 = []
        for i = 1 to stagesRightnessQueue.Length do 
            elements3 <- (if stagesRightnessQueue.[i-1] = true then "V" else "X") :: elements3
        getRow (List.toArray (elements3 |> List.rev)) "|" false

        outputTotal.ToString()

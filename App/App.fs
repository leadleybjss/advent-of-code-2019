let runStar =
    function
    | "01-1" -> StarOne.silver()
    | "01-2" -> StarOne.gold()
    | "02-1" -> StarTwo.silver()
    | "02-2" -> StarTwo.gold()
    | _ -> printfn "This star has not been reached yet!"

[<EntryPoint>]
let main args =
    printfn "Leadley AoC 2019"
    match args with
    | [|x|] -> runStar x
    | _ -> 
        printf "Please choose a star! (Give me exactly one argument in format dd-x): "
        System.Console.ReadLine() |> runStar
    System.Console.ReadLine() |> ignore
    0

[<EntryPoint>]
let main args =
    printfn "Leadley AoC 2019"
    match args with
    | [|"01-1"|] -> StarOneOne.run()
    | [|"01-2"|] -> StarOneTwo.run()
    | _ -> printfn "Please choose a star! (Give me exactly one argument in format dd-x)"
    0

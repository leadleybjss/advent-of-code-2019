module StarTwo

let findNounAndVerb (expected: int) (code: int list) =
    Seq.init 10000 (fun n -> (n / 100, n % 100))
    |> Seq.find (fun (noun, verb) ->
        code.[0] :: noun :: verb :: code.[3..]
        |> Intcode.run
        |> List.head
        |> (=) expected)

let silver() =
    Input.readIntCode "star02"
    |> Intcode.run
    |> List.head
    |> string
    |> printfn "%s"

let gold() =
    Input.readIntCode "star02"
    |> findNounAndVerb 19690720
    |> (fun (noun, verb) -> 100 * noun + verb)
    |> printfn "%i"

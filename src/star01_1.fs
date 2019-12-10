module StarOneOne

open Helpers

let run() =
    readInput "star01"
    |> Seq.sumBy (fun x -> int x / 3 - 2)
    |> printfn "%i"

module StarOneTwo

open Helpers

let fuelFor mass = mass / 3 - 2

let rec totalFuel acc =
    function
    | x when x <= 0 -> acc
    | x -> totalFuel (acc + x) (fuelFor x)

let calculateTotalFuel =
    int
    >> fuelFor
    >> totalFuel 0

let run() =
    readInput "star01"
    |> Seq.sumBy calculateTotalFuel
    |> printfn "%i"

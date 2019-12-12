module StarOne

let fuelFor mass = mass / 3 - 2

let rec private totalFuelHelper acc =
    function
    | x when x <= 0 -> acc
    | x -> totalFuelHelper (acc + x) (fuelFor x)

let totalFuel = fuelFor >> totalFuelHelper 0

let silver() =
    Input.readLines "star01"
    |> Seq.map int
    |> Seq.sumBy fuelFor
    |> printfn "%i"

let gold() =
    Input.readLines "star01"
    |> Seq.map int
    |> Seq.sumBy totalFuel
    |> printfn "%i"

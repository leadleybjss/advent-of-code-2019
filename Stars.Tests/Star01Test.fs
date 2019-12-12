module StarOneTest

open NUnit.Framework
open FsUnit

[<Test>]
let starOneSilverExample1() = StarOne.fuelFor 12 |> should equal 2

[<Test>]
let starOneSilverExample2() = StarOne.fuelFor 14 |> should equal 2

[<Test>]
let starOneSilverExample3() = StarOne.fuelFor 1969 |> should equal 654

[<Test>]
let starOneSilverExample4() = StarOne.fuelFor 100756 |> should equal 33583

[<Test>]
let starOneGoldExample1() = StarOne.totalFuel 14 |> should equal 2

[<Test>]
let starOneGoldExample2() = StarOne.totalFuel 1969 |> should equal 966

[<Test>]
let starOneGoldExample3() = StarOne.totalFuel 100756 |> should equal 50346

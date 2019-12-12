module StarTwoTest

open NUnit.Framework
open FsUnit

[<Test>]
let starTwoSilverExample1() =
    Intcode.run [ 1; 9; 10; 3; 2; 3; 11; 0; 99; 30; 40; 50 ]
    |> should equal [ 3500; 9; 10; 70; 2; 3; 11; 0; 99; 30; 40; 50 ]

[<Test>]
let starTwoSilverExample2() = Intcode.run [ 1; 0; 0; 0; 99 ] |> should equal [ 2; 0; 0; 0; 99 ]

[<Test>]
let starTwoSilverExample3() = Intcode.run [ 2; 3; 0; 3; 99 ] |> should equal [ 2; 3; 0; 6; 99 ]

[<Test>]
let starTwoSilverExample4() = Intcode.run [ 2; 4; 4; 5; 99; 0 ] |> should equal [ 2; 4; 4; 5; 99; 9801 ]

[<Test>]
let starTwoSilverExample5() =
    Intcode.run [ 1; 1; 1; 4; 99; 5; 6; 0; 99 ] |> should equal [ 30; 1; 1; 4; 2; 5; 6; 0; 99 ]

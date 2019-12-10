module Helpers

let readLines filePath = System.IO.File.ReadLines(filePath) |> Seq.cast<string>

let readInput starName = sprintf "src/input/%s.txt" starName |> readLines

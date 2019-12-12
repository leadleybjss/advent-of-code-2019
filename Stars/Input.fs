module Input

let private inputFilePath = sprintf "input/%s.txt"

let private split (delimiter: char) (input: string) = input.Split delimiter

let readLines =
    inputFilePath
    >> System.IO.File.ReadLines
    >> Seq.cast<string>

let readIntCode =
    inputFilePath
    >> System.IO.File.ReadAllText
    >> split ','
    >> Array.toList
    >> List.map int

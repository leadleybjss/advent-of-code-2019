module Intcode

let rec private runHelper (code: int list) pos =
    let opcode = code.[pos]
    match opcode with
    | 1 ->
        let noun = code.[pos + 1]
        let verb = code.[pos + 2]
        let setPos = code.[pos + 3]
        let value = code.[noun] + code.[verb]
        let newCode = code.[..setPos - 1] @ value :: code.[(setPos + 1)..]
        runHelper newCode (pos + 4)
    | 2 ->
        let noun = code.[pos + 1]
        let verb = code.[pos + 2]
        let setPos = code.[pos + 3]
        let value = code.[noun] * code.[verb]
        let newCode = code.[..setPos - 1] @ value :: code.[(setPos + 1)..]
        runHelper newCode (pos + 4)
    | 99 -> code
    | _ -> failwith "oops, no such opcode"

let run code = runHelper code 0

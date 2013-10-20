module Core

open System.Text
open System.Text.RegularExpressions


let (|Match|_|) pat inp =
    let m = Regex.Match(inp, pat)
    match m.Success with
    | true -> Some (List.tail [ for g in m.Groups -> g.Value ])
    | _ -> None

//let getResult x pattern ignoreCase =
//    match x with
//    | 
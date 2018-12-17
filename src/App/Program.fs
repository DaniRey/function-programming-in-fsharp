// Learn more about F# at http://fsharp.org

open System
open Library
open Shopping

[<EntryPoint>]
let main argv =
    basket 
    |> List.map(fun p -> p.Name) 
    |> List.iter(printfn("%s"))
    0 // return an integer exit code

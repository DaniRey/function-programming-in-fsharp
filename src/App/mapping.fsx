let numbers = [1; 2; 3]
let doubledNumbers = List.map (fun n -> n * 2) numbers

printfn("Content of 'numbers'")
numbers |> List.iter(printfn ("%i"))

printfn("Content of 'doubledNumbers'")
doubledNumbers |> List.iter(printfn ("%i"))

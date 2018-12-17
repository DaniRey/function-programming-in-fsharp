let numbers = [1; 2; 3; 4; 5; 6]
let evenNumbers = List.filter (fun n -> n % 2 = 0) numbers

printfn("Content of 'numbers'")
numbers |> List.iter(printfn ("%i"))

printfn("Content of 'even numbers'")
evenNumbers |> List.iter(printfn ("%i"))

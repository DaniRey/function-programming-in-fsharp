let multiply = fun x y -> x * y

let closure = fun y ->   
  let x = 3 
  x * y

let triple = multiply 3

printfn "%i" (5 |> closure)
printfn "%i" (5 |> triple)
let multiply: int -> int -> int = fun x y -> x * y

let closure: int -> int = fun y ->   
  let x = 3 
  x * y

let triple: int -> int = multiply 3

printfn "%i" (5 |> closure)
printfn "%i" (5 |> triple)
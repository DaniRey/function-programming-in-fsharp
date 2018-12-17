#load "../Library/Library.fs"

open Library
open Shopping

let itProducts = belongsToCategory it

let nameProjection(p: Product) = p.Name

printfn("Names of IT products in basket (built with named functions)")
basket 
  |> List.filter(itProducts)
  |> List.map(nameProjection)
  |> List.iter(printfn("%s"))

printfn("")
printfn("Names of IT products in basket (built with anonymous functions)")
basket 
  |> List.filter(belongsToCategory it)
  |> List.map(fun p -> p.Name)
  |> List.iter(printfn("%s"))

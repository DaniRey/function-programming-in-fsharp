#load "../Library/Library.fs"

open Library
let total = basket |> List.fold (fun price product -> price + product.PriceInCents) 0

printfn "Total price is %1.2f" (float32 total / 100.0F)

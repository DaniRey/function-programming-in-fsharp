#load "../Library/Library.fs"

open Library
open Shopping
let total(basket: List<Product>) = 
  basket 
    |> List.map(fun p -> p.PriceInCents) 
    |> List.reduce (fun sum productPrice -> sum + productPrice)

printfn "Total price is %1.2f" (float32 (total(basket)) / 100.0F)
//printfn "Total price of an empty basket is %1.2f" (float32 (total(List.empty<Product>)) / 100.0F)

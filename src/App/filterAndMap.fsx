#load "../Library/Library.fs"

open Library
open Shopping

basket 
  |> List.filter(belongsToCategory it)
  |> List.map(fun p -> p.Name)
  |> List.iter(printfn("%s"))

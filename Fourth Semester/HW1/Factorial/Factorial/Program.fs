let rec factorial n =
  match n with 
  | 0 | 1 -> 1 
  | _ -> n * factorial (n - 1)

printfn "factorial of 0: %A" (factorial 0)
printfn "factorial of 5: %A" (factorial 5)
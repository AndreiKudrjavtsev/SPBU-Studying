let rec fibonacci n = 
  match (n - 1) with 
  | 0 | 1 -> 1 
  | _ -> fibonacci (n - 1) + fibonacci (n - 2)

printfn "5th Fibonacci number: %A" (fibonacci 5) 
printfn "8th Fibonacci number: %A" (fibonacci 8) 
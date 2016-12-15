let reverseList list = 
  let rec reverse list result = 
    match list with 
    | [] -> result
    | h::t -> reverse t (h::result)
  reverse list []

printfn "%A" (reverseList [1; 2; 3; 4; 5])
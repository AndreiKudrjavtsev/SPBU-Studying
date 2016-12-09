let rec summSin list = 
    let rec summing lst (sum: float) = 
        match lst with 
        | h::t -> summing t (sum + sin(h))
        | [] -> sum
    summing list 0.0

printfn "%A" (summSin [3.14])
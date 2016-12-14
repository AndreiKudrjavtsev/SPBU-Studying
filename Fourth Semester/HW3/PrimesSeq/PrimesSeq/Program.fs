let isPrime n = 
    let rec primeCheck i = 
        if i >= n then true 
        else 
            match n % i with 
            | 0 -> false
            | _ -> primeCheck (i + 1)
    primeCheck 2

let primes = Seq.initInfinite (fun i -> if i = 0 then 2 else i * 2 + 1) |> Seq.filter(fun i -> isPrime i)
printfn "%A" primes
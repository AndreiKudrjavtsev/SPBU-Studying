type RoundingBuilder(n: int) = 
    member this.Bind(x: float, f: float -> float) =
        System.Math.Round(f x, n)
    member this.Return(x) = 
        x

let rounding n = RoundingBuilder n

let test = 
    rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    }
    |> printfn "%A"

let test2 = 
    rounding 5 {
        let! a = 1.0
        let! b = 6.0
        return a / b
    }
    |> printfn "%A"
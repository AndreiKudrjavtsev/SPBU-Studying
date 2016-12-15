let findNumber str = 
    match System.Double.TryParse(str) with 
    | true, num -> Some(num)
    | false, _ -> None

type StrExpBuilder() = 
    member this.Bind(x, f) = 
        match findNumber x with 
        | Some num -> f num
        | None -> None
    member this.Return(x) = 
        Some x
        
let strexpr = StrExpBuilder()

strexpr {
    let! x = "1"
    let! y = "2"
    let z = x + y
    return z
}
|> printfn "%A"


strexpr {
        let! x = "1"
        let! y = "Ъ"
        let z = x + y
        return z
    }
|> printfn "%A"
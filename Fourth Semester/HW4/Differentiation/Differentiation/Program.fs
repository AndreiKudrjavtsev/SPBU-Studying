type Expr = 
    | Const of float
    | Var of char
    | Sum of Expr * Expr
    | Sub of Expr * Expr
    | Mult of Expr * Expr
    | Div of Expr * Expr

let rec evaluate exp = 
    match exp with
    | Const n -> Const(0.0)
    | Var x -> Const(1.0)
    | Sum (a, b) -> Sum(evaluate a, evaluate b)
    | Sub (a, b) -> Sub(evaluate a, evaluate b)
    | Mult (a, b) -> Sum(Mult(evaluate a, b), Mult(a, evaluate b))
    | Div (a, b) -> Div(Sub(Mult(evaluate a, b), Mult(a, evaluate b)), Mult(b, b))

let rec simplify exp =
    match exp with
    | Const(a) -> Const(a) 
    | Var x -> Var x
    | Sum (a, b) -> let c = simplify a
                    let d = simplify b
                    match (c, d) with 
                    | (Const(0.0), d) -> d
                    | (c, Const(0.0)) -> c
                    | (Const(c1), Const(c2)) -> Const(c1 + c2)
                    | _-> Sum (c, d)
    | Sub (a, b) -> let c = simplify a
                    let d = simplify b
                    match (c, d) with
                    | (Const(0.0), d) -> Mult (Const(-1.0), d)
                    | (c, Const(0.0)) -> c
                    | (Const(c1), Const(c2)) -> Const(c1 - c2)
                    |_ -> Sub (c, d)
    | Mult (a, b) -> let c = simplify a
                     let d = simplify b
                     match (c, d) with
                     |(Const(0.0), d) -> Const(0.0)
                     |(c, Const(0.0)) -> Const(0.0)
                     |(Const(1.0), d) -> d
                     |(c, Const(1.0)) -> c
                     |(Const(c1), Const(c2)) -> Const (c1 * c2)
                     |_ -> Mult (c, d)
    | Div (a, b) -> let c = simplify a
                    let d = simplify b
                    match (c, d) with
                    |(Const(0.0), d) -> Const (0.0)
                    |(c, Const(0.0)) -> failwith ("Divided by zero")
                    |(Const(c1), Const(c2)) -> Const (c1 / c2)
                    |_ -> Div (c, d)

// tests
// (1 / x) + (2 * (2 * x - 3))
let expr1 = Sum(Div(Const(1.0), Var('x')), Mult(Const(2.0), Mult(Const(2.0), Sub(Var('x'), Const(3.0)))))
// (1 / x)
let expr2 = Div(Const(1.0), Var('x'))
let difExp1 = evaluate expr1
let difExp2 = evaluate expr2
difExp1 |> simplify |> simplify |> printfn "%A"
difExp2 |> simplify |> simplify |> simplify |> simplify |> printfn "%A"
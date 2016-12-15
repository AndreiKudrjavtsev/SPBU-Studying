type Expr<'a> = 
    | Value of 'a
    | Addition of Expr<'a> * Expr<'a>
    | Subtraction of Expr<'a> * Expr<'a>
    | Multiplication of Expr<'a> * Expr<'a>
    | Division of Expr<'a> * Expr<'a>

let rec evaluate expr = 
    match expr with 
    | Value a -> a
    | Addition (a, b) -> (evaluate a + evaluate b)
    | Subtraction (a, b) -> (evaluate a - evaluate b)
    | Multiplication (a, b) -> (evaluate a * evaluate b)
    | Division (a, b) -> let divisor = evaluate b
                         if divisor = 0 then failwith("Divided by zero")
                         else (evaluate a / evaluate b)

// (3 + 2) / (6 - 1) * 3
let ex = Multiplication(Division(Addition(Value(3), Value(2)), (Subtraction(Value(6), Value(1)))), Value(3)) 
printfn "%A" (evaluate ex)
printfn "%A" (evaluate (Division(Value(1), Value(0))))
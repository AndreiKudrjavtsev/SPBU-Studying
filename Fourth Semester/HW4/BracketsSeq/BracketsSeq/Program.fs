let seqIsCorrect str = 
    let getBrackets = [for ch in str -> ch] |> List.filter (fun i -> i = '(' || i = ')' || i = '[' || i = ']' ||
                                                                     i = '{' || i = '}')
    let rec correctionCheck list stack = 
        match list with 
        | h :: t -> 
                    match h with 
                    | '(' -> correctionCheck t (h::stack)
                    | '[' -> correctionCheck t (h::stack)
                    | '{' -> correctionCheck t (h::stack)
                    | ')' -> if stack <> [] && List.head stack = '(' then correctionCheck t (List.tail stack)
                             else false
                    | ']' -> if stack <> [] && List.head stack = '[' then correctionCheck t (List.tail stack)
                             else false
                    | '}' -> if stack <> [] && List.head stack = '{' then correctionCheck t (List.tail stack)
                             else false
        | [] -> true
        
    correctionCheck getBrackets []

let str = "the (snitch (nigga {thats } the ) shit [] i dont like"
let str2 = "a (bitch nigga)) "
printfn "%b" (seqIsCorrect str)
printfn "%b" (seqIsCorrect str2)
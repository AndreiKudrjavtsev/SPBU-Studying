// returns true if there are no similar elements in list
let listCheck list = 
    let rec inList lst value = 
        match lst with 
        | h :: t when h = value -> true
        | h :: t when h <> value -> inList t value
        | _ -> false
    let rec check list = 
        match list with 
        | h :: t when inList t h -> false
        | h :: t when not (inList t h) -> check t
        | _ -> true
    check list

printfn "%A" (listCheck [0; 1; 0])
printfn "%A" (listCheck [0; 1; 2])
printfn "%A" (listCheck [])
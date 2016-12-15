let firstEntryInList list number = 
    let rec firstEntry lst value pos = 
        match lst with 
        | h :: t when h = value -> Some pos
        | h :: t when h <> value -> firstEntry t value (pos + 1)
        | _ -> None
    firstEntry list number 0

printfn "%A" (firstEntryInList [0; 1; 2; 3; 4; 5] 3)
printfn "%A" (firstEntryInList [0; 1; 2; 3; 4; 5] 6)
printfn "%A" (firstEntryInList [0; 0; 2; 3; 0; 5] 0)
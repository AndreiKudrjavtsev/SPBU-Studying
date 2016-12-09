let printRhombus n = 
    let size = 2 * n - 1
    let mutable currSize = 1
    let mutable spacesAmount = 0
    // пока не дошли до середины - false, потом меняем на true.
    let mutable middleFlag = false
    for i = 1 to size do
        if i > size / 2 then middleFlag <- true
        if not middleFlag then 
            spacesAmount <- (size - currSize) / 2
            (String.init spacesAmount (fun i -> " ") + String.init currSize (fun i -> "*") 
                + String.init spacesAmount (fun i -> " ")) |> printfn "%s" 
            currSize <- currSize + 2
        elif middleFlag then 
            spacesAmount <- (size - currSize) / 2
            (String.init spacesAmount (fun i -> " ") + String.init currSize (fun i -> "*") 
                + String.init spacesAmount (fun i -> " ")) |> printfn "%s" 
            currSize <- currSize - 2

printRhombus 3
let numberOfEvenMap list = 
    let evenOddList = List.map (fun i -> if i % 2 = 0 then 1 else 0) list
    List.fold (fun i acc -> i + acc) 0 evenOddList

printfn "%A" (numberOfEvenMap [1; 5; 6; 2])

let numberOfEvenFilter list = 
    let evenNumbersList = List.filter (fun i -> i % 2 = 0) list
    List.length evenNumbersList

printfn "%A" (numberOfEvenFilter [1; 5; 6; 2])

let numberOfEvenFold list = 
    List.fold (fun i acc -> if (i % 2 = 0) then acc + 1 else acc) 0 list

printfn "%A" (numberOfEvenFold [1; 5; 6; 2])
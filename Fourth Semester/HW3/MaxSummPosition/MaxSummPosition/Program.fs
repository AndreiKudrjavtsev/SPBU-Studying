let findPos list = 
    let findMaxList = List.zip (0::list) (list @ [0])
    let sumOfTwoList = List.map (fun (a, b) -> a + b) findMaxList
    let max = List.max sumOfTwoList
    List.findIndex (fun i -> i = max) sumOfTwoList

printfn "%A" (findPos [1; 5; 6; 2])
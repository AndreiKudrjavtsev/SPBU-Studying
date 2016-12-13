let powersOfTwo powersRangeStart = 
  let rec formList list currentPower iter = 
    if iter <> 5 then 
      let list = list @ [(pown 2 currentPower)] 
      formList list (currentPower + 1) (iter + 1)
    else 
      list
  formList [] powersRangeStart 0

printfn "%A" (powersOfTwo 0)
printfn "%A" (powersOfTwo 5)
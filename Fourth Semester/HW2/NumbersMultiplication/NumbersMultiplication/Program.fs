let numbersMulti number = 
    let rec multiCount value acc = 
        if value > 9 
        then multiCount (value / 10) (acc * (value % 10))
        else acc * (value % 10)
    multiCount number 1

printfn "%A" (numbersMulti 1234)
printfn "%A" (numbersMulti 100)
printfn "%A" (numbersMulti 333)
printfn "%A" (numbersMulti 0)
printfn "%A" (numbersMulti 1239859)
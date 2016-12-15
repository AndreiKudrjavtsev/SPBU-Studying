let isPalindrome string = 
    let rec palindromeCheck str pos = 
        if pos = (String.length str / 2)
        then true
        elif str.[pos] <> str.[str.Length - pos - 1] 
        then false
        else palindromeCheck str (pos + 1) 
    palindromeCheck string 0

printfn "%A" (isPalindrome "abba")
printfn "%A" (isPalindrome "abbac")
printfn "%A" (isPalindrome "abbba")
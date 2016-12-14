type Record = {
    Name : string
    Number : string
    }

let addRecord book newRec = 
    let newBook = newRec :: book
    newBook

let rec findByNumber book number = 
    match book with 
    | h :: t -> if h.Number = number then Some(h.Name) else findByNumber t number
    | [] -> None

let rec findByName book name = 
    match book with 
    | h :: t -> if h.Name = name then Some(h.Number) else findByName t name
    | [] -> None

let saveInFile book = 
    let rec convertToData book data = 
        match book with 
        | h :: t -> convertToData t (h.Name :: h.Number :: data)
        | [] -> data 
    let data = convertToData book []
    System.IO.File.WriteAllLines(@"book.txt", data)

let readFromFile book = 
    let data = System.IO.File.ReadAllLines(@"book.txt") |> Seq.toList
    printfn "%A" data
    let rec convertToBook book data = 
        match data with 
        | h :: t -> convertToBook ({Name = h; Number = (List.head t)} :: book) (List.tail (List.tail data))
        | [] -> book
    convertToBook book data

// Записи в файле - для каждого имени/телефона отдельная строка
let phoneBook = 
    let rec iterate book = 
        printfn "Select action you want: "
        printfn "0 - exit"
        printfn "1 - add record"
        printfn "2 - find number by name" 
        printfn "3 - find name by number" 
        printfn "4 - save book in file" 
        printfn "5 - load book from file"
        let action = System.Console.ReadLine()
        match action with 
        | "0" -> ()
        | "1" -> printfn "Enter the name: " 
                 let name = System.Console.ReadLine()
                 printfn "Enter the phone number: "
                 let number = System.Console.ReadLine()
                 iterate <| addRecord book { Name = name; Number = number }
        | "2" -> printfn "Enter the name to find: " 
                 let name = System.Console.ReadLine()
                 match findByName book name with
                 | Some(number) -> printfn "%s" number
                 | None -> printfn "No record with this name in book" 
                 iterate book
         | "3" -> printfn "Enter the number to find: " 
                  let number = System.Console.ReadLine()
                  match findByNumber book number with
                  | Some(name) -> printfn "%s" name
                  | None -> printfn "No record with this number in book" 
                  iterate book
        | "4" -> saveInFile book 
                 printfn "Saved "
                 iterate book
        | "5" -> let book = readFromFile book
                 printfn "Added records from file"
                 iterate book
        | _ -> printfn "Wrong action, try again "
               iterate book
    iterate []

phoneBook
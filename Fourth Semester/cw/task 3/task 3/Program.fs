exception EmptyQueueException of string

let rec remove index list =
    match index, list with
    | 0, x::xs -> xs
    | index, x::xs -> x::remove (index - 1) xs
    | index, [] -> failwith "index out of range"
        
type 'a QueueElement =
       struct        
          val Value: 'a
          val Priority: int
          new(value: 'a, priority: int) = { Value = value; Priority = priority }
       end

type 'a Queue() =
    let mutable list : 'QueueElement list = []

    member this.isEmpty = 
        list.Length = 0

    member this.enqueue(value, priority) = 
        let element = new QueueElement<'a> (value, priority)
        list <- element :: list

    member this.extractMax =
        if (list.IsEmpty) then
            raise (EmptyQueueException "Error, queue is empty")

        let mutable indexMaxPriority = 0;
        for i = 0 to list.Length - 1 do
            if (list.Item(i).Priority > list.Item(indexMaxPriority).Priority) then
                indexMaxPriority <- i       
        let res = list.Item(indexMaxPriority).Value
        let resPriority = list.Item(indexMaxPriority).Priority
        list <- remove indexMaxPriority list
        (res, resPriority)

let queue = Queue<char>()

queue.enqueue ('a', 2)
queue.enqueue ('b', 7)
queue.enqueue ('c', 5)
queue.enqueue ('d', 7)

printfn "%A" queue.extractMax
printfn "%A" queue.extractMax
printfn "%A" queue.extractMax
printfn "%A" queue.extractMax

try
    printfn "%A" queue.extractMax
with
    | EmptyQueueException message -> printfn "%s" message

printfn "is queue really empty? %A" queue.isEmpty
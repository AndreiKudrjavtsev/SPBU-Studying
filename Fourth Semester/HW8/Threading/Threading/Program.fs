open System.Threading

let SumMillion = 
    let res = ref 0
    let array = Array.init 1000000 (fun i -> 1)
    let threads = [| for i in 0 .. 99 -> new Thread(ThreadStart(fun _ ->
                         for j in i * 10000 .. (i + 1) * 10000 - 1 do
                            res := !res + array.[j])) |]

    Array.iter (fun (thread: Thread) -> thread.Start()) threads
    Array.iter (fun (thread: Thread) -> thread.Join()) threads
    !res

SumMillion |> printfn "%A"
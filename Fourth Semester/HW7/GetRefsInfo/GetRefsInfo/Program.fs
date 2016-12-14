open System.IO
open System.Net
open System.Text.RegularExpressions

let getInfo url =
    // для потоков
    let fetchAsync (url: string) = 
        async {
            let req = WebRequest.Create(url)
            use! resp = req.AsyncGetResponse()
            use stream = resp.GetResponseStream()
            let reader = new StreamReader(stream)
            let pageContent = reader.ReadToEnd()
            do printfn "%s --- %d" url pageContent.Length
        }
    
    // ф-я чтобы получить содержимое страницы, с которой будем читать ссылки
    let getPageContent (url: string) = 
        let req = WebRequest.Create(url)
        let resp = req.GetResponse()
        let stream = resp.GetResponseStream()
        let reader = new StreamReader(stream)
        let pageContent = reader.ReadToEnd()
        resp.Close()
        pageContent

    let regExp = new Regex("<a.*href=\"http.*\">")
    let refs = regExp.Matches(getPageContent url)
    let getRefs = [| for ref in refs -> ref.Value.Substring(ref.Value.IndexOf("\"") + 1, ref.Value.IndexOf("\">") - ref.Value.IndexOf("\"") - 1) |]
    let tasks = [| for ref in getRefs -> fetchAsync ref|]
    Async.Parallel tasks |> Async.RunSynchronously |> ignore

getInfo("http://se.math.spbu.ru/SE/Members/ylitvinov/14-44/resultsSpring2016_244_Yurii")
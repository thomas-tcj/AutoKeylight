module Data.KeylightApi

open System.Net.Http
open System.Text

let switchKeylight (ip: string) (on: bool) = 
    let ip = $"http://{ip}:9123/elgato/lights"
    task {
        use client = new HttpClient()
        let on = if on then 1 else 0
        let httpContent = new StringContent(sprintf "{\"lights\": [{\"on\": %i}]}" on, Encoding.UTF8, "application/json")
        let! response = client.PutAsync(ip, httpContent)

        if response.IsSuccessStatusCode then
            return ()
        else
             failwith <| sprintf "Failed request trying to reach Keylight: %O" response.Content
    } 
    |> Async.AwaitTask 
    |> Async.RunSynchronously
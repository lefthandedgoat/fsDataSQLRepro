module Program


[<EntryPoint>]
let main argv =
  printfn "%A" <| sqlQueries.runReproquery()
  1
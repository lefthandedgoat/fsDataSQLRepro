module sqlQueries

open FSharp.Data


//===============================================================================================
[<Literal>]
let reproquery = """
select count(*) as cnt from
(
  select 1 as number
  union all
  select 2 as number
  union all
  select 3 as number
) as numbers

"""

type Reproquery = SqlCommandProvider<reproquery, """Server=.\SQLEXPRESS;Integrated Security = true;""">

let runReproquery () =
  let cmd = new Reproquery()
  cmd.Execute()
  |> List.ofSeq
  |> List.head
  
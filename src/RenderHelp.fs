module RenderHelp

open Fable.Helpers.React
open Fable.Helpers.React.Props
open App.Types
open Fable.Core.JsInterop

let gray = Style [!!("color","#747474")]

let lines s =
    let lines =
        span [gray; ClassName "title is-6"] [Seq.head s |> str; br[]]
        ::
        (Seq.tail s |> Seq.map str |>  Seq.toList)
        @
        if Seq.tail s |> Seq.isEmpty |> not then [br[]] else []
    p [] (lines @ [br[]])

let tLevel = function 0 -> "subtitle is-4" | 1 -> "subtitle is-5" | _ -> "subtitle is-6"

let rec genContents level  = function
    | Contents cs ->
        div []
                [for c in cs do
                    yield div [ClassName (tLevel level)] [str c.Title]
                    yield genContents (level + 1) c.Contents
            ]
    | Items is -> div [] (is |> Seq.map lines |> Seq.toList)
    | Empty    -> div [][]

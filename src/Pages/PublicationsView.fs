module Publications.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.JS
open Fable.Helpers.React
open Fable.Helpers.React.Props
open App.Types
open RenderHelp

let rec genSection idx (c:Contents) =
    match c with
    | Contents cs when idx >= 0 && idx < cs.Length ->
        div
            []
            [
                yield div [ClassName "subtitle is-3"] [str cs.[idx].Title]
                yield  genContents 0 cs.[idx].Contents
            ]
    | _ -> div[][str "section not found"]

let st = Style [!!("margin","5px")]

let generateTop (c:Contents) = 
    match c with
    | Contents cs -> div []
                        (cs
                        |> Seq.mapi (fun i  c ->
                            a
                                [ ClassName " button"; st; Href (toHash (Publications i))]
                                [str c.Title]) |> Seq.toList)
    | Items is -> div [ClassName "content"] (is |> Seq.map lines |> Seq.toList)
    | Empty    -> div [][]

let rec genContent page (c:Contents) =
    match page with
    | Publications -1       -> generateTop c
    | Publications section  -> genSection section c
    | _                     -> div [] [str "no content"]

let root (model:Model)  =
  div
    []
    [
        div 
            [ClassName "title"]
            [str "Publications"]
        div
            [ ClassName "box" ]
            [ p
                []
                [
                  yield
                      match model.Publications with
                      | Empty _ -> str "loading ..."
                      | c       -> genContent model.currentPage c
                ]
            ]
    ]

module Dissertations.View
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.JS
open Fable.Helpers.React
open Fable.Helpers.React.Props

open App.Types
open RenderHelp

let root (model:Model) =
  div
    []
    [
        div 
            [ClassName "title"]
            [str "Dissertations"]
        div
            [ ClassName "box" ]
            [ p
                []
                [
                  yield
                      match model.Dissertations with
                      | Empty _ -> str "loading ..."
                      | c       -> genContents 0 model.Dissertations
                ]
            ]
    ]

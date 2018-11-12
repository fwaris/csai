module Projects.View

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
            [str "Projects"]
        div
            [ ClassName "box" ]
            [ p
                []
                [
                  yield
                      match model.Projects with
                      | Empty _ -> str "loading ..."
                      | c       -> genContents 0 model.Projects
                ]
            ]
    ]

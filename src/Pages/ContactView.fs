module Contact.View
open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div
    [ ]
    [ h1 [ClassName "title"] [str "Contact"]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Lab Supervisor Contact Info"]
          div [ClassName "card-content"]
              [
                table [ClassName "table"]
                    [
                        tr []
                            [
                                td [] [str "Lab Supervison"]
                                td [] [str "Dr. Robert Reynolds"]
                            ]
                        tr []
                            [
                                td [] [str "Telephone"]
                                td [] [str " 313-577-0726"]
                            ]
                        tr []
                            [
                                td [] [str "E-Mail"]
                                td [] [str "reynolds@cs.wayne.edu"]
                            ]
                        tr []
                            [
                                td [] [str "Address"]
                                td [] [str "5057 Woodward, Suite 14001.5 "]
                            ]
                    ]
              ]
        ]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Webmaster Contact Info"]
          div [ClassName "card-content"]
              [
                table [ClassName "table"]
                    [
                        tr []
                            [
                                td [] [str "Webmaster"]
                                td [] [str "..."]
                            ]
                        tr []
                            [
                                td [] [str "Telephone"]
                                td [] [str "..."]
                            ]
                        tr []
                            [
                                td [] [str "E-Mail"]
                                td [] [str "..."]
                            ]
                        tr []
                            [
                                td [] [str "Address"]
                                td [] [str "5057 Woodward, Suite 14001.5 "]
                            ]
                    ]
              ]
        ]
  ] 


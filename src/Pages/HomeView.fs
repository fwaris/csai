module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
    div [ClassName "content is-fluid"]
        [
            div [Style [
                    CSSProp.Position "absolute"
                    CSSProp.Right "0"
                    CSSProp.Top "500"
                    ]]
                [
                    image [Src "img/reynolds_trnsp.png"] []
                ]               
            div [ ClassName "tile is-ancestor is-vertical" ]
                [
                    div [ClassName "tile is-parent"]
                        [

                            div [ClassName "tile"]
                                [
                                    div [ClassName "title is-5"]
                                        [
                                            p[][str "Dr. Robert Reynolds"]
                                            p[ClassName "subtitle is-8"]
                                                [
                                                str "Prof. Computer Science, College of Engineering"
                                                br[]
                                                str "Director of Artificial Inteligence lab"
                                                ]
                                        ]
                             
                                ]
                        ]
                    br[]
                    div [ClassName "hero is-small is-dark tile"]
                        [
                            div [ClassName "hero-body"]
                                [
                                    div [ClassName "title is-4"] [str "Research Interest"]

                                    li [] [a [Href "#research"] [str "Multi-Agent Modeing"]]
                                    li [] [a [Href "#research"] [str "Evolutionary Computation"]]
                                ]

                        ]
                    br[]
                    div [ClassName "hero is-small is-dark tile"]
                        [
                            div [ClassName "hero-body"]
                                [
                                    div [ClassName "container"]
                                       [
                                            div [ClassName "title is-4"] [str "Call for Papers"]
                                            li [] [a [Href "docs/wcci.pdf"] [str "WCCI Workshop on the Ethics and Social Implications of Computational Intelligence  2018  CALL FOR PAPERS"]]
                                            br[]
                                            li []
                                                [
                                                    a [Href "docs/hca.docx"]
                                                        [
                                                            str "PROPOSED SIS SPECIAL SESSION"
                                                            br []
                                                            str "Hybrid Cultural Algorithms: Beyond Classical Cultural Algorithms"
                                                        ]
                                                ]

                                        ]
                                ]

                        ]
                ]
        ]


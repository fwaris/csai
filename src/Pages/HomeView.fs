module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props

//<a class="twitter-timeline" href="https://twitter.com/waynestate?ref_src=twsrc%5Etfw">Tweets by waynestate</a> <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script> 

let root =
    div [ClassName "content is-fluid"]
        [
            div [ ClassName "tile is-ancestor is-vertical" ]
                [
                    div [ClassName "tile is-parent"]
                        [
                            div [ClassName "tile"]
                                [
                                    div [ClassName "title is-5"]
                                        [
                                            p[][str "Dr. Robert Reynolds"]
                                            p[ClassName "subtitle is-6"]
                                                [
                                                str "Prof. Computer Science, College of Engineering"
                                                br[]
                                                str "Director of Artificial Inteligence lab"
                                                ]
                                        ]
                                ]
                        ]
                    br[]
                    div [ClassName "hero is-small is-light tile"]
                        [
                            div [ClassName "hero-body"]
                                [
                                    div [ClassName "title is-4"] [str "Research Interest"]

                                    li [] [a [Href "#research"] [str "Multi-Agent Modeing"]]
                                    li [] [a [Href "#research"] [str "Evolutionary Computation"]]
                                ]

                        ]
                    br[]
                    div [ClassName "hero is-small is-light is-bold tile"]
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

            div [ClassName "content"]
                [
                    a
                        [
                            ClassName "twitter-timeline"
                            Href "https://twitter.com/waynestate?ref_src=twsrc%5Etfw"
                            Data ("width","300")
                            Data ("height","400")
                        ]
                        [str "Tweets by waynestate"]
                    script [Async true; Src "https://platform.twitter.com/widgets.js"; CharSet "utf-8"] []       
                ]
        ]


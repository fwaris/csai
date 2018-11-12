module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open App.Types

let private menuLink dispatch href name =
    Navbar.Item.a 
        [ Navbar.Item.Props 
            [ OnClick (fun _ -> dispatch CloseBurger)
              ClassName "navbar-item"
              Href href]]
        [str name]
    

let root isBurgerOpen dispatch =
  div []
    [ Container.container []
        [ Navbar.navbar [Navbar.Props [ ClassName "is-transparent"]]
            [ Navbar.Brand.div []
                [ Navbar.Item.a [Navbar.Item.Props [Href "#home"]]
                    [ i [ClassName "fa fa-home fa-lg"] []]
                  Navbar.Item.a [Navbar.Item.Props [Href "#"]]
                    [ str "Comp. Sci. AI"]
                  Navbar.Item.a [Navbar.Item.Props [Href "http://engineering.wayne.edu/"]]
                    [ span[][str "[College"; em [] [str " of "]; str "Engineering]"]]
                  Navbar.burger [ Fulma.Common.CustomClass "is-hidden-tablet"
                                  Fulma.Common.CustomClass (if isBurgerOpen then "is-active" else "")
                                  Fulma.Common.Props [OnClick (fun _ -> dispatch ToggleBurger)]
                                ]
                    [   span[][]
                        span[][]
                        span[][] 
                    ]
                ]
              Navbar.menu [Navbar.Menu.CustomClass "is-hidden-tablet"; Navbar.Menu.IsActive isBurgerOpen ]
                [ Navbar.Start.div []
                    [ Navbar.Item.div [Navbar.Item.HasDropdown; Navbar.Item.IsHoverable ]
                        [   a [ ClassName "navbar-link is-active"; Href "#home"][str "Menu"]
                            Navbar.Dropdown.div []
                                ([
                                    "#about"            , "About Me"
                                    "#research"         , "Research"
                                    "#publications_-1"  , "Publications"
                                    "#dissertations"    , "Dissertations"
                                    "#researchprojects" , "Projects"
                                    "#teaching"         , "Teaching"
                                    "#contact"          , "Contact"
                                ]
                                |> List.map(fun (h,n) -> menuLink dispatch h n))
                        ]
                    ]
                ]
            ]
        ]
    ]



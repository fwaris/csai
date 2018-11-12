module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open App.Types

let root isBurgerOpen dispatch =
  div [ClassName "navbar-bg"]
    [ Container.container []
        [ Navbar.navbar [Navbar.CustomClass "is-primary"]
            [ Navbar.Brand.div []
                [ Navbar.Item.a [Navbar.Item.Props [Href "#home"]]
                    [ i [ClassName "fa fa-home fa-lg"] []]
                  Navbar.burger [ Fulma.Common.CustomClass (if isBurgerOpen then "is-active" else "")
                                  Fulma.Common.Props [OnClick (fun _ -> dispatch ToggleBurger)]
                                ]
                    [   span[][]
                        span[][]
                        span[][] 
                    ]
                ]
              Navbar.menu [ Navbar.Menu.IsActive isBurgerOpen ]
                [ Navbar.Start.div []
                    [ Navbar.Item.div [Navbar.Item.HasDropdown; Navbar.Item.IsHoverable ]
                        [   a [ ClassName "navbar-link is-active"; Href "#home"][str "Menu"]
                            Navbar.Dropdown.div []
                                [
                                    a [ClassName "navbar-item"; Href "#home"][str"Home"]
                                    a [ClassName "navbar-item"; Href "#about"][str"About"]
                                    a [ClassName "navbar-item"; Href "#research"][str"Research"]
                                    a [ClassName "navbar-item"; Href "#publications_-1"][str"Publications"]
                                    a [ClassName "navbar-item"; Href "#dissertations"][str"Dissertations"]
                                    a [ClassName "navbar-item"; Href "#researchprojects"][str"Projects"]
                                    a [ClassName "navbar-item"; Href "#teaching"][str"Teaching"]
                                    a [ClassName "navbar-item"; Href "#contact"][str"Contact"]
                                ]
                        ]
                    ]
                ]
            ]
        ]
    ]



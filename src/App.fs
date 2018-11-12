module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Types
open App.State

//importAll "../sass/main.sass" //now uses css instead of sass

open Fable.Helpers.React
open Fable.Helpers.React.Props

let menuItem label page currentPage =
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage =
  aside
    [ ClassName "menu" ]
    [
      ul
        [ ClassName "menu-list" ]
        [ menuItem "Home" Home currentPage
          menuItem "About" Page.About currentPage 
          menuItem "Research Area" Research currentPage
          menuItem "Publications" (Publications -1) currentPage
          menuItem "Dissertations" Dissertations currentPage
          menuItem "Research Projects" ResearchProjects currentPage
          menuItem "Teaching" Teaching currentPage
          menuItem "Contact" Contact currentPage
          ] ]

let root model dispatch =

  let pageHtml =
    function
    | Page.About        -> Info.View.root
    | Research          -> Research.View.root
    | Publications _    -> Publications.View.root model 
    | Dissertations     -> Dissertations.View.root model
    | ResearchProjects  -> Projects.View.root model
    | Teaching          -> Teaching.View.root
    | Contact           -> Contact.View.root
    | Home              -> Home.View.root

  div
    []
    [
      Navbar.View.root model.IsBurgerOpen dispatch
      div
        [ ClassName "section" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName "columns s-three-quarters-mobile" ]
                [ div
                    [ ClassName "column is-3 " ]
                    [ menu model.currentPage ]
                  div
                    [ ClassName "column" ]
                    [ pageHtml model.currentPage ] ] ] ] ]

open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
#if DEBUG
|> Program.withDebugger
|> Program.withHMR
#endif
|> Program.withReact "elmish-app"
|> Program.run

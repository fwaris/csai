module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div
    [ ClassName "content" ]
    [ h1 [] [str "About me"]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Robert G Reynolds"]
          div [ClassName "card-content container is-fluid"]
            [
              figure [ClassName "image is-128x128 notification"]
                     [img [Src "img/reynolds.jpg"]]
              label [] [str "Prof. Computer Science, College of Engineering"]
              br []
              label [] [str "Address: "];  str "5057 Woodward Suite 14001.5"
              br []
              label [] [str "Phone: " ]; str "(313) 577-0726"
            ]
        ]
      br[]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Rank"]
          div [ClassName "card-content"]
            [
              li [] [str "Tenure awarded: Septemer 1989"]
              li [] [str "Associate Professor: September 1986"]
              li [] [str "Full Professor: September 2000"]
            ]
        ]
      br[]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Appointments"]
          div [ClassName "card-content"]
            [
              li [] [str "Sabbatical: Fall 2001"]
              li [] [str "Sabbatical: Fall 1994 - August 1995"]
              li [] [str "Interim Chair, Computer Science: Sept. 1990 - Aug. 1992"]
              li [] [str "Assistant Professor: 1983"]
            ]
        ]
  ] 

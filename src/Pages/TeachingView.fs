module Teaching.View
open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div
    [ ]
    [ h1 [ClassName "title"] [str "Teaching"]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Years at Wayne State"]
          div [ClassName "card-content"]
            [
              label [] [str "Department of Computer Science, September, 1983 to present"]
            ]
        ]
      br[]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Years at Other Colleges/Universities"]
          div [ClassName "card-content"]
            [
              li [] [str "University of Michigan, Department of Anthropology , 1981-1982. (Lecturer)"]
              li [] [str "Michigan State University, Department of Computer Science, 1979-1983. (Assistant Professor, Computer Science, College of Engineering)"]
              li [] [str "University of Michigan , Department of Computer Science, 1978-1979. (Teaching Assistant)"]
              li [] [str "University of Michigan , Department of Geography, 1973-1975. (Teaching Assistant)"]
            ]
        ]
      br[]
      div [ClassName "card"]
        [
          div [ClassName "card-header-title"] [str "Courses Taught at Wayne State"]
          div [ClassName "card-content"]
            [
                div [ClassName "subtitle is-5"] [str "Graduate"]
                li [] [str "CSC 511 - Advanced Software Development"]
                li [] [str "CSC 520 - Programming Languages"]
                li [] [str "CSC 5800 - Artificial Intelligence Tools"]
                li [] [str "CSC 6110 – Software Engineering"]
                li [] [str "CSC 6140 - Knowledge Based Software Engineering Environments"]
                li [] [str "CSC 6260 - Compiler Design"]
                li [] [str "CSC 6500 - Theory of Automata and Languages"]
                li [] [str "CSC 6580 - Analysis of Algorithms"]
                li [] [str "CSC 6800 - Artificial Intelligence I"]
                li [] [str "CSC 7110 - Special Topics in Advanced Software Development"]
                li [] [str "CSC 7800 - Artificial Intelligence II: AI and Game Programming"]
                li [] [str "CSC 8110 – Seminar in Software Engineering"]
                li [] [str "CSC 8800 - Seminar on Intelligent Systems"]

                br[]
                div [ClassName "subtitle is-5"] [str "Undergraduate"]
                li [] [str "CSC 1000 - Introduction to Computer Science"] 
                li [] [str "CSC 1010 - Introduction to Computing"] 
                li [] [str "CSC 3200 - Programming Languages"] 
                li [] [str "CSC 4110 - Introduction to Software Engineering"] 
                li [] [str "CSC 4995 - Practical Training in Computer Science"] 
                li [] [str "CSC 4996 - Frontiers of Computing"]
            ]
        ]
  ] 

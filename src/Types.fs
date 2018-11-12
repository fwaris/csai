module App.Types

type Page =
  | Home
  | About
  | Research
  | Publications of int
  | Dissertations
  | ResearchProjects
  | Teaching
  | Contact

let toHash page =
  match page with
  | Home              -> "#home"
  | About             -> "#about"
  | Research          -> "#research"
  | Publications  s   -> sprintf "#publications_%d" s
  | Dissertations     -> "#dissertations"
  | ResearchProjects  -> "#researchprojects"
  | Teaching          -> "#teaching"
  | Contact           -> "#contact"

type Contents = Contents of Content [] | Items of string[][] | Empty
and Content = {Title:string; Contents:Contents}

type Msg =
    | GotPublications of Contents
    | GotDissertations of Contents
    | GotProjects of Contents
    | ToggleBurger
    | CloseBurger
    | AppEx of exn

type Model = {
    currentPage     : Page
    Publications    : Contents
    Dissertations   : Contents
    Projects        : Contents
    IsBurgerOpen    : bool
  }

let initModel =
    {
        currentPage     = Home
        Publications    = Empty
        Dissertations   = Empty
        Projects        = Empty
        IsBurgerOpen    = false
    }

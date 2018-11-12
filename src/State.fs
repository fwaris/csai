module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Types
open Fable.PowerPack.PromiseImpl
open Fable.PowerPack.Fetch
open Fable.SimpleJson
open Fable.Import.Browser

let pubParse =
    custom
        "pub"
        (fun s ->
            if s.Contains("publications") then
                if s.Contains("_") then
                    let parts = s.Split([|'_'|])
                    Ok (System.Int32.Parse parts.[1])
                else
                    Ok -1
            else
                Result.Error "not pub"
        )

let pageParser: Parser<Page->Page,Page> =
  oneOf [
    map About (s "about")
    map Research (s "research")
    map Publications pubParse
    map Dissertations (s "dissertations")
    map ResearchProjects (s "researchprojects")
    map Teaching (s "teaching")
    map Home (s "home")
    map Contact (s "contact")
  ]

let urlUpdate (result: Option<Page>) model =
  match result with
  | None ->
    console.error("Error parsing url")
    model,Navigation.modifyUrl (toHash model.currentPage)
  | Some page ->
      { model with currentPage = page }, []

let getContents resource =
    promise {
        let! resp =  fetch resource []
        let! j = resp.text()
        let  cntnts:Contents = j |> Json.parseAs<_>
        return cntnts
    }

let init result =
  let (model, cmd) = urlUpdate result initModel
  model, Cmd.batch [
                    Cmd.ofPromise getContents ("data/publications.json") GotPublications AppEx
                    Cmd.ofPromise getContents ("data/dissertations.json") GotDissertations AppEx
                    Cmd.ofPromise getContents ("data/projects.json") GotProjects AppEx
                   ]

   
let update msg model : Model*Cmd<Msg> =
    match msg with
    | GotPublications cntnt -> {model with Publications=cntnt},Cmd.none
    | GotDissertations cntnt -> {model with Dissertations=cntnt},Cmd.none
    | GotProjects cntnt -> {model with Projects=cntnt},Cmd.none
    | ToggleBurger      -> {model with IsBurgerOpen = not model.IsBurgerOpen},Cmd.none
    | AppEx e -> console.log(e.Message); model,Cmd.none

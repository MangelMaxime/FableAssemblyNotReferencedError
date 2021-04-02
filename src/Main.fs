module ETL.Main

open Glutinum.Express
open Node
open Fable.Core
open Fable.Core.JsInterop
open Glutinum.ServeStatic
open Glutinum.ExpressServeStaticCore

let app = express.express()

let mainRouter = express.Router()

mainRouter.post("/json", fun (req : Request) (res : Response) (next : NextFunction) ->
    let x = req.body.Value
    ()
)

app.``use``(mainRouter)

namespace GachoStrap.Controls

open System.Web.UI

type LiteralControl() =
    inherit Control()
    let mutable text: string = null 
    member this.Text 
        with public get() = text
        and public set value = text <- value
    override this.Render(writer : HtmlTextWriter) =
        writer.Write(this.Text)
            

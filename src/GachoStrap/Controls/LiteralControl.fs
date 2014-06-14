namespace GachoStrap.Controls

open System.Web.UI

type LiteralControl(text: string) =
    inherit Control()
    member val Text = text with get, set 
    override this.Render(writer) =
        writer.Write(this.Text)
            

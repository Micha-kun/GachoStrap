namespace GachoStrap.UT

open System.IO
open System.Web.UI

module ControlHelpers = 
    type Control with
        member this.ToHtmlString() =
            use sw = new StringWriter()
            use htw = new HtmlTextWriter(sw)
            this.RenderControl(htw)
            sw.ToString()


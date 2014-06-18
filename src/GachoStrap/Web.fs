namespace GachoStrap.Controls.Web

open System.Web.UI

type Button() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("Button")

type CheckBox() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("CheckBox")

type TextBox() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("<input type=\"text\" />")

type DropDownList() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("<input type=\"select\" />")

type HyperLink() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("HyperLink")

type Image() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("Image")

type GridView() =
    inherit Control()
    override this.Render(writer) =
        writer.Write("<div />")
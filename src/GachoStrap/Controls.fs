namespace GachoStrap.Controls

open System.Web.UI

type TextBox() =
    inherit Control() 
    override this.Render writer =
        writer.Write "TextBox"
        base.Render writer

type Button() =
    inherit Control() 
    override this.Render writer =
        writer.Write "Button"
        base.Render writer

type HyperLink() =
    inherit Control() 
    override this.Render writer =
        writer.Write "HyperLink"
        base.Render writer

type CheckBox() =
    inherit Control() 
    override this.Render writer =
        writer.Write "CheckBox"
        base.Render writer

type RadioButton() =
    inherit Control() 
    override this.Render writer =
        writer.Write "RadioButton"
        base.Render writer

type HiddenField() =
    inherit Control() 
    override this.Render writer =
        writer.Write "HiddenField"
        base.Render writer
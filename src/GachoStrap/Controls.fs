namespace GachoStrap.Controls

open System
open System.Web.UI

type TextChangedEventArgs(oldValue, newValue) =
    inherit EventArgs()
    member this.OldValue = oldValue
    member this.NewValue = newValue

type TextBox() =
    inherit Control()
    let textChanged = new Event<EventHandler<TextChangedEventArgs>, TextChangedEventArgs>()

    [<CLIEvent>]
    member this.TextChanged = textChanged.Publish

    member this.Text 
        with get () = this.ViewState.["Text"] :?> string
        and set (value : string) = 
            let oldValue = this.Text
            this.ViewState.["Text"] <- value
            textChanged.Trigger (this, new TextChangedEventArgs(oldValue, value))
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

type Image() =
    inherit Control()
    override this.Render writer =
        writer.Write "Image"
        base.Render writer

type Video() =
    inherit Control()
    override this.Render writer =
        writer.Write "Video"
        base.Render writer
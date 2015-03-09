namespace GachoStrap.Controls

open System
open System.Web.UI

type TextChangedEventArgs(oldValue, newValue) =
    inherit EventArgs()
    member this.OldValue = oldValue
    member this.NewValue = newValue

type TextBox() =
    inherit Control()

    static let textChangedKey = new obj();

    member private this.textChangedAddHandler hdl = base.Events.AddHandler (textChangedKey, hdl)
    member private this.textChangedRemoveHandler hdl = base.Events.RemoveHandler (textChangedKey, hdl)

    member private this.OnTextChanged args = 
        match base.Events.[textChangedKey] with
            | :? EventHandler<TextChangedEventArgs> as hdl -> hdl.Invoke(this, args)
            | _ -> ignore()

    [<CLIEvent>]
    member this.TextChanged = 
        { new IDelegateEvent<EventHandler<TextChangedEventArgs>> with
              member x.AddHandler(handler) = 
                  this.textChangedAddHandler handler
              
              member x.RemoveHandler(handler) = 
                  this.textChangedRemoveHandler handler }


    member this.Text 
        with get () = this.ViewState.["Text"] :?> string
        and set (value : string) = 
            let oldValue = this.Text
            this.ViewState.["Text"] <- value
            this.OnTextChanged (new TextChangedEventArgs(oldValue, value))

    override this.Render writer =
        writer.Write (@"<input type=""text"" value=""" + this.Text + @""" />")
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
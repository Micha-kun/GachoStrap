namespace GachoStrap.Controls

open System
open System.ComponentModel
open System.Web.UI

type private ControlEvent<'a when 'a :> EventArgs>(ehl : EventHandlerList, key)  =
    member this.Publish = 
        { new IDelegateEvent<EventHandler<'a>> with
              member x.AddHandler(handler) = 
                  ehl.AddHandler (key, handler)
              
              member x.RemoveHandler(handler) = 
                  ehl.RemoveHandler (key, handler) }

    member this.Trigger (sender, args) =
         match ehl.[key] with
            | :? EventHandler<'a> as hdl -> hdl.Invoke(this, args)
            | _ -> ignore()

type TextChangedEventArgs(oldValue, newValue) =
    inherit EventArgs()
    member this.OldValue = oldValue
    member this.NewValue = newValue

type TextBox() =
    inherit Control()
    static let textChangedKey = new obj();
    member private this.TextChangedEvent = new ControlEvent<TextChangedEventArgs>(base.Events, textChangedKey) 

    [<CLIEvent>]
    member this.TextChanged = this.TextChangedEvent.Publish

    member this.Text 
        with get () = this.ViewState.["Text"] :?> string
        and set (value : string) = 
            let oldValue = this.Text
            this.ViewState.["Text"] <- value
            this.TextChangedEvent.Trigger (this, new TextChangedEventArgs(oldValue, value))

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
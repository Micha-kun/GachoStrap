namespace GachoStrap.UT

open NUnit.Framework
open System.IO
open System.Web.UI

[<TestFixture>]
type LiteralControlRenderFixture() =
    [<TestCase>]
    member x.RenderLiteralControl() =
        using (new StringWriter()) (fun sw ->
            using (new HtmlTextWriter(sw)) (fun htw ->
                let ctrl = new GachoStrap.Controls.LiteralControl("<p>Hola")
                ctrl.RenderControl(htw)
                let text = sw.ToString()
                Assert.That(text, Is.EqualTo("<p>Hola"))
            )
        )
    [<TestCase>]
    member x.RenderLiteralControl2() =
        use sw = new StringWriter()
        use htw = new HtmlTextWriter(sw)
        let ctrl = new GachoStrap.Controls.LiteralControl("<p>Hola")
        ctrl.RenderControl(htw)
        let text = sw.ToString()
        Assert.That(text, Is.EqualTo("<p>Hola"))
            
        
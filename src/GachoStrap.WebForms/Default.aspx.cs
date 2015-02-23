using GachoStrap.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GachoStrap.WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.text.Text = "Text";
            this.text.Text = "Text2";
        }

        protected void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine(e.OldValue);
            Debug.WriteLine(e.NewValue);
        }
    }
}
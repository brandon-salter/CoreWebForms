// MIT License.
using System;
using System.Web.UI.HtmlControls;

public partial class LoadPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //add reference to jquery.placeholder.js in Head
        HtmlGenericControl jsPlaceholderRef = new HtmlGenericControl("script");
        jsPlaceholderRef.Attributes.Add("type", "text/javascript");
        jsPlaceholderRef.Attributes.Add("src", "/scripts/jquery.placeholder.js");
        this.Header.Controls.Add(jsPlaceholderRef);
    }
}

// MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using SystemWebUISample;

namespace SystemWebUISample.Pages;

public partial class LoadUserControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //panel1.Controls.Add(Page.LoadControl("~/controls/mycontrol.ascx"));
    }

    protected void HandleChildUpdate(SystemWebUISample.Enums.SupportingEnum NextControl, string Mode)
    {

    }
}

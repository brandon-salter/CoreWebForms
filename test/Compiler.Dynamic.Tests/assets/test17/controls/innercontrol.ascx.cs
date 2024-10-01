// MIT License.

using System.Web.UI;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace SystemWebUISample.Controls
{
    public partial class innercontrol : UserControl
    {
        public string HeaderText = "Header Working";


        public delegate void ButtonClickDelegate(string CommandName, string CommandArgument);
        public event ButtonClickDelegate ButtonClick;

        private string[] NoteCategoryList
        {
            get
            {
                return (string[])ViewState["NoteCategoryList"];
            }
            set
            {
                ViewState["NoteCategoryList"] = value;
            }
        }

    }
}

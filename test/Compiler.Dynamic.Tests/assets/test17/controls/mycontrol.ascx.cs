// MIT License.

using System.Web.UI;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace SystemWebUISample.Controls
{
    public partial class TestUserControl : UserControl
    {
        public string HeaderText = "Header Working";

        public event UpdateParentDelegate ChangeParentControl;

        public delegate void UpdateParentDelegate(SystemWebUISample.SupportingEnum NextControl, string Mode);
    }
}

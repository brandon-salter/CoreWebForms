// MIT License.

using System.Web.UI;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using SystemWebUISample.Base;
using SystemWebUISample;

public partial class TestUserControl : BaseControl
{
    public enum SupportingEnum
    {
        One,
        Two,
        Three
    }
    public string HeaderText = "Header Working";


    public event UpdateParentDelegate ChangeParentControl;

    public delegate void UpdateParentDelegate(SystemWebUISample.Enums.SupportingEnum NextControl, string Mode);
}

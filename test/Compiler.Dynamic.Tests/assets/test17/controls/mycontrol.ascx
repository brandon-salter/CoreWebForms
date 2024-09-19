<%@ Control Language="C#" AutoEventWireup="true" Inherits="SystemWebUISample.Controls.TestUserControl" Codebehind="mycontrol.ascx.cs" %>

<%@ register src="~/controls/innercontrol.ascx" tagprefix="mine" tagname="innercontrol" %>
<div>
    Hi from control!

    <mine:innercontrol ID="control" runat="server" ></mine:innercontrol>
</div>

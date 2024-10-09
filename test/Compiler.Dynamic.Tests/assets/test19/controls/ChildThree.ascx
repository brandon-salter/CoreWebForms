<%@ Control Language="C#" AutoEventWireup="true" Inherits="ChildThree" CodeBehind="ChildThree.ascx.cs" %>
<%@ Register Src="~/controls/Grandchild.ascx" TagName="Grandchild" TagPrefix="uc" %>
<%@ Register Src="~/controls/ChildTwo.ascx" TagName="ChildTwo" TagPrefix="uc" %>

<div>
    This is the ChildThree control
</div>
<uc:ChildTwo ID="ucChildTwo" runat="server"  />
<uc:Grandchild ID="ucGrandchild" runat="server" />

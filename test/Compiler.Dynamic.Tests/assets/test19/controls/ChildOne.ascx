<%@ Control Language="C#" AutoEventWireup="true" Inherits="ChildOne" CodeBehind="ChildOne.ascx.cs" %>
<%@ Register Src="~/controls/Grandchild.ascx" TagName="Grandchild" TagPrefix="uc" %>
<%@ Register Src="~/controls/ChildTwo.ascx" TagName="ChildTwo" TagPrefix="uc" %>

<div>
    This is the ChildOne control
</div>
<uc:ChildTwo ID="ucChildTwo" runat="server"  />
<uc:Grandchild ID="ucGrandchild" runat="server" />

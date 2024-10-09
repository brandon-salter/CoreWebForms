<%@ Control Language="C#" AutoEventWireup="true" Inherits="ChildTwo" CodeBehind="ChildTwo.ascx.cs" %>
<%@ Register Src="~/controls/Grandchild.ascx" TagName="Grandchild" TagPrefix="uc" %>
<div>
    This is the ChildTwo control
</div>
<uc:Grandchild ID="ucGrandchild" runat="server" />

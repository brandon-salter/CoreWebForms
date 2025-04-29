<%@ Control Language="C#" AutoEventWireup="true" Inherits="Parent" CodeBehind="Parent.ascx.cs" %>
<%@ Register Src="~/controls/ChildOne.ascx" TagName="ChildOne" TagPrefix="uc1" %>
<%@ Register Src="~/controls/ChildTwo.ascx" TagName="ChildTwo" TagPrefix="uc1" %>
<%@ Register Src="~/controls/ChildThree.ascx" TagName="ChildThree" TagPrefix="uc1" %>
<%@ Register Src="~/controls/Grandchild.ascx" TagName="Grandchild" TagPrefix="uc1" %>

<div>
    This is the Parent control
</div>

<uc1:ChildOne ID="ucChildOne" runat="server" />
<uc1:ChildTwo ID="ucChildTwo" runat="server" />
<uc1:ChildThree ID="ucChildThree" runat="server" />
<uc1:Grandchild runat="server" ID="ucGrandchild" />

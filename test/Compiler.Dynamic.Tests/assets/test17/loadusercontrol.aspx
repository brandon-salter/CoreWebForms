<%@ page language="C#" autoeventwireup="true" Inherits="SystemWebUISample.LoadUserControl" CodeBehind="loadusercontrol.aspx.cs" %>

<%@ register src="~/controls/mycontrol.ascx" tagprefix="mine" tagname="mycontrol" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form runat="server">
        <asp:Panel ID="panel1" runat="Server">
            <mine:mycontrol ID="control" runat="server" ></mine:mycontrol>

        </asp:Panel>
    </form>

</body>
</html>

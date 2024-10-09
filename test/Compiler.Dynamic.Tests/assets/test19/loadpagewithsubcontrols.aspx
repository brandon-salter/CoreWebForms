<%@ page language="C#" autoeventwireup="true" %>

<%@ Register Src="~/controls/Parent.ascx" TagName="Parent" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form runat="server">
        <asp:Panel ID="panel1" runat="Server">
            <uc1:Parent ID="ucParent" runat="server" />
        </asp:Panel>
    </form>
</body>
</html>

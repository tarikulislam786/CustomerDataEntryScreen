<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CustomerDataEntryWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="LblUsername" runat="server" Text="Username"></asp:Label>&nbsp;<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
     <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>&nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br /><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

    </div>
    </form>

</body>
</html>

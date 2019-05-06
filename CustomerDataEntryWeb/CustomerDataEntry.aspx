<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDataEntry.aspx.cs" Inherits="CustomerDataEntryWeb.CustomerDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">   
        
    <div>
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" Font-Size="16pt"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lblCountries" runat="server" Text="Country Name" Font-Size="16pt"></asp:Label>
        <asp:DropDownList ID="ddlCountries" runat="server">
            <asp:ListItem>AFGANISTAN</asp:ListItem>
            <asp:ListItem>BANGLADESH</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>AUSTRALIA</asp:ListItem>
        </asp:DropDownList>
     <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email" Font-Size="16pt"></asp:Label><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />

        <asp:RadioButton ID="male" runat="server" Text="Male" Font-Size="16pt" GroupName="Gender" />
        <asp:RadioButton ID="Female" runat="server" Text="Female" Font-Size="16pt" GroupName="Gender" /><br />
        <asp:CheckBox ID="Reading" runat="server" Text="Reading" Font-Size="16pt" />
        <asp:CheckBox ID="Painting" runat="server" Text="Painting" Font-Size="16pt" /><br />
        <asp:RadioButton ID="Married" runat="server" Text="Married" Font-Size="16pt" GroupName="Status" />
        <asp:RadioButton ID="Unmarried" runat="server" Text="Unmarried" Font-Size="16pt" GroupName="Status" /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Height="28px" Width="67px" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Height="27px" Width="71px" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Height="28px" Width="72px" OnClick="btnDelete_Click" />
        <br /><br />
        <asp:GridView ID="GridCustomers" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridCustomers_SelectedIndexChanged">
        </asp:GridView>


    </div>
        
    </form>
    
</body>
</html>

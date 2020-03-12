<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseSession1.aspx.cs" Inherits="CRUD.UseSession1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        Your Name:-<asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>  
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="CRUD.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>hello
    <form id="form1" runat="server">
        <div>   
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10">
    <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="fname" HeaderText="First_Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="lname" HeaderText="Last_Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="email" HeaderText="Email" />
        <asp:BoundField ItemStyle-Width="150px" DataField="mo" HeaderText="Mobile" />
   </Columns>
</asp:GridView>
        </div>
    </form>
      
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fact.aspx.cs" Inherits="CRUD.fact" %>


<!DOCTYPE html>

<html >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width:280px">
            <legend>Factorial</legend>
            <table>   
                <tr>
                     <td>Enter The Number:</td><td><asp:textbox id="no1" runat="server" ></asp:textbox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btn1" runat="server" Text="Submit"></asp:Button></td>
                </tr> 
        
                <tr>
                       <td><h1 style="border:2px solid Tomato;"><asp:Label ID="label" runat="server"></asp:Label></h1></td>
                </tr> 
            </table>
                </fieldset>
        </div>
    </form>
</body>
</html>
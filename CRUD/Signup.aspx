<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="CRUD.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 <fieldset style="width:280px">
            <legend>Registration Form</legend>
            <table>            
                <tr>
                     <td>First Name:</td><td><asp:textbox id="txt1" runat="server" ></asp:textbox></td>
                     <td><asp:RequiredFieldValidator ID="validfname" runat="server" ControlToValidate="txt1" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Last Name:</td><td> <asp:textbox id="txt2" runat="server" ></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validlname" runat="server" ControlToValidate="txt2" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Email:</td><td><asp:TextBox ID="email" runat="server" TextMode="Email" ></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="validemail" runat="server" ControlToValidate="email" ErrorMessage="required!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email"
                       ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                        Display = "Dynamic" ErrorMessage = "Invalid email address"/></td>
                    </tr>
                <tr>
                    <td>Mobile:</td><td><asp:TextBox ID="mobile" runat="server" TextMode ="Phone"></asp:TextBox></td>
                   <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"  
                    ControlToValidate="mobile" ErrorMessage="Invalid Mobile Number" ForeColor="Red"
                    ValidationExpression="[0-9]{10}" Display = "Dynamic" /></td>  
                </tr>
               
               <tr>
                    <td><asp:Button ID="btn1" runat="server" Text="Submit"></asp:Button></td>
                    <td><asp:Button ID="btn2" runat="server" Text="Reset"></asp:Button></td>
                </tr>   
                <tr>
                       <td><asp:Label ID="Label1" runat="server"></asp:Label></td>
                </tr>   
            </table>
          </fieldset>
        </div>
    </form>
</body>
</html>

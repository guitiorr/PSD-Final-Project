<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FinalProjectPSD.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Username</p>
            <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
            <asp:Label ID="UsernameErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>Password</p>
            <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
            <asp:Label ID="PasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:CheckBox ID="RememberCB" runat="server" Text="REMEMBER ME" />
        </div>
        <div>
            <asp:LinkButton ID="RegisterBtn" runat="server" Text="GAPUNYA AKUN??? REGISTER YUKKK" OnClick="RegisterBtn_Click">GAPUNYA AKUN??? REGISTER YUKKK</asp:LinkButton>
        </div>
        <div>
            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
        </div>
    </form>
</body>
</html>

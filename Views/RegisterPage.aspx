<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FinalProjectPSD.Views.RegisterPage" %>

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
            <p>Email</p>
            <input type="email" id="EmailInput" runat="server" />
            <asp:Label ID="EmailErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>Gender</p>
            <asp:DropDownList ID="GenderDropDown" runat="server">
                <asp:ListItem Text="Select Gender" Value="" />
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="GenderErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>Password</p>
            <input type="password" id="passwordInput" runat="server" />
            <asp:Label ID="PasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>Confirm Password</p>
            <input type="password" id="confirmPasswordInput" runat="server" />
            <asp:Label ID="ConfirmPasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>Date of Birth</p>
            <input type="date" id="DOBInput" runat="server" />
            <asp:Label ID="DOBErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:LinkButton ID="LoginLink" runat="server" Text="PUNYA AKUN? LOGIN COY" OnClick="LoginLink_Click">LinkButton</asp:LinkButton>
        </div>
        <div>
            <asp:Button ID="SubmitBtn" runat="server" Text="Register" OnClick="SubmitBtn_Click"/>
        </div>
    </form>
</body>
</html>

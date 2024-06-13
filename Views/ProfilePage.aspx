<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavBar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FinalProjectPSD.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
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
            <p>Date of Birth</p>
            <input type="date" id="DOBInput" runat="server" />
            <asp:Label ID="DOBErrorLbl" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click"/>
        </div>

    </div>

    <div>
        <div>
            <p>Old Password</p>
            <asp:TextBox ID="oldPassTB" runat="server" TextMode="Password" />
            <asp:Label ID="oldPasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>New Password</p>
            <asp:TextBox ID="newPassTB" runat="server" TextMode="Password" />
            <asp:Label ID="PasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <p>Confirm New Password</p>
            <asp:TextBox ID="ConfirmNewPassTb" runat="server" TextMode="Password" />
            <asp:Label ID="ConfirmPasswordErrorLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="ChangePasswordBtn" runat="server" Text="Change Password" OnClick="ChangePasswordBtn_Click" />
        </div>
    </div>

    




</asp:Content>

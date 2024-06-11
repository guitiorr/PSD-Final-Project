<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FinalProjectPSD.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label ID="RoleLbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="NameLbl" runat="server" Text="Label"></asp:Label>
    </div>

    <asp:GridView ID="CustomerGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
            <asp:BoundField DataField="UserDOB" HeaderText="DOB" SortExpression="UserDOB" />
            <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
            <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole" />
            <asp:BoundField DataField="UserPassword" HeaderText="Password" SortExpression="UserPassword" />
        </Columns>
    </asp:GridView>


</asp:Content>

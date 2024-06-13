<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavBar.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="FinalProjectPSD.Views.ManageMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Button ID="InsertMakeupBtn" runat="server" Text="Insert Makeup" OnClick="InsertMakeupBtn_Click" />
        <asp:Button ID="InsertMakeupTypeBtn" runat="server" Text="Insert Makeup Type" OnClick="InsertMakeupTypeBtn_Click"/>
        <asp:Button ID="InsertMakeupBrandBtn" runat="server" Text="Insert Makeup Brand" OnClick="InsertMakeupBrandBtn_Click"/>
    </div>

    <asp:GridView ID="MakeupDataGV" runat="server" AutoGenerateColumns="False" OnRowEditing="MakeupDataGV_RowEditing" OnRowUpdating="MakeupDataGV_RowUpdating" OnRowDeleting="MakeupDataGV_RowDeleting" OnRowCancelingEdit="MakeupDataGV_RowCancelingEdit" OnRowCommand="MakeupDataGV_RowCommand">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" ReadOnly="True" />
            <asp:BoundField DataField="MakeupName" HeaderText="Makeup Name" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="Makeup Weight" SortExpression="MakeupWeight" />
            <asp:BoundField DataField="MakeupTypeID" HeaderText="Makeup Type ID" SortExpression="MakeupTypeID" />
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Makeup Type name" SortExpression="MakeupType.MakeupTypeName" />
            <asp:BoundField DataField="MakeupBrandID" HeaderText="Makeup Brand ID" SortExpression="MakeupBrandID" />
            <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Makeup Brand Name" SortExpression="MakeupBrand.MakeupBrandName" />
            <asp:BoundField DataField="MakeupBrand.MakeupBrandRating" HeaderText="Rating" SortExpression="MakeupBrand.MakeupBrandRating" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="false" />
            <asp:ButtonField ButtonType="Button" Text="Edit" CommandName="EditMakeup" />
        </Columns>
    </asp:GridView>





</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="FinalProjectPSD.Views.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="TransHeaderGV" runat="server" AutoGenerateColumns="False" OnRowCommand="TransHeaderGV_RowCommand">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Actions" ShowHeader="True" Text="View Details" />
        </Columns>

    </asp:GridView>


</asp:Content>

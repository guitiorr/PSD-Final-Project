<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/NavBar.Master" AutoEventWireup="true" CodeBehind="OrderMakeupPage.aspx.cs" Inherits="FinalProjectPSD.Views.OrderMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="MakeupDataGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MakeupID" HeaderText="ID" SortExpression="MakeupID" Visible="false" />
            <asp:BoundField DataField="MakeupName" HeaderText="Makeup Name" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight" />
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
            <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="QuantityTB" runat="server"></asp:TextBox>
                    <asp:Label ID="QuantityErrorLbl" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Order">
                <ItemTemplate>
                    <asp:Button ID="OrderBtn" runat="server" Text="Order" CommandName="Order" CommandArgument='<%# Eval("MakeupID") %>' OnClick="OrderBtn_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


    <div>
        <div>
            <h1>Cart</h1>
            <asp:Button ID="clearCartBtn" runat="server" Text="Clear Cart" OnClick="clearCartBtn_Click"/>
        </div>


       <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False" OnRowDataBound="CartGV_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="Item No.">
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="CartID" HeaderText="CartID" SortExpression="CartID" Visible="false"/>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" Visible="false" />
            <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup Name" SortExpression="Makeup.MakeupName" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>







    </div>





</asp:Content>

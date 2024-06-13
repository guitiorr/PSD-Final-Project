<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupPage.aspx.cs" Inherits="FinalProjectPSD.Views.InsertMakeupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click"/>
        </div>


        <asp:GridView ID="MakeupTypeGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName" />
            </Columns>
        </asp:GridView>

        <asp:GridView ID="MakeupBrandGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
                <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrandRating" />
            </Columns>
        </asp:GridView>


        <div>
            <p>Makeup Name</p>
            <asp:Label ID="MakeupNameErrorLbl" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="MakeupNameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <p>Makeup Weight</p>
            <asp:Label ID="MakeupWeightErrorLbl" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="MakeupWeightTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <p>Makeup Price</p>
            <asp:Label ID="MakeupPriceErrorLbl" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="MakeupPriceTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <p>Makeup Type ID</p>
            <asp:Label ID="MakeupTypeIDErrorLbl" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="MakeupTypeIDTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <p>Makeup Brand ID</p>
            <asp:Label ID="MakeupBrandIDErrorLbl" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="MakeupBrandIDTB" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
        </div>



    </form>
</body>
</html>

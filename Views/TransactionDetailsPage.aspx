<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetailsPage.aspx.cs" Inherits="FinalProjectPSD.Views.TransactionDetailsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
        </div>

        <div>

            <asp:GridView ID="TransactionDetailsGV" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                    <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup Name" SortExpression="Makeup.MakeupName" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>


            </asp:GridView>

        </div>
    </form>
</body>
</html>

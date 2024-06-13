<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupBrandPage.aspx.cs" Inherits="FinalProjectPSD.Views.InsertMakeupBrandPage" %>

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
            <p>MakeupBrandName</p>
            <asp:TextBox ID="MakeupBrandNameTB" runat="server"></asp:TextBox>
            <asp:Label ID="MakeupBrandNameErrorLbl" runat="server" Text=""></asp:Label>
        </div>


        <div>
            <p>MakeupBrandRating</p>
            <asp:TextBox ID="MakeupBrandRatingTB" runat="server"></asp:TextBox>
            <asp:Label ID="MakeupBrandRatingErrorLbl" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
        </div>


    </form>
</body>
</html>

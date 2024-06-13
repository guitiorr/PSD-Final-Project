<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMakeupTypePage.aspx.cs" Inherits="FinalProjectPSD.Views.InsertMakeupTypePage" %>

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
            <p>MakeupTypeName</p>            
            <asp:TextBox ID="MakeupTypeNameTB" runat="server"></asp:TextBox>
            <asp:Label ID="MakeupTypeNameErrorLbl" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click" />
        </div>



    </form>
</body>
</html>

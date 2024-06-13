<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionsReport.aspx.cs" Inherits="FinalProjectPSD.Views.ViewTransactionsReport" %>
<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="cr" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Transactions Report</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cr:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
        </div>
    </form>
</body>
</html>

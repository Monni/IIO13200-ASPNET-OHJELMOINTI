<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassDemo03_tapa01.aspx.cs" Inherits="ClassDemo03_tapa01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tapa 1: Query String</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Kohde 1: Query String -tapa</h1>
        <p>
            Sivulle lähetettiin parametrinä viesti:
            <%=Request.QueryString["Data"] %>
        </p>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassDemo03_tapa02.aspx.cs" Inherits="ClassDemo03_tapa02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tapa 2: HttpPost</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Kohde 2: HttpPost -tapa</h1>
        <p>
            Kutsuvalta sivulta luetaan viesti:
            <%=Request.Form["txtMessage"] %>
        </p>
    </div>
    </form>
</body>
</html>

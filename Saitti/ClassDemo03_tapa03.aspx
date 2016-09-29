<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassDemo03_tapa03.aspx.cs" Inherits="ClassDemo03_tapa03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Tapa 3: Käytetään Session</h1>
        <p>
            Sessionista luettu viesti:
            <%=Session["viesti"] %>
        </p>
    </div>
    </form>
</body>
</html>

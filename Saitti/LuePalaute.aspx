<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LuePalaute.aspx.cs" Inherits="LuePalaute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" Text="Näytä palautteet XML:stä" ID="btnShowXMLFeedback" OnClick="btnShowXMLFeedback_Click" />
            <asp:Button runat="server" Text="Näytä palautteet SQL:stä" ID="btnShowSQLFeedback" OnClick="btnShowSQLFeedback_Click" />
            <asp:GridView runat="server" ID="gvFeedback" />
            <asp:Label ID="lblFooter" runat="server" />
            <a href="Palaute.aspx">Anna palautetta</a>
        </div>
    </form>
</body>
</html>
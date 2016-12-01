<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClassDemo03.aspx.cs" Inherits="ClassDemo03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedonvälitysdemo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source-sivu</h1>
    <p>
        Lähetettävä viesti: <asp:TextBox ID="txtMessage" runat="server" />
        <!-- Tähän lista josta voi valita sopivan valmiin lauseen-->
        <asp:DropDownList ID="ddlMessages" runat="server" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList>
<br />
       <asp:Button ID="btnQueryString" runat="server" text="Käytä QueryString" OnClick="btnQueryString_Click"/><br />
       <asp:Button ID="btnHttpPost" runat="server" text="Käytä HttpPost" PostBackUrl="~/ClassDemo03_tapa02.aspx" /><br />
        <asp:Button ID="btnSession" runat="server" Text="Käytä Session" OnClick="btnSession_Click"/><br />
        <asp:Button ID="btnCookie" runat="server" Text="Käytä keksiä" OnClick="btnCookie_Click"/><br />
        <asp:Button ID="btnProperty" runat="server" Text="Käytä ominaisuutta (Public property)" OnClick="btnProperty_Click"/><br />
    </p>
    </div>
    </form>
</body>
</html>

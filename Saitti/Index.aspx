﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>IIO13200. NET Ohjelmointi</h1>
            <h2>1.kontaktikerta</h2>
            <p>Miikan oma hieno webbisaitti.</p>
            <h3>Perus HTML kontrolleja</h3>
            <a href="HtmlPage.html">Testi html-sivu</a>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Hello.aspx">My first ASPX page</asp:LinkButton>
            <p>
                Esimerkki ASP.NET DataKontrollista
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
            </p>
            <p>
                Esimerkki kuinka koodissa rakennetaan HTML:ää
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
            </p>
            <h2>
                22.9.2016
            </h2>
            <h3>Tiedon välitys sivulta toiselle:</h3>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ClassDemo03.aspx">Tiedon välitys</asp:HyperLink>
        </div>
    </form>
</body>
</html>

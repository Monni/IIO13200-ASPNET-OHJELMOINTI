<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index"
    MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
     <title>IIO13200 .NET Ohjelmointi</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">


   
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />

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
            <p>
                To 29.09.2016
                <a href="FordMustang.aspx">Demo responsiivinen sivu</a>
                <a href="MoviesFromXMLAP.aspx">Movies</a>
            </p>
            <table><tr>
                <th></th>
                   </tr></table>
        </div>

    </asp:Content>


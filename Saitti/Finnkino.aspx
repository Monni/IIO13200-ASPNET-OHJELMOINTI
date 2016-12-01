<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Finnkino.aspx.cs" Inherits="Finnkino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Finnkino tarjonta</title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body class="w3-yellow">
    <form id="form1" runat="server">
        <asp:XmlDataSource ID="xdsTheatres" runat="server" XPath="/TheatreAreas/TheatreArea" DataFile="http://www.finnkino.fi/xml/TheatreAreas/" />
        <asp:XmlDataSource ID="xdsEvents" runat="server" XPath="/Events/Event" DataFile="http://www.finnkino.fi/xml/Events/" />
        <asp:XmlDataSource ID="xdsShows" runat="server" XPath="/Schedule/Shows/Show" DataFile="http://www.finnkino.fi/xml/Events/" />
        <div class="w3-center w3-topbar w3-black w3-row" style="height:200px;" id="header">
            <img style="height:100%;" src="https://i.ytimg.com/vi/9TUVNqywQTw/maxresdefault.jpg" alt="Finnkino"/>
        </div>
        <div style="width:100%;">
            <div style="float:left;">
                 <asp:ListBox ID="lbTheatres" runat="server" Height="350px" Width="190px" OnSelectedIndexChanged="lbTheatres_SelectedIndexChanged" AutoPostBack="true" ></asp:ListBox>
            </div>
            <div class="w3-content" id="posterDiv">
                <asp:Literal runat="server" ID="ltPosters"></asp:Literal>
            </div>
        </div>
        <div id="footer">            
            <asp:Literal ID="ltFooter" runat="server" />
        </div>
    </form>
</body>
</html>
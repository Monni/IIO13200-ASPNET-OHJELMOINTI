<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teht06.aspx.cs" Inherits="Teht06_Teht06" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>T6 - Levykauppa X</title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:XmlDataSource ID="xdsAlbums" DataFile="~/App_Data/Teht06.xml" XPath="//record" runat="server"/>

    <div>
        <asp:ListView ID="lvAlbums" runat="server">
            <ItemTemplate>
                <div>
                    <div>
                        <img src='images/<%# Eval("ISBN") %>.jpg' alt="<%# Eval("ISBN") %>" />
                    </div>
                    <div style="position:center;">
                        <h3><%# Eval("Artist") %> : <%# Eval("Title") %></h3>
                        <p>
                            <b>ISBN:</b>
                            <asp:LinkButton Text='<%# Eval("ISBN") %>' runat="server" OnCommand="ShowRecord" CommandArgument="<%# (Record)Container.DataItem %>" /> <br />
                            <b>Hinta:</b><%# Eval("Price") %>
                        </p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div>
        <asp:Literal ID="ltFooter" runat="server" />
    </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Levyinfo.aspx.cs" Inherits="Teht06_Levyinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="ltRecord" runat="server" />
        <asp:ListView ID="lvTrackList" runat="server">
            <ItemTemplate>
                <p><%# Eval("number") %>. <%# Eval("name") %></p>
                <p>Lyriikat: <br /><%# Eval("lyrics") %></p>
            </ItemTemplate>
        </asp:ListView>
        <asp:Literal ID="ltFooter" runat="server" />
    </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teht01.aspx.cs" Inherits="Teht01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

         <h1>Tehtävä 01</h1>
        <h2>Ikkunan dimensiot:</h2>
        <p>Leveys(L)<asp:TextBox ID="L" runat="server" style="margin-left: 91px"></asp:TextBox> mm
         </p>
        <p>Korkeus(H)<asp:TextBox ID="H" runat="server" style="margin-left: 78px"></asp:TextBox> mm
         </p>
        <p>Karmipuun leveys(W):<asp:TextBox ID="W" runat="server" style="margin-left: 16px"></asp:TextBox> mm
         </p>
        

    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Laske tarjoushinta" OnClick="laskehinta" />
        <p>Ikkunan Pinta-ala: <asp:Label ID="pinta_ala" runat="server" Text="-" /></p>
        <p>Karmin Piiri: <asp:Label ID="karmin_piiri" runat="server" Text="-" /></p>
        <p>Tarjoushinta(Ilman ALV): <asp:Label ID="loppuhinta" runat="server" Text="-" /></p>
    </form>
</body>
</html>

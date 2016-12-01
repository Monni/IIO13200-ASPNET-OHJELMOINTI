<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UusiAsiakas.aspx.cs" Inherits="Teht05_UusiAsiakas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asiakkaan lisäys</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label runat="server" Text="Tunnus" />
                <asp:TextBox runat="server" ID="txtTunnus" /> 
            </div>
            <div>
                <asp:Label runat="server" Text="Nimi" />
                <asp:TextBox runat="server" ID="txtNimi" /> 
            </div>
            <div>
                <asp:Label runat="server" Text="Yhteyshenkilö" />
                <asp:TextBox runat="server" ID="txtYht" /> 
            </div>
            <div>
                <asp:Label runat="server" Text="Maa" />
                <asp:TextBox runat="server" ID="txtMaa" /> 
            </div>
            <div>
                <asp:Label runat="server"  Text="Postinumero" />
                <asp:TextBox runat="server" ID="txtPostinr" /> 
            </div>
            <div>
                <asp:Label runat="server" Text="Postitoimipaikka" />
                <asp:TextBox runat="server" ID="txtPostitmp" /> 
            </div>
            <div>
                <asp:Label runat="server" Text="Ostot" />
                <asp:TextBox runat="server" ID="txtOstot" /> 
            </div>
            <div>
                <asp:Label runat="server" Text="Vuosi" />
                <asp:TextBox runat="server" ID="txtVuosi" /> 
            </div>
            <div>
                <asp:Button runat="server" Text="Tallenna" ID="btnSaveCustomer" OnClick="btnSaveCustomer_Click" />
                <asp:LinkButton runat="server" ID="btnMainPage" Text="Katsele asiakkaita" PostBackUrl="~/Asiakkaat.aspx" />
            </div>
            <div><asp:Label runat="server" ID="lblFooter"></asp:Label></div>
        </div>
    </form>
</body>
</html>
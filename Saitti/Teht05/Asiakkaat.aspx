<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Asiakkaat.aspx.cs" Inherits="Teht05_Asiakkaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="btnGetCustomers" Text="Hae kaikki asiakkaat" OnClick="btnGetCustomers_Click" />
        <asp:DropDownList runat="server" ID="ddlCountry" />
        <asp:Button runat="server" ID="btnGetFromCountry" Text="Hae asiakkaat valitusta maasta" OnClick="btnGetFromCountry_Click" />
        <asp:Button runat="server" ID="btnGetCustomersByCountry" Text="Hae asiakkaat maittain" OnClick="btnGetCustomersByCountry_Click" />
        <asp:LinkButton runat="server" ID="lbCreateCustomer" Text="Luo uusi asiakas" PostBackUrl="~/UusiAsiakas.aspx" />
        <br />
        <asp:GridView runat="server" ID="gvCustomers" />
        <asp:Literal runat="server" ID="ltrlCustomers" />
    </div>
    </form>
</body>
</html>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Teht02.aspx.cs" Inherits="Teht02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Tehtava 02 - Lotto</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Label runat="server">Rivien lukumäärä</asp:Label>
    <asp:DropDownList ID="rivit" runat="server"></asp:DropDownList>
    <br />
    <asp:Label runat="server">Pelityyppi</asp:Label>
    <asp:DropDownList ID="type" runat="server">
        <asp:ListItem Text="Lotto" Value="Lotto"></asp:ListItem>
        <asp:ListItem Text="ViikingLotto" Value="ViikingLotto"></asp:ListItem>
    </asp:DropDownList>
        <br />
    <asp:Label runat="server" ID="showResults"></asp:Label>
    <br />
    <asp:Button ID="haeRivit" Text="Hae Rivit" runat="server" OnClick="haeRivit_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


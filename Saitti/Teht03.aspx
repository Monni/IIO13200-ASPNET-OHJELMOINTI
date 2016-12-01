<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Teht03.aspx.cs" Inherits="Teht03" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Tehtava 03 - Kalenteri</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
        <div>
            <asp:Button runat="server" ID="btnBack" Text="<vuosi" OnClick="btnBack_Click" />
            <asp:Button runat="server" ID="btnForward" Text="vuosi>" OnClick="btnForward_Click" />
            <asp:Calendar runat="server" ID="calendar" OnSelectionChanged="calendar_SelectionChanged"/>
            <br /> 
            <asp:Label runat="server" Text="Nykyinen päivä:"></asp:Label>
            <asp:Label runat="server" ID="lblCurrentDate"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Valittu päivä:"></asp:Label>
            <asp:Label runat="server" ID="lblChosenDate"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Erotus:"></asp:Label>
            <asp:Label runat="server" ID="lblDifference"></asp:Label>
            <br />
        </div>

    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


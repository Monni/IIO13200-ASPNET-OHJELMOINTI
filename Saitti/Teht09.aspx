<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Teht09.aspx.cs" Inherits="Teht09" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Tehtava 09 - VR train data</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div>
        <asp:DropDownList ID="ddlStations" runat="server" OnSelectedIndexChanged="ddlStations_SelectedIndexChanged"></asp:DropDownList>
        <asp:Button ID="btnGetTrains" runat="server" Text="Hae junat" OnClick="btnGetTrains_Click" />
        <asp:GridView runat="server" id="gvSchedule" />




    </div>





</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="SQLDataPage.aspx.cs" Inherits="SQLDataPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:SqlDataSource ID="srcCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:Customers %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]"></asp:SqlDataSource>
    <h1>SQLDataPage</h1>
    <div class="w3-half">
        <div class="w3-green">
            <p>Contents of an SQL-table in GridView</p>
        </div>
        <div class="w3-blue-grey">
            <asp:GridView ID="gvCustomers1" DataSourceID="srcCustomers" runat="server"></asp:GridView>
        </div>
    </div>
    <div class="w3-half">
        <div class="w3-blue">
            <p>Contents of an SQL-table with a precreated class</p>
        </div>
        <div class="w3-amber">
            <asp:GridView ID="gvCustomers2" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>
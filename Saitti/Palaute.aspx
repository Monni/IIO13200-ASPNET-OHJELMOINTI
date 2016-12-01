<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Palaute.aspx.cs" Inherits="Palaute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
        <form id="form1" runat="server">                   
            <asp:SqlDataSource ID="sdsFeedback" ConnectionString="<%$ ConnectionStrings:Mysli %>" runat="server" /> 
            <div>
                <h1>Opintojakson palaute</h1>
                <div>
                    <asp:Label runat="server" Text="Pvm:" />                
                    <asp:TextBox ID="txtDate" runat="server" Width="200px" />
                    <asp:RequiredFieldValidator ID="txtDateValidator" runat="server" ControlToValidate="txtDate" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>
                    <asp:Label runat="server" Text="Nimi:" />
                    <asp:TextBox ID="txtName" runat="server" Width="202px" Height="23px" />
                    <asp:RequiredFieldValidator ID="txtNameValidator" runat="server" ControlToValidate="txtName" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>
                    <asp:Label runat="server" Text="Opintojakson nimi:" />
                    <asp:TextBox runat="server" ID="txtCourseName" Width="196px" Height="16px" />
                    <asp:RequiredFieldValidator ID="txtCourseNameValidator" runat="server" ControlToValidate="txtCourseName" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>
                    <asp:Label runat="server" Text="Kurssin koodi:" />
                    <asp:TextBox runat="server" ID="txtCourseCode" Width="181px" Height="16px" />
                    <asp:RequiredFieldValidator ID="txtCourseCodeValidator" runat="server" ControlToValidate="txtCourseCode" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>

                    <asp:Label runat="server" Text="Olen oppinut:" />
                    <asp:TextBox runat="server" ID="txtLearned" Width="208px" Height="48px" />
                    <asp:RequiredFieldValidator ID="txtLearnedValidator" runat="server" ControlToValidate="txtLearned" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>
                    <asp:Label runat="server" Text="Haluan oppia:" />
                    <asp:TextBox runat="server" ID="txtToLearn" Width="203px" Height="50px" />
                    <asp:RequiredFieldValidator ID="txtToLearnValidator" runat="server" ControlToValidate="txtToLearn" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>
                    <asp:Label runat="server" Text="Hyvää:" />
                    <asp:TextBox runat="server" ID="txtGoods" Width="240px" Height="57px" />
                    <asp:RequiredFieldValidator ID="txtGoodsValidator" runat="server" ControlToValidate="txtGoods" ErrorMessage="Vaadittu kenttä!" />
                </div>
                 <div>
                    <asp:Label runat="server" Text="Huonoa:" />
                    <asp:TextBox runat="server" ID="txtFaults" Width="224px" Height="58px" />
                     <asp:RequiredFieldValidator ID="txtFaultsValidator" runat="server" ControlToValidate="txtFaults" ErrorMessage="Vaadittu kenttä!" />
                </div>
                <div>
                    <asp:Label runat="server" Text="Muuta:" />
                    <asp:TextBox runat="server" ID="txtOther" Width="220px" Height="64px" />
                </div>
                <br />
                <asp:Button runat="server" ID="btnSaveXml" Text="Tallenna XML-tiedostoon" OnClick="btnSaveXml_Click" />
                <asp:Button runat="server" ID="btnSaveSql" Text="Tallenna SQL-tietokantaan" OnClick="btnSaveSql_Click" />
                <br />
                <a href="LuePalaute.aspx">Lue palautteita</a>                
                <div>
                    <asp:Label runat="server" ID="lblFooter" />
                </div>
            </div>            
        </form>
    </body>
</html>
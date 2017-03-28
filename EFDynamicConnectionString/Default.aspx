<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="EFDynamicConnectionString._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>EF Dynamic Connection String</h1>
        <p class="lead">A basic template on setting dynamic connection string for Entity Framework data access projects.</p>
        <p>
            <asp:Button ID="btn_TestConn" runat="server" Text="Connecting &raquo;" CssClass="btn btn-primary btn-lg" />
        </p>
        <p>
            <asp:Label ID="lb_Message" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
    </div>    

</asp:Content>

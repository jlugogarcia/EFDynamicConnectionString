<%@ Page Title="Authenticated" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Connected_User.aspx.vb" Inherits="EFDynamicConnectionString.Connected_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">        
        <div class="col-md-4 col-md-offset-4">           
             <p class="text-center">
                
            </p>  
            <p class="text-center">
                <asp:Label ID="lbMessage" runat="server" Text="Congrats! You got connected" ForeColor="#0730CA" Visible="False"></asp:Label>
            </p>                      
        </div>      
              
    </div>  
</asp:Content>

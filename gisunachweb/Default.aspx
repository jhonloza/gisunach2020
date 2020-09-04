<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="gisunachweb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <p></p>
    </div>
        <image id="img" src="https://img.wallpapersafari.com/desktop/1920/1080/92/31/jkm706.jpg" style="width: 100%; height: auto;"/>
        <asp:Panel runat="server">
            <div style="position: absolute; top: 100px; left: 400px">
                <asp:Label runat="server" Text="Sistema de gestión" Style="font-family: 'Patua One'; font-size: 64px; color: white"></asp:Label>
            <div></div>
            <asp:Label runat="server" Text="de Emergencias al COVID 19" Style="font-family: 'Patua One'; font-size: 64px; color: white"></asp:Label>
            </div>
        </asp:Panel>
    <image id="img" src="http://www.ccjpv.com/wp-content/uploads/2017/05/sello-01.png" style="width: 300px; height: auto; position: absolute; top: 350px; right: 450px"/>
</asp:Content>
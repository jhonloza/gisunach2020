<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="gisunachweb.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    <br />
    <asp:Panel runat="server" HorizontalAlign="Center">
        <asp:Label runat="server" Text="INICIO DE SESION" style="font-family: 'Patua One'; font-size: 18px"/>
        <div><br /></div>
        <asp:Panel runat="server">
            <div class="row">
            <asp:Label runat="server" Text="Usuario" style="font-family: 'Patua One';"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="usuariotxt"/>
        </div>
        <div><br /></div>
        <div class="row">
            <asp:Label runat="server" Text="Contraseña" style="font-family: 'Patua One';"/>
            <asp:TextBox runat="server" ID="pass" TextMode="Password"/>
        </div>
        </asp:Panel>
        <div><br /></div>
        <asp:Button runat="server" ID="btningreso" Text="Ingresar" style="background-color: cornflowerblue" OnClick="btningreso_Click" />
    </asp:Panel>
    <br />
    <br />
    <br />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/pages/gis.master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="gisunachweb.pages.registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Table runat="server" HorizontalAlign="Left">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Style="width: 360px;">
                <asp:Panel runat="server" ID="Panel1" Width="360px" HorizontalAlign="Center">
                <asp:Label runat="server" Text="Registro de paciente contagiado de COVID 19" Style="font-family: 'Patua One'; font-size: 18px"></asp:Label>
                <br />
                    <br />
                    <asp:Label runat="server" Text="Informacion del paciente" Style="font-family: 'Patua One'; font-size: 16px"></asp:Label>
                    <br />
                    <br />
                    <asp:Table runat="server">
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Nombres:"/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtnombre"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Apellidos: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtapellido"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Fecha de Nacimiento: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" TextMode="Date" ID="txtfechan" style="width: 100%"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Sexo: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList runat="server" ID="ddsex" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione genero </asp:ListItem>
                  <asp:ListItem Value="Masculino"> Masculino </asp:ListItem>
                  <asp:ListItem Value="Femenino"> Femenino </asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Direccion Dom: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtdir"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Latitud: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtlat" ClientIDMode="Static"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Longitud: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtlong" ClientIDMode="Static" ></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Cedula: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtcedula"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Telefono Con: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txttelf"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Telefono Cel: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtcelular"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell HorizontalAlign="Right">
                            <asp:Label runat="server" Text="Correo Electónico: "/>&nbsp&nbsp&nbsp&nbsp&nbsp
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtemail"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                    <br />
                    <br />
                    <asp:Button runat="server" Text="Agregar Paciente" OnClick="RegistrarPaciente" Style="background-color: aquamarine; font-family: 'Patua One'; font-size: 20px"/>
            </asp:Panel>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <div id="myMap" style="height:640px; width:820px; margin: 15px;"></div>
                <script src="https://unpkg.com/leaflet@1.6.0/dist/leaflet.js"
   integrity="sha512-gZwIG9x3wUXg2hdXF6+rVkLF/0Vi9U8D2Ntg4Ga5I5BZpVkVxlJWbSQtXPSiUTtC0TjtGOmxa1AJPuV0CPthew=="
   crossorigin=""></script>
                <script src="../Scripts/map.js"></script>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
    
</asp:Content>

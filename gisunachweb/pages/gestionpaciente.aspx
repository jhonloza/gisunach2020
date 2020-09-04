<%@ Page Title="" Language="C#" MasterPageFile="~/pages/gis.master" AutoEventWireup="true" CodeBehind="gestionpaciente.aspx.cs" Inherits="gisunachweb.pages.gestionpaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" Style="width: 100%" HorizontalAlign="Center">
        <br />
        <asp:Label runat="server" Style="font-family: 'Patua One'; font-size: 24px">Datos para la gestion del paciente frente al COVID-19</asp:Label>
        <br />
        <asp:Table runat="server" Style="width: 100%">
            <asp:TableRow Style="width: 100%">
                <asp:TableCell Style="width: 50%;" HorizontalAlign="Center">
                    <br />
                    <asp:Label runat="server" Style="font-family: 'Patua One'; font-size: 18px">Informacion Personal</asp:Label>
                    <br /><br />
                    <asp:Panel runat="server" HorizontalAlign="Right">
                        <asp:Table runat="server">
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Numero de personas convive</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:TextBox runat="server" ID="txtpersonas"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Trabajo</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:DropDownList runat="server" ID="ddtrabajo" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione opción </asp:ListItem>
                  <asp:ListItem Value="Si"> Si </asp:ListItem>
                  <asp:ListItem Value="No"> No </asp:ListItem>
                            </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Estudio</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:DropDownList runat="server" ID="ddestudio" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione opción </asp:ListItem>
                  <asp:ListItem Value="Si"> Si </asp:ListItem>
                  <asp:ListItem Value="No"> No </asp:ListItem>
                            </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Tiene alguna enfermedad catastrofica</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:DropDownList runat="server" ID="ddec" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione opción </asp:ListItem>
                  <asp:ListItem Value="Si"> Si </asp:ListItem>
                  <asp:ListItem Value="No"> No </asp:ListItem>
                            </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Tiene Diabetes</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:DropDownList runat="server" ID="dddiabe" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione opción </asp:ListItem>
                  <asp:ListItem Value="Si"> Si </asp:ListItem>
                  <asp:ListItem Value="No"> No </asp:ListItem>
                            </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Tiene sobrepeso</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:DropDownList runat="server" ID="ddsobrep" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione opción </asp:ListItem>
                  <asp:ListItem Value="Si"> Si </asp:ListItem>
                  <asp:ListItem Value="No"> No </asp:ListItem>
                            </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow HorizontalAlign="Right">
                                <asp:TableCell>
                                    <asp:Label runat="server">Tiene Seguro del IESS</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell>
                                    <asp:DropDownList runat="server" ID="ddseguro" AutoPostBack="true" style="width:100%">
                                <asp:ListItem Selected="True" Value="White"> Seleccione opción </asp:ListItem>
                  <asp:ListItem Value="Si"> Si </asp:ListItem>
                  <asp:ListItem Value="No"> No </asp:ListItem>
                            </asp:DropDownList>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                    <br /><br />
                    <asp:Label runat="server" Style="font-family: 'Patua One'; font-size: 18px">Informacion del Contacto de Emergencia</asp:Label>
                    <br /><br />
                    <asp:Panel runat="server" HorizontalAlign="Center">
                        <asp:Label runat="server">Nombre del contacto</asp:Label>&nbsp&nbsp&nbsp
                        <asp:TextBox runat="server" ID="txtnombemer"></asp:TextBox>
                        <br />
                        <asp:Label runat="server">Numero telf. celular</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                        <asp:TextBox runat="server" ID="txttelfemer"></asp:TextBox>
                        <br />
                        <asp:Label runat="server">Correo Electronico</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        <asp:TextBox runat="server" ID="txtcorreoemer"></asp:TextBox>
                        <br />
                    </asp:Panel>
                </asp:TableCell>
                <asp:TableCell Style="width: 100%" HorizontalAlign="Center">
                    <br />
                    <asp:Label runat="server" Style="font-family: 'Patua One'; font-size: 18px">Informacion sobre trabajo</asp:Label>
                    <br /><br />
                    <asp:Panel runat="server" HorizontalAlign="Right">
                        <asp:Table runat="server" Style="width: 100%">
                            <asp:TableRow runat="server" Style="width: 100%">
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:Label runat="server">Nombre</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:TextBox runat="server" ID="txtnombretrab"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" Style="width: 100%">
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:Label runat="server">Direccion</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:TextBox runat="server" ID="txtdirtrab"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" Style="width: 100%">
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:Label runat="server">telefono</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:TextBox runat="server" ID="txttelftrab"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                    <br /><br />
                    <asp:Label runat="server" Style="font-family: 'Patua One'; font-size: 18px">Informacion sobre estudio</asp:Label>
                    <asp:Panel runat="server" HorizontalAlign="Right">
                        <asp:Table runat="server" Style="width: 100%">
                            <asp:TableRow runat="server" Style="width: 100%">
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:Label runat="server">Nombre de la Institucion Educativa</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:TextBox runat="server" ID="txtnombest"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" Style="width: 100%">
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:Label runat="server">Direccion</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:TextBox runat="server" ID="txtdirest"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow runat="server" Style="width: 100%">
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:Label runat="server">telefono</asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp
                                </asp:TableCell>
                                <asp:TableCell runat="server" Style="width: 100%">
                                    <asp:TextBox runat="server" ID="txttelfest"></asp:TextBox>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                    </asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <br />
        <asp:Button runat="server" ID="btnIngresarGestion" Text="Ingresar Gestion Paciente" style="background-color: aquamarine; font-family: 'Patua One'; font-size: 24px" OnClick="btnIngresarGestion_Click"/>
    </asp:Panel>
    
</asp:Content>

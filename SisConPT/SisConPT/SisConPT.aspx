<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SisConPT.aspx.cs" Inherits="SisConPT.SisConPT.SysConPT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
                    <legend>Seleccione planta</legend>
   <ol>
        <li>
        <asp:Label runat="server" AssociatedControlID="Plantas">Planta</asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Plantas" DataTextField="pladescri" DataValueField="pladescri" Height="30px" Width="310px" Font-Names="Century Gothic">
        </asp:DropDownList>
            <asp:SqlDataSource ID="Plantas" runat="server" ConnectionString="<%$ ConnectionStrings:CONTROLPTConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [pladescri] FROM [planta]"></asp:SqlDataSource>
        </li>
    </ol>
        </fieldset>
    <fieldset>
        <legend>Menu aplicaciones</legend>
        <ol>
            <li>

                <asp:TreeView ID="TreeView1" runat="server" LineImagesFolder="~/TreeLineImages" ShowLines="True">
                    <Nodes>
                        <asp:TreeNode Expanded="False" SelectAction="Expand" Text="Carga de datos" Value="Carga de datos">
                            <asp:TreeNode Expanded="False" SelectAction="Expand" Text="Por Numero  de Proceso" Value="Por Numero  de Proceso">
                                <asp:TreeNode Text="CC-PAC-005" Value="CC-PAC-005"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Expanded="False" SelectAction="Expand" Text="Por Codigo de Caja" Value="Por Codigo de Caja">
                                <asp:TreeNode Text="CC-PAC-005" Value="CC-PAC-005"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Expanded="False" SelectAction="Expand" Text="Consulta de Datos" Value="Consulta de Datos">
                            <asp:TreeNode Expanded="False" SelectAction="Expand" Text="Por numero de Proceso" Value="Por numero de Proceso">
                                <asp:TreeNode Text="CC-PAC-005" Value="CC-PAC-005"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Expanded="False" SelectAction="Expand" Text="Por Numero de Caja" Value="Por Numero de Caja">
                                <asp:TreeNode Text="CC-PAC-005" Value="CC-PAC-005"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>

            </li>
        </ol>
    </fieldset>
</asp:Content>

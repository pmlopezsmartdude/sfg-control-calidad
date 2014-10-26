﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SisConPT.aspx.cs" Inherits="SisConPT.SisConPT.SysConPT" %>
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
        <asp:DropDownList ID="DropDownList1" name="DropDownList1" runat="server" DataSourceID="Plantas" DataTextField="pladescri" DataValueField="pladescri" Height="30px" Width="310px" Font-Names="Century Gothic">
        </asp:DropDownList>
            <asp:SqlDataSource ID="Plantas" runat="server" ConnectionString="<%$ ConnectionStrings:CONTROLPTConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [pladescri] FROM [planta]"></asp:SqlDataSource>
        </li>
    </ol>
        </fieldset>
    <fieldset>
        <legend>Menu aplicaciones</legend>
        <asp:Table ID="Aplicaciones" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Names="Century Gothic" Height="74px" Width="966px">
            <asp:TableRow runat="server" BorderColor="Black" BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle">
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">Carga de Planillas Por proceso</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">Carga de Planillas por Código de caja</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">Consulta de planillas por proceso</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">Consulta de planillas por Códgo de caja</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server" BorderColor="Black" BorderStyle="Solid" HorizontalAlign="Center" VerticalAlign="Middle">
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">
                    <asp:Button ID="CCPAC05PP" runat="server" Text="CC-PAC-05 por proceso" />
                </asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">
                    <asp:Button ID="CCPAC05PCC" runat="server" onclick="Button2_Click" Text="CC-PAC-05 por Código de caja"  />
                </asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">
                    <asp:Button ID="Consporproceso" runat="server" Text="CC-PAC-05 por Proceso" /></asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid">
                    <asp:Button ID="Consporcodcaja" runat="server" Text="CC-PAC-05 por Código de caja" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </fieldset>
</asp:Content>

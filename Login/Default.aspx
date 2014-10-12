<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Control Producto Terminado</title>
    <style type="text/css">
        .auto-style1 {
            width: 56px;
            height: 49px;
        }
        .auto-style3 {
            height: 216px;
            width: 968px;
        }
    </style>
</head>
<body style="font-family: 'Century Gothic'; font-size: small; color: #000000">
    <div>

        <img align="middle" alt="Planta" class="auto-style1" longdesc="Planta" src="src/images/mb-poniente146.png" /></div>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Seleccione Planta"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Planta" DataTextField="pladescri" DataValueField="pladescri" Font-Names="Century Gothic">
        </asp:DropDownList>
        <asp:SqlDataSource ID="Planta" runat="server" ConnectionString="<%$ ConnectionStrings:CONTROLPTConnectionString %>" SelectCommand="SELECT [pladescri] FROM [planta]"></asp:SqlDataSource>
        <hr />
        <table border="1" width="100%"><tr><td class="auto-style3"><center>Herramientas</center><br /><center><asp:TreeView ID="TreeView1" runat="server" ShowLines="True">
            <Nodes>
                <asp:TreeNode Text="Menu de herramientas" Value="Menu de herramientas" Expanded="False" SelectAction="Expand">
                    <asp:TreeNode Text="CC-PAC-05" Value="CC-PAC-05"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            </asp:TreeView></center>
            </td></table>
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="306px"></asp:TextBox>
    
        <br />
        <asp:Button ID="btncerrar" runat="server" onclick="btncerrar_Click" 
            Text="Cerrar Sesión" Font-Names="Century Gothic" Height="27px" Width="129px" />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Form1 {
            height: 173px;
        }
        .auto-style1 {
            width: 149px;
            height: 136px;
        }
    </style>
</head>
<body>
    <div align="center" style="font-family: 'Century Gothic'; font-size: x-large; color: #000000">

        <img alt="Control de Calidad" class="auto-style1" longdesc="Sistema de control de calidad Producto Terminado" src="src/images/calidad2.png" />
        <hr />
        <br />
        Sistema de Control de Producto Terminado</div>
    <form id="Form1" runat="server">
    <div>
    <center>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            onauthenticate="Login1_Authenticate" BorderPadding="4" ForeColor="#333333" 
            Width="424px" Height="154px">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="#FFFFFF" 
                Font-Size="0.9em" />
        </asp:Login>
    </center>
    </div>
    </form>
    <hr />
    
        <div class="content-wrapper">
            <div class="float-left">
                <p style="font-family: 'Century Gothic'; font-size: x-small">
                    &copy; <%: DateTime.Now.Year %> - WTC Consultores Ltda.
                </p>
            </div>
        </div>
   
</body>
</html>

<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControlPTWeb.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>
    <section id="loginForm">
        <h2>Utilice una cuenta del sistema para iniciar sesión.</h2>
        <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>
                    <legend>Formulario de inicio de sesión</legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Nombre de usuario</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="El campo de nombre de usuario es obligatorio." />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Contraseña</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="El campo de contraseña es obligatorio." />
                        </li>
                        <!-- <li>
                            <asp:Label runat="server" AssociatedControlID="Plantas">Planta</asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Plantas" DataTextField="pladescri" DataValueField="pladescri" Height="30px" Width="310px" Font-Names="Century Gothic">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="Plantas" runat="server" ConnectionString="<%$ ConnectionStrings:CONTROLPTConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [pladescri] FROM [planta]"></asp:SqlDataSource>

                        </li> 
                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">¿Recordar cuenta?</asp:Label>
                        </li> -->
                    </ol>
                    <asp:Button runat="server" CommandName="Login" VerticalAlign="Middle" Font-Names="Century Gothic" Font-size="Smaller" Text="Iniciar sesión" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login>
        <p>
           <!-- <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Registrarse</asp:HyperLink>
            si no tiene una cuenta. -->
        </p>
    </section>

    <!-- <section id="socialLoginForm">
        <h2>Utilice otro servicio para iniciar sesión.</h2>
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
    </section> -->
</asp:Content>

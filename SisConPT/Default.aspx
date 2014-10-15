<%@ Page Title="HomePage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlPTWeb._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Sistema de Registro de Control de Producto Terminado</h2>
            </hgroup>
            <p>
                Para ingresar al sistema, Usted debe contar con una cuenta autorizada para hacerlo, en caso de no poseerla, debe
                <mark>ponerse en contacto con el Area de informática</mark>
                al correo <a href="mailto:Comput@sfg.cl?Subject=Acceso al sistema de Registro de Control de Producto Terminado" target="_top"> Area de informática</a>
                
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Operación del sistema:</h3>
    <ol class="round">
        <li class="one">
            <h5>Ingresar al sistema</h5>
            Al ingresar al sistema debera utilizar su cuenta y no debe olvidar seleccionar la planta con la cual operará.
            La selección incorrecta de planta no le permitirá encontrar la identificación correcta del producto al cual
            Usted sumistrará los datos de las planillas de control.
        </li>
        <li class="two">
            <h5>Selección del producto al cual Usted suministrará los datos</h5>
            El sistema está diseñado para seleccionar el producto mediante su código de barra,
            por lo tanto, para iniciar el registro, primero deberá selecciónar el producto escaneando
            su código de barra desde la etiqueta incorporada en el.
        </li>
        <li class="three">
            <h5>Que hacer en caso de no encontrar el producto?</h5>
            Favor tome contacto con el Area de informática y solicite instrucciones para continuar, esto se puede
            deber a que no se ha volcado la información del proceso desde Lotmanager al sistema.
        </li>
    </ol>
</asp:Content>

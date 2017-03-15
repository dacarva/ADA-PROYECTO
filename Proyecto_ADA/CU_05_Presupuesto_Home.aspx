<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="CU_05_Presupuesto_Home.aspx.vb" Inherits="Proyecto_ADA.CU_05_Presupuesto_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home presupuesto</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="to-increase-bottom-margin">
        <h1 class="text-center">PRESUPUESTO</h1>
        <div class="row">
            <asp:Button ID="Button1" runat="server" Text="Crear"
                CssClass="center-block btn-responsive btn btn-warning btn-md" />

        </div>
        <br />
        <div class="row">
            <asp:Button ID="Button2" runat="server" Text="Consultar"
                CssClass="center-block btn-responsive btn btn-warning btn-md" />
        </div>
        <br />
        <div class="row">
            <asp:Button ID="Button3" runat="server" Text="Informe de presupuesto disponible"
                CssClass="center-block btn-responsive btn btn-warning btn-md" />
            <br />
        </div>
    </div>


</asp:Content>

<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="Plan_auditoria.aspx.vb" Inherits="Proyecto_ADA.Plan_auditoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-2">
            <label>2. Plan de auditoría</label>

        </div>
    </div>
    <br />
    <div class="form-group row">
        <asp:Label ID="Label_Objetivo_PA" runat="server" Text="Label" AssociatedControlID="Objetivo_PA" CssClass="col-md-2 col-form-label">
                        Objetivo
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Objetivo_PA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Alcance_PA" runat="server" Text="Label" AssociatedControlID="Alcance_PA" CssClass="col-md-2 col-form-label">
                        Alcance
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Alcance_PA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Criterios_Auditoria_PA" runat="server" Text="Label" AssociatedControlID="Criterios_Auditoria_PA" CssClass="col-md-2 col-form-label">
                        Criterios de auditoría
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Criterios_Auditoria_PA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Proceso_PA" runat="server" Text="Label" AssociatedControlID="Proceso_PA" CssClass="col-md-2 col-form-label">
                        Proceso
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Proceso_PA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Fecha_Realizacion_PA" runat="server" Text="Label" AssociatedControlID="Fecha_Realizacion_PA" CssClass="col-md-2 col-form-label">
                        Fecha de realización
        </asp:Label>
        <div class="col-md-2">
            <asp:TextBox ID="Fecha_Realizacion_PA" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Auditado_PA" runat="server" Text="Label" AssociatedControlID="Auditado_PA" CssClass="col-md-2 col-form-label">
                        Auditado
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Auditado_PA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Auditador_PA" runat="server" Text="Label" AssociatedControlID="Auditador_PA" CssClass="col-md-2 col-form-label">
                        Auditador
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Auditador_PA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Requisito_PA" runat="server" Text="Label" AssociatedControlID="Requisito_PA" CssClass="col-md-2 col-form-label">
                        Requisito
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Requisito_PA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Duracion_PA" runat="server" Text="Label" AssociatedControlID="Duracion_PA" CssClass="col-md-2 col-form-label">
                        Duración
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Duracion_PA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="Responsable_SGSST_PA" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label_Responsable_SGSST_PA" runat="server" Text="Label" AssociatedControlID="Responsable_SGSST_PA">
                        Responsable SGSST
            </asp:Label>
        </div>

    </div>
    <div class="form-group row">
        <div class="col-md-1">
            <asp:Button ID="Button_Eliminar_PA" runat="server" Text="Eliminar" />
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button_Guardar_PA" runat="server" Text="Guardar" />
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button_Modificar_PA" runat="server" Text="Modificar" />
        </div>
    </div>
</asp:Content>

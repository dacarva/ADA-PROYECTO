<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="Programa_auditoria.aspx.vb" Inherits="Proyecto_ADA.Programa_auditoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-2">
            <label>1. Programa de auditorías</label>
        </div>
    </div>
    <br />
    <div class="form-group row">
        <asp:Label ID="Label_Objetivo_PRA" runat="server" Text="Label" AssociatedControlID="Objetivo_PRA" CssClass="col-md-2 col-form-label">
                        Objetivo
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Objetivo_PRA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Alcance_PRA" runat="server" Text="Label" AssociatedControlID="Alcance_PRA" CssClass="col-md-2 col-form-label">
                        Alcance
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Alcance_PRA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Periodicidad_PRA" runat="server" Text="Label" AssociatedControlID="Periodicidad_PRA" CssClass="col-md-2 col-form-label">
                        Periodicidad
        </asp:Label>
        <div class="col-md-3">
            <asp:TextBox ID="Periodicidad_PRA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Metodologia_PRA" runat="server" Text="Label" AssociatedControlID="Metodologia_PRA" CssClass="col-md-2 col-form-label">
                        Metodología
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Metodologia_PRA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Competencia_PRA" runat="server" Text="Label" AssociatedControlID="Competencia_PRA" CssClass="col-md-2 col-form-label">
                        Competencia a auditar
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Competencia_PRA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Recursos_PRA" runat="server" Text="Label" AssociatedControlID="Recursos_PRA" CssClass="col-md-2 col-form-label">
                        Recursos
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Recursos_PRA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-3">
            <asp:TextBox ID="Responsable_SGSST_PRA" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label_Responsable_SGSST_PRA" runat="server" Text="Label" AssociatedControlID="Responsable_SGSST_PRA">
                        Responsable SGSST
            </asp:Label>
        </div>
        <div class="col-md-2"></div>
        <div class="col-md-3">
            <asp:TextBox ID="Presidente_Copa_SST" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label_Presidente_Copa_SST" runat="server" Text="Label" AssociatedControlID="Presidente_Copa_SST">
                        Presidente Copasst
            </asp:Label>
        </div>
    </div>
    <div class="form-group row center-block" >
        <div class="center-block">
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
        </div>

    
</asp:Content>

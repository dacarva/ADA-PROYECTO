<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="Informe_auditoria.aspx.vb" Inherits="Proyecto_ADA.Informe_auditoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-2">
            <label>4. Informe de auditoría</label>
            
        </div>
    </div>
    <br />
    <div class="form-group row">
        <asp:Label ID="Label_Objetivo_IA" runat="server" Text="Label" AssociatedControlID="Objetivo_IA" CssClass="col-md-2 col-form-label">
                        Objetivo
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Objetivo_IA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Alcance_IA" runat="server" Text="Label" AssociatedControlID="Alcance_IA" CssClass="col-md-2 col-form-label">
                        Alcance
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Alcance_IA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Proceso_IA" runat="server" Text="Label" AssociatedControlID="Proceso_IA" CssClass="col-md-2 col-form-label">
                        Proceso
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Proceso_IA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Fecha_IA" runat="server" Text="Label" AssociatedControlID="Fecha_IA" CssClass="col-md-2 col-form-label">
                        Fecha
        </asp:Label>
        <div class="col-md-2">
            <asp:TextBox ID="Fecha_IA" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        </div>
        <asp:Label ID="Label_Ubicacion_IA" runat="server" Text="Label" AssociatedControlID="Ubicacion_IA" CssClass="col-md-1 col-form-label">
                        Ubicación
        </asp:Label>
        <div class="col-md-6">
            <asp:TextBox ID="Ubicacion_IA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Criterios_Auditoria_IA" runat="server" Text="Label" AssociatedControlID="Criterios_Auditoria_IA" CssClass="col-md-2 col-form-label">
                        Criterios de auditoría
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Criterios_Auditoria_IA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Hallazgo_IA" runat="server" Text="Label" AssociatedControlID="Hallazgo_IA" CssClass="col-md-2 col-form-label">
                        Hallazgo
        </asp:Label>
        <div class="col-md-3">
            <asp:TextBox ID="Hallazgo_IA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Label ID="Label_Tipo_Hallazgo_IA" runat="server" Text="Label" AssociatedControlID="Tipo_Hallazgo_IA" CssClass="col-md-2 col-form-label">
                        Tipo de hallazgo
        </asp:Label>
        <div class="col-md-4">
            <asp:DropDownList ID="Tipo_Hallazgo_IA" runat="server" CssClass="form-control">
                <asp:ListItem Text="Value1" />
                <asp:ListItem Text="Value2" />
                <asp:ListItem Text="Value3" />
                <asp:ListItem Text="Value4" />
                <asp:ListItem Text="Value5" />
            </asp:DropDownList>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Actividad_IA" runat="server" Text="Label" AssociatedControlID="Actividad_IA" CssClass="col-md-2 col-form-label">
                        Actividad
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Actividad_IA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Responsable_IA" runat="server" Text="Label" AssociatedControlID="Responsable_IA" CssClass="col-md-2 col-form-label">
                        Responsable
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Responsable_IA" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Fecha_Realizacion_IA" runat="server" Text="Label" AssociatedControlID="Fecha_Realizacion_IA" CssClass="col-md-2 col-form-label">
                        Fecha de realización
        </asp:Label>
        <div class="col-md-2">
            <asp:TextBox ID="Fecha_Realizacion_IA" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-md-1">
            <asp:Button ID="Button_Eliminar_IA" runat="server" Text="Eliminar" />
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button_Guardar_IA" runat="server" Text="Guardar" />
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button_Modificar_IA" runat="server" Text="Modificar" />
        </div>
    </div>

</asp:Content>

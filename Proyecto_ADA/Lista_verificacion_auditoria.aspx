<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="Lista_verificacion_auditoria.aspx.vb" Inherits="Proyecto_ADA.Lista_verificacion_auditoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-2">
            <label>3. Lista de verificación</label>

        </div>
        <br />
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Pregunta_VA" runat="server" Text="Label" AssociatedControlID="Pregunta_VA" CssClass="col-md-2 col-form-label">
                        Pregunta
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Pregunta_VA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Hallazgo_VA" runat="server" Text="Label" AssociatedControlID="Hallazgo_VA" CssClass="col-md-2 col-form-label">
                        Hallazgo
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Hallazgo_VA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Tipo_Hallazgo_VA" runat="server" Text="Label" AssociatedControlID="Tipo_Hallazgo_VA" CssClass="col-md-2 col-form-label">
                        Tipo de hallazgo
        </asp:Label>
        <div class="col-md-4">
            <asp:DropDownList ID="Tipo_Hallazgo_VA" runat="server" CssClass="form-control">
                <asp:ListItem Text="Value1" />
                <asp:ListItem Text="Value2" />
                <asp:ListItem Text="Value3" />
                <asp:ListItem Text="Value4" />
                <asp:ListItem Text="Value5" />
            </asp:DropDownList>
        </div>
    </div>
    <div class="form-group row">
        <asp:Label ID="Label_Requisito_VA" runat="server" Text="Label" AssociatedControlID="Requisito_VA" CssClass="col-md-2 col-form-label">
                        Requisito
        </asp:Label>
        <div class="col-md-9">
            <asp:TextBox ID="Requisito_VA" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="Auditor_VA" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="Label_Auditor_VA" runat="server" Text="Label" AssociatedControlID="Auditor_VA">
                        Auditor
            </asp:Label>
        </div>

    </div>
    <div class="form-group row">
        <div class="col-md-1">
            <asp:Button ID="Button_Eliminar_VA" runat="server" Text="Eliminar" />
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button_Guardar_VA" runat="server" Text="Guardar" />
        </div>
        <div class="col-md-1">
            <asp:Button ID="Button_Modificar_VA" runat="server" Text="Modificar" />
        </div>
    </div>
</asp:Content>

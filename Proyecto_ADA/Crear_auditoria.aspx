<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="Crear_auditoria.aspx.vb" Inherits="Proyecto_ADA.Crear_auditoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="form-group row">
            <asp:Label ID="Label_Empresa_CA" runat="server" Text="Label" AssociatedControlID="Empresa_CA" CssClass="col-md-1 col-form-label">
                        Empresa
            </asp:Label>
            <div class="col-md-4">
                <asp:TextBox ID="Empresa_CA" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Label ID="Label_NIT_CA" runat="server" Text="Label" AssociatedControlID="NIT_CA" CssClass="col-md-1 col-form-label">
                        NIT
            </asp:Label>
            <div class="col-md-4">
                <asp:TextBox ID="NIT_CA" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label_Sede_CA" runat="server" Text="Label" AssociatedControlID="Sede_CA" CssClass="col-md-1 col-form-label">
                        Sede
            </asp:Label>
            <div class="col-md-4">
                <asp:DropDownList ID="Sede_CA" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Value1" />
                    <asp:ListItem Text="Value2" />
                    <asp:ListItem Text="Value3" />
                    <asp:ListItem Text="Value4" />
                    <asp:ListItem Text="Value5" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-1">
                <asp:Button ID="Button_Guardar_CA" runat="server" Text="Guardar" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>

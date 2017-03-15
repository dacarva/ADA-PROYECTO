<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="Gestion_cambio.aspx.vb" Inherits="Proyecto_ADA.Gestion_cambio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">

        <div class="form-group row">
            <asp:Label ID="Label_Fecha_GC" runat="server" Text="Label" AssociatedControlID="Fecha_GC" CssClass="col-md-1 col-form-label">
                        Fecha
            </asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="Fecha_GC" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label_Descripcion_Cambio_GC" runat="server" Text="Label" AssociatedControlID="Descripcion_Cambio_GC" CssClass="col-md-1 col-form-label">
                        Descripción de cambio
            </asp:Label>
            <div class="col-md-2">
                <asp:TextBox ID="Descripcion_Cambio_GC" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label_Analisis_Riesgo_GC" runat="server" Text="Label" AssociatedControlID="Analisis_Riesgo_GC" CssClass="col-md-1 col-form-label">
                        Análisis de riesgo
            </asp:Label>
            <div class="col-md-2">
                <asp:DropDownList ID="Analisis_Riesgo_GC" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Value1" />
                    <asp:ListItem Text="Value2" />
                    <asp:ListItem Text="Value3" />
                    <asp:ListItem Text="Value4" />
                    <asp:ListItem Text="Value5" />
                </asp:DropDownList>
            </div>
            <div class="col-md-1"></div>
            <asp:Label ID="Label_Requisito_Legal_GC" runat="server" Text="Label" AssociatedControlID="Requisito_Legal_GC" CssClass="col-md-1 col-form-label">
                        Requisito legal
            </asp:Label>
            <div class="col-md-2">
                <asp:DropDownList ID="Requisito_Legal_GC" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Value1" />
                    <asp:ListItem Text="Value2" />
                    <asp:ListItem Text="Value3" />
                    <asp:ListItem Text="Value4" />
                    <asp:ListItem Text="Value5" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <label for="" class="col-md-3 col-form-label" runat="server">Recomendaciones / Acciones</label>

            <div class="col-md-3">
                <asp:Label ID="Label_Descripcion_GC" runat="server" Text="Label" AssociatedControlID="Descripcion_GC">
                        Descripción
                </asp:Label>
                <asp:TextBox ID="Descripcion_GC" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <asp:Label ID="Label_Fecha_Ejecucion_GC" runat="server" Text="Label" AssociatedControlID="Fecha_Ejecucion_GC">
                        Fecha de ejecución
                </asp:Label>
                <asp:TextBox ID="Fecha_Ejecucion_GC" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
            <div class="col-md-2">
                <asp:Label ID="Label_Fecha_Seguimiento_GC" runat="server" Text="Label" AssociatedControlID="Fecha_Seguimiento_GC">
                        Fecha de seguimiento
                </asp:Label>
                <asp:TextBox ID="Fecha_Seguimiento_GC" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>


        </div>
        <div class="form-group row">
            <asp:Label ID="Label_Comunicar_Cambio_GC" runat="server" Text="Label" AssociatedControlID="Comunicar_Cambio_GC" CssClass="col-md-2 col-form-label">
                        Comunicar el cambio a:
            </asp:Label>
            <div class="col-md-3">
                <asp:DropDownList ID="Comunicar_Cambio_GC" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Value1" />
                    <asp:ListItem Text="Value2" />
                    <asp:ListItem Text="Value3" />
                    <asp:ListItem Text="Value4" />
                    <asp:ListItem Text="Value5" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-10"></div>
            <div class="col-md-2">
                <asp:Button ID="Button_Guardar_GC" runat="server" Text="Guardar" CssClass="btn btn-default"/>
            </div>
        </div>
    </div>

</asp:Content>

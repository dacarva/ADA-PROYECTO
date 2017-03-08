<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="EPP_form.aspx.vb" Inherits="Proyecto_ADA.EPP_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <div class="container-fluid">
            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label ID="Label_Nombre_EPP" runat="server" Text="Label" AssociatedControlID="Nombre_EPP" >Nombre del EPP</asp:Label>
                    <br />
                    <asp:TextBox ID="Nombre_EPP" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-4">
                    <asp:Label ID="Label_Parte_Cuerpo" runat="server" Text="Label" AssociatedControlID="Parte_Cuerpo">Parte del cuerpo a proteger</asp:Label>
                    <br />
                    <asp:TextBox ID="Parte_Cuerpo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <asp:Image ID="Image1" runat="server" ImageUrl="https://blog.cdmon.com/wp-content/uploads/2015/12/1433239824.jpg" CssClass="img-responsive img-thumbnail" />
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-7">
                    <asp:Label ID="Label_Riesgo_Controlado" runat="server" Text="Label" AssociatedControlID="Riesgo_Controlado" >Nombre del EPP</asp:Label>
                    <br />
                    <asp:TextBox ID="Riesgo_Controlado" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="col-md-5">
                    <div class="from-group">
                        <asp:Label ID="Label_DD_Cargo_Asociado" runat="server" Text="Label" AssociatedControlID="DD_Cargo_Asociado">Cargo asociado</asp:Label>
                        <br />
                        <asp:DropDownList ID="DD_Cargo_Asociado" runat="server" CssClass="form-control"></asp:DropDownList>
                            <asp:ListItem Text="Default text" Value="Default value"/>
                        <%--Revisar esto--%>
                        <br />
                        <asp:Label ID="Label_Numero_Trabajadores_A_Cargo" runat="server" Text="Label" AssociatedControlID="Numero_Trabajadores_A_Cargo">Número de trabajadores a cargo</asp:Label>
                        <asp:TextBox ID="Numero_Trabajadores_A_Cargo" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                </div>
            </div>    






        </div>
    </body>

</asp:Content>

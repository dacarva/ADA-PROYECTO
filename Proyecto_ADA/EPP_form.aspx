<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/master.Master" CodeBehind="EPP_form.aspx.vb" Inherits="Proyecto_ADA.EPP_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="form-group col-md-3">
                    <asp:Label ID="Label_Nombre_EPP" runat="server" Text="Label" AssociatedControlID="Nombre_EPP">Nombre del EPP</asp:Label>
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
                    <asp:Label ID="Label_Riesgo_Controlado" runat="server" Text="Label" AssociatedControlID="Riesgo_Controlado">Nombre del EPP</asp:Label>
                    <br />
                    <asp:TextBox ID="Riesgo_Controlado" runat="server" CssClass="form-control fixed-text-area" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="col-md-5">
                    <div class="from-group">
                        <asp:Label ID="Label_DD_Cargo_Asociado" runat="server" Text="Label" AssociatedControlID="DD_Cargo_Asociado">Cargo asociado</asp:Label>
                        <br />
                        <asp:DropDownList ID="DD_Cargo_Asociado" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Value1" />
                            <asp:ListItem Text="Value2" />
                            <asp:ListItem Text="Value3" />
                            <asp:ListItem Text="Value4" />
                            <asp:ListItem Text="Value5" />
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label_Numero_Trabajadores_A_Cargo" runat="server" Text="Label" AssociatedControlID="Numero_Trabajadores_A_Cargo">
                            Número de trabajadores a cargo
                        </asp:Label>
                        <br />
                        <div class="col-md-2 to-remove-left-margin">
                            <asp:TextBox ID="Numero_Trabajadores_A_Cargo" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-12">
                    <asp:Label ID="Label_Especificacion_Tecnica" runat="server" Text="Label" AssociatedControlID="Especificacion_Tecnica">
                        Especificación Técnica
                    </asp:Label>
                    <br />
                    <asp:TextBox ID="Especificacion_Tecnica" runat="server" CssClass="form-control fixed-text-area" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-12">
                    <asp:Label ID="Label_Uso" runat="server" Text="Label" AssociatedControlID="Uso">
                        Uso
                    </asp:Label>
                    <br />
                    <asp:TextBox ID="Uso" runat="server" CssClass="form-control fixed-text-area" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-12">
                    <asp:Label ID="Label_Mantenimiento" runat="server" Text="Label" AssociatedControlID="Mantenimiento">
                        Mantenimiento
                    </asp:Label>
                    <br />
                    <asp:TextBox ID="Mantenimiento" runat="server" CssClass="form-control fixed-text-area" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-4">
                    <asp:Label ID="Label_Vida_Util" runat="server" Text="Label" AssociatedControlID="Vida_Util">
                        Vida útil   
                    </asp:Label>
                    <br />
                    <asp:TextBox ID="Vida_Util" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4"></div>
                <div class="form-group col-md-4">
                    <asp:Label ID="Label_Reposicion" runat="server" Text="Label" AssociatedControlID="Reposicion">
                        Reposición
                    </asp:Label>
                    <br />
                    <asp:TextBox ID="Reposicion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-12">
                    <asp:Label ID="Label_Disposicion_Final" runat="server" Text="Label" AssociatedControlID="Disposicion_Final">
                        Disposición Final
                    </asp:Label>
                    <br />
                    <asp:TextBox ID="Disposicion_Final" runat="server" CssClass="form-control fixed-text-area" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="row form-group">
                <asp:Label ID="Label_Ficha_Tecnica_Upload" runat="server" Text="Label" AssociatedControlID="Label_Ficha_Tecnica_Upload" CssClass="col-md-2 col-form-label">
                    Ficha técnica
                </asp:Label>
                <div class="col-md-2">
                    <asp:FileUpload runat="server" ID="FileUploadControl" />
                </div>
            </div>
            <h1>Falta el resto de los botones por definir</h1>

        </div>
    

</asp:Content>

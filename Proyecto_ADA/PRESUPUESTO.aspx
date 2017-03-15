<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PRESUPUESTO.aspx.vb" Inherits="Proyecto_ADA.PRESUPUESTO" MasterPageFile="master.master" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="css/presupuestos.css? <?php echo date('Y-m-d H:i:s'); ?>"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel ID="Panel1" runat="server">

        <div>
            Rubro
            <asp:TextBox ID="TextBox16" runat="server">20000000</asp:TextBox>
            año
            <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            sede
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="false"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="GENERAR PRESUPUESTO" />
        </div>


    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" Enabled="true" Visible="false">
        <div>
            <asp:Button ID="Button7" runat="server" Text="Nueva Actividad" />
        </div>
        <asp:Panel ID="Panel3" runat="server" Visible="false">
            Añadir a Nueva categoria<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            Categoria
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true"></asp:DropDownList>
            Actividad<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>

            <asp:Button ID="Button2" runat="server" Text="Agregar Actividad" />
            <asp:Button ID="Button5" runat="server" Text="Cancelar" />


        </asp:Panel>
       




        <br />

        <div>
            <asp:GridView ID="GridView1" runat="server" CssClass="mGrid" AutoGenerateColumns="False" BorderStyle="Solid" BorderWidth="0px" EditRowStyle-CssClass="editrowcss" OnRowDeleting="OnRowDeleting">
                <Columns>

                    <asp:BoundField DataField="CLASE" HeaderText="CLASE" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="ACTIVIDAD" HeaderText="ACTIVIDAD" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="ENERO" HeaderText="ENERO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="FEBRERO" HeaderText="FEBRERO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="MARZO" HeaderText="MARZO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="ABRIL" HeaderText="ABRIL" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="MAYO" HeaderText="MAYO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css" />
                    <asp:BoundField DataField="JUNIO" HeaderText="JUNIO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="JULIO" HeaderText="JULIO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="AGOSTO" HeaderText="AGOSTO" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="SEPTIEMBRE" HeaderText="SEPTIEMBRE" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="OCTUBRE" HeaderText="OCTUBRE" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="NOVIEMBRE" HeaderText="NOVIEMBRE" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="DICIEMBRE" HeaderText="DICIEMBRE" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:BoundField DataField="TOTAL ACTIVIDAD" HeaderText="TOTAL ACTIVIDAD" ItemStyle-HorizontalAlign="Center" ControlStyle-CssClass="bound_css"/>
                    <asp:CommandField ButtonType="Image" ShowEditButton="True" CausesValidation="False" ShowSelectButton="True" ShowDeleteButton="True" DeleteImageUrl="~/imagenes/delete.png" DeleteText="Borrar" EditImageUrl="~/imagenes/edit.png" EditText="Editar" SelectImageUrl="~/imagenes/select.png" SelectText="Seleccionar">
                        <ControlStyle Width="20px"></ControlStyle>
                    </asp:CommandField>
                    
                </Columns>
                <Columns>
                </Columns>


            </asp:GridView>
        </div>
        <asp:Panel ID="Panel4" runat="server" Visible="false">
           <div>Nombre de la actividad seleccionada
            <asp:TextBox ID="TextBox4" runat="server" Enabled="false"></asp:TextBox></div>
            <div>Añadir a Nueva categoria<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            Categoria
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:Button ID="Button9" runat="server" Text="Modificar Categoria"  />
            <asp:Button ID="Button10" runat="server" Text="Cancelar"  /></div>
            

        </asp:Panel>
        
         <div>
            <asp:Button ID="Button4" runat="server" Text="Agrupar" /><asp:Button ID="Button3" runat="server" Text="Guardar" /><asp:Button ID="Button8" runat="server" Text="Cancelar" />
        </div>



    </asp:Panel>






</asp:Content>
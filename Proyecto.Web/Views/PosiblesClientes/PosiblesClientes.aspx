<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">

    <h1 class="text-center mt-3">Posibles Clientes</h1>
    <hr class="mb-3" />

    <div class="form-group" style="display:none"> 
        <div class="form-row">
            <div class="col-md-3">
                <asp:Label ID="lblOpcion" runat="server"></asp:Label>                
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="form-row">
            <div class="col-md-3">
                <asp:Label ID="lblIdentificacion" runat="server" Text="Identificación"></asp:Label>
                <asp:TextBox ID="txtIdentificacion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblEmpresa" runat="server" Text="Empresa"></asp:Label>
                <asp:TextBox ID="txtEmpresa" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblPrimerNombre" runat="server" Text="Primer Nombre"></asp:Label>
                <asp:TextBox ID="txtPrimerNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblSegundoNombre" runat="server" Text="Segundo Nombre"></asp:Label>
                <asp:TextBox ID="txtSegundoNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="form-row mt-3">
            <div class="col-md-3">
                <asp:Label ID="lblPrimerApellido" runat="server" Text="Primer Apellido"></asp:Label>
                <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblSegundoApellido" runat="server" Text="Segundo Apellido"></asp:Label>
                <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="txtDirecion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="form-row mt-3">
            <div class="col-md-12">
                <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="form-row mt-3">
            <div class="col-md-12">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="form-row mt-3">
            <div class="col-md-12">
                <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            </div>
        </div>
    </div>

    <div class="form-group">
        <div class="form-row mt-3">
            <div class="col-md-12" style="overflow: auto">
                <asp:GridView ID="gvwDatos" runat="server"
                    Width="100%"
                    AutoGenerateColumns="False"
                    EmptyDataText="No se encontraron registros" 
                    BackColor="#EEEEEE"
                    BorderColor="#999999" 
                    BorderStyle="None" 
                    BorderWidth="1px" 
                    CellPadding="3" 
                    GridLines="Vertical" 
                    OnRowCommand="gvwDatos_RowCommand">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <%-- REPRESENTACION DE DATOS EN CONTROLES WEB --%>
                        <asp:TemplateField HeaderText="Identificación">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("clieIdentificacion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <%-- REPRESENTACION DE DATOS EN CELDAS --%>
                        <asp:BoundField HeaderText="Empresa" DataField="clieEmpresa" />
                        <asp:BoundField HeaderText="Primer Nombre" DataField="cliePrimerNombre" />
                        <asp:BoundField HeaderText="Segundo Nombre" DataField="clieSegundoNombre" />
                        <asp:BoundField HeaderText="Primer Apellido" DataField="cliePrimerApellido" />
                        <asp:BoundField HeaderText="Segundo Apellido" DataField="clieSegundoApellido" />
                        <asp:BoundField HeaderText="Direccion" DataField="clieDireccion" />
                        <asp:BoundField HeaderText="Telefono" DataField="clieTelefono" />
                        <asp:BoundField HeaderText="Correo" DataField="clieCorreo" />
                        <%-- EDITAR --%>
                        <asp:TemplateField HeaderText="Editar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ibEditar" runat="server" ImageUrl="~/Resources/Images/icon_edit.png" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Height="25px" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <%-- ELIMINAR --%>
                        <asp:TemplateField HeaderText="Eliminar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Resources/Images/icon_delete.png" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Height="25px" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Template/Template.Master" AutoEventWireup="true" CodeBehind="PoriblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PoriblesClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">

    <h1 class="text-center">Posibles Clientes</h1>
    <hr />

    <div class="form-group">
        <div class="form-row mt-3">
            <div class="col-md-12">
                <asp:Label ID="lblSubtitulo" runat="server" Text="Posibles Clientes"></asp:Label>
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
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
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
            <div class="col-md-12">
            </div>
        </div>
    </div>
</asp:Content>

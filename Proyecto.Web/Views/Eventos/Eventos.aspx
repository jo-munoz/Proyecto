<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="Proyecto.Web.Views.Eventos.Eventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">

    <h1 class="text-center mt-3">Eventos</h1>
    <hr class="mb-3" />

    <div class="card mx-auto mb-3">
        <div class="card-header">Crear Tareas</div>
        <div class="card-body">
            <div class="form-group">
                <div class="form-row">
                    <h4 class="text-center mt-3">Retornando datos desde Ws en formato Json</h4>
                </div>
            </div>
            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-12" style="overflow: auto">
                        <asp:GridView ID="gvwDatosJson"
                            runat="server"
                            EmptyDataText="No se encontraron registros"
                            Width="100%"
                            AutoGenerateColumns="False"
                            BackColor="White"
                            BorderColor="#999999"
                            BorderStyle="None"
                            BorderWidth="1px"
                            CellPadding="3"
                            GridLines="Vertical">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblCodigo" runat="server" Text='<%# Bind("CODIGO") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Nombre" DataField="NOMBRE" />
                                <asp:BoundField HeaderText="Ubicación" DataField="UBICACION" />
                                <asp:BoundField HeaderText="Participantes" DataField="PARTICIPANTES" />
                                <asp:BoundField HeaderText="Todo el Dia" DataField="TODO_DIA" />
                                <asp:BoundField HeaderText="Fecha" DataField="FECHA" />
                                <asp:BoundField HeaderText="Relacionado con Codigo" DataField="RELACIONADO_CON.CODIGO" />
                                <asp:BoundField HeaderText="Relacionado con Descripción" DataField="RELACIONADO_CON.DESCRIPCION" />
                                <asp:BoundField HeaderText="Descripción" DataField="DESCRIPCION" />
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

            <div class="form-group">
                <div class="form-row">
                    <h4 class="text-center mt-3">Retornando datos desde Ws en formato XML</h4>
                </div>
            </div>
            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-12" style="overflow: auto">
                        <asp:GridView ID="gvwDatosXML"
                            runat="server"
                            EmptyDataText="No se encontraron registros"
                            Width="100%"
                            AutoGenerateColumns="False"
                            BackColor="White"
                            BorderColor="#999999"
                            BorderStyle="None"
                            BorderWidth="1px"
                            CellPadding="3"
                            GridLines="Vertical">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblCodigo" runat="server" Text='<%# Bind("CODIGO") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Nombre" DataField="NOMBRE" />
                                <asp:BoundField HeaderText="Ubicación" DataField="UBICACION" />
                                <asp:BoundField HeaderText="Participantes" DataField="PARTICIPANTES" />
                                <asp:BoundField HeaderText="Todo el Dia" DataField="TODO_DIA" />
                                <asp:BoundField HeaderText="Fecha" DataField="FECHA" />
                                <asp:BoundField HeaderText="Relacionado con Codigo" DataField="RELACIONADO_CON.CODIGO" />
                                <asp:BoundField HeaderText="Relacionado con Descripción" DataField="RELACIONADO_CON.DESCRIPCION" />
                                <asp:BoundField HeaderText="Descripción" DataField="DESCRIPCION" />
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

        </div>
    </div>
</asp:Content>

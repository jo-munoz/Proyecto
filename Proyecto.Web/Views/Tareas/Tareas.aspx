<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="Proyecto.Web.Views.Tareas.Tareas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <h1 class="text-center mt-3">Información sobre la Tarea</h1>
    <hr class="mb-3" />

    <div class="card mx-auto mb-3">
        <div class="card-header">Crear Tareas</div>
        <div class="card-body">

            <div class="form-group" style="display: none">
                <div class="form-row">
                    <div class="col-md-3">
                        <asp:Label ID="lblOpcion" runat="server"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-4">
                        <asp:Label ID="lblCodigo" runat="server" Text="Codigo de la tarea"></asp:Label>
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtCodigo" runat="server"
                            TargetControlID="txtCodigo"
                            WatermarkText="Codigo Tarea" />
                    </div>
                    <div class="col-md-4">
                        <asp:Label ID="lblTitularTarea" runat="server" Text="Titular de la tarea"></asp:Label>
                        <asp:TextBox ID="txtTitularTarea" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtTitularTarea" runat="server"
                            TargetControlID="txtTitularTarea"
                            WatermarkText="Titular Tarea" />
                    </div>
                    <div class="col-md-4">
                        <asp:Label ID="lblAsunto" runat="server" Text="Asunto"></asp:Label>
                        <asp:TextBox ID="txtAsunto" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtAsunto" runat="server"
                            TargetControlID="txtAsunto"
                            WatermarkText="Asunto" />
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-6">
                        <asp:Label ID="lblFechaVencimiento" runat="server" Text="Fecha de vencimiento"></asp:Label>
                        <asp:TextBox ID="txtFechaVencimiento" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtFechaVencimiento" runat="server"
                            TargetControlID="txtFechaVencimiento"
                            WatermarkText="Fecha Vencimiento" />
                        <ajaxToolkit:CalendarExtender ID="ceFechaVencimiento" runat="server" TargetControlID="txtFechaVencimiento" Format="yyyy-MM-dd" />
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblContacto" runat="server" Text="Contacto"></asp:Label>
                        <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtContacto" runat="server"
                            TargetControlID="txtContacto"
                            WatermarkText="Contacto" />
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-6">
                        <asp:Label ID="lblCuenta" runat="server" Text="Cuenta"></asp:Label>
                        <asp:TextBox ID="txtCuenta" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtCuenta" runat="server"
                            TargetControlID="txtCuenta"
                            WatermarkText="Cuenta" />
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                        <asp:DropDownList ID="ddlEstadoTarea" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-6">
                        <asp:Label ID="lblPrioridad" runat="server" Text="Prioridad"></asp:Label>
                        <asp:DropDownList ID="ddlPrioridad" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblEnviarMensaje" runat="server" Text="Enviar Mensaje">
                            <asp:CheckBox ID="chkEnviarMensaje" runat="server" CssClass="form-control"></asp:CheckBox>
                        </asp:Label>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <div class="col-md-6">
                        <asp:Label ID="lblRepetir" runat="server" Text="Repetir">
                            <asp:CheckBox ID="chkRepetir" runat="server" CssClass="form-control"></asp:CheckBox>
                        </asp:Label>
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtDescripcion" runat="server"
                            TargetControlID="txtDescripcion"
                            WatermarkText="Descripción" />
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
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inCodigo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%-- REPRESENTACION DE DATOS EN CELDAS --%>
                                <asp:BoundField HeaderText="Titular" DataField="stTitular" />
                                <asp:BoundField HeaderText="Asunto" DataField="stAsunto" />
                                <asp:BoundField HeaderText="Fecha Vencimiento" DataField="stFechaVencimiento" />
                                <asp:BoundField HeaderText="Contacto" DataField="stContacto" />
                                <asp:BoundField HeaderText="Cuenta" DataField="stCuenta" />
                                <asp:BoundField HeaderText="Estado" DataField="obclsEstadoTareas.stDescripcion" />
                                <asp:BoundField HeaderText="Prioridad" DataField="obclsPrioridad.stDescripcion" />
                                <asp:BoundField HeaderText="Enviar Mensaje" DataField="stEnviarMensaje" />
                                <asp:BoundField HeaderText="Repetir" DataField="stRepetir" />
                                <asp:BoundField HeaderText="Descripcion" DataField="stDescripcion" />
                                <asp:TemplateField Visible="false">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblCodigoEstadoTarea" Text='<%# Bind("obclsEstadoTareas.inCodigo") %>'></asp:Label>
                                        <asp:Label runat="server" ID="lblCodigoPrioridad" Text='<%# Bind("obclsPrioridad.inCodigo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%-- EDITAR --%>
                                <asp:TemplateField HeaderText="Modifica">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ibModificar" runat="server" ImageUrl="~/Resources/Images/icon_edit.png" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Height="25px" />
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
        </div>
    </div>

</asp:Content>

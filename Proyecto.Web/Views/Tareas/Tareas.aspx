<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Template/Template.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="Proyecto.Web.Views.Tareas.Tareas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <h1 class="text-center">Información sobre la Tarea</h1>
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
                    <div class="col-md-6">
                        <asp:Label ID="lblTitularTarea" runat="server" Text="Titular de la tarea"></asp:Label>
                        <asp:TextBox ID="txtTitularTarea" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="twmtTitularTarea" runat="server"
                            TargetControlID="txtTitularTarea"
                            WatermarkText="Titular Tarea" />
                    </div>
                    <div class="col-md-6">
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
        </div>
    </div>

</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="Proyecto.Web.Views.CrearCuenta.CrearCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Registrar Cuenta</title>

    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom fonts for this template-->
    <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet" />

    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js" type="text/javascript"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js" type="text/javascript"></script>

    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js" type="text/javascript"></script>

    <!-- bootstrap-sweetalert-->
    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
</head>
<body class="bg-dark">

    <div class="container">
        <div class="card card-register mx-auto mt-5">
            <div class="card-header">
                Crear una Cuenta
            </div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label ID="lblLogin" runat="server" Text="Email"></asp:Label>
                                <asp:TextBox ID="txtLogin" runat="server" TextMode="Email" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ErrorMessage="campo requerido" ForeColor="Red" ControlToValidate="txtLogin" ValidationGroup="crearCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="campo requerido" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="crearCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label ID="lblConfirmarPassword" runat="server" Text="Confirmar Password"></asp:Label>
                                <asp:TextBox ID="txtConfirmarPassword" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvConfirmarPassword" runat="server" ErrorMessage="campo requerido" ForeColor="Red" ControlToValidate="txtConfirmarPassword" ValidationGroup="crearCuenta"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="cvConfirmarPassword" runat="server" ErrorMessage="password no son iguales" ControlToValidate="txtConfirmarPassword" ControlToCompare="txtPassword" ForeColor="Red"></asp:CompareValidator>
                            </div>
                        </div>                        
                    </div>

                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label ID="lblImagen" runat="server" Text="Subir Imagen"></asp:Label>                                
                            </div>
                            <div class="col-md-12">
                                <asp:FileUpload ID="fulImagen" runat="server" class="form-control"></asp:FileUpload>
                            </div>                            
                            <div class="col-md-12">
                                <asp:RequiredFieldValidator ID="rfvImagen" runat="server" ErrorMessage="campo requerido" ForeColor="Red" ControlToValidate="fulImagen" ValidationGroup="crearCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>

                    <asp:Button ID="btnCrear" runat="server" class="btn btn-primary btn-block" Text="Crear Cuenta" ValidationGroup="crearCuenta" OnClick="btnCrear_Click" />

                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Login/Login.aspx">Iniciar Sesión</a>
                </div>
            </div>
        </div>
    </div>

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Proyecto.Web.Views.Registrar.Registrar" %>

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
</head>
<body class="bg-dark">
    <div class="container">
        <div class="card card-register mx-auto mt-5">
            <div class="card-header">Registrar una Cuenta</div>
            <div class="card-body">
                <form runat="server">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">                                
                                <asp:Label ID="lblPrimerNombre" runat="server" Text="Primer Nombre"></asp:Label>                                
                                <asp:TextBox ID="txtPrimerNombre" runat="server" class="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6">                                
                                <asp:Label ID="lblSegundoNombre" runat="server" Text="Segundo Nombre"></asp:Label>
                                <asp:TextBox ID="txtSegundoNombre" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">                        
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">                                
                                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="col-md-6">                                
                                <asp:Label ID="lblConfirmePassword" runat="server" Text="Confirme Password"></asp:Label>
                                <asp:TextBox ID="txtConfirmePassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>                    
                    <asp:Button ID="btnLogin" runat="server" class="btn btn-primary btn-block" Text="Registrar" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Login/Login.aspx">Iniciar Sesión</a>
                    <a class="d-block small" href="forgot-password.html">Olvido Password?</a>
                </div>
            </div>
        </div>
    </div>
</body>
</html>

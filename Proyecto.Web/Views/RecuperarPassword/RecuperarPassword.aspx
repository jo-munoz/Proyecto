<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarPassword.aspx.cs" Inherits="Proyecto.Web.Views.RecuperarPassword.RecuperarPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Olvido Password</title>

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
            <div class="card-header">Recuperar una Cuenta</div>
            <div class="card-body">
                <form runat="server">

                    <div class="text-center mt-4 mb-5">
                        <h4>Olvido Password?</h4>
                        <p>
                            Ingrese su dirección de correo electronico y nosotros enviaremos las instrucciones para 
                        la recuperacio de su password.
                        </p>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                    </div>

                    <div class="text-center">
                        <asp:Button ID="btnAceptar" runat="server" class="btn btn-primary" Text="Recuperar Password"></asp:Button>
                    </div>

                    <div class="text-center">
                        <a class="d-block small mt-3" href="../Login/Login.aspx">Iniciar Sesión</a>
                    </div>
                </form>
            </div>
        </div>
    </div>

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Registro_Tarea.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Acá damos estilo al registro -->
     <style>
        .Contenedor {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .Registro {
            width: 380px; 
            padding: 40px; 
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        .form-group {
            margin-bottom: 20px; 
        }
    </style>
</head>
<body>
    <div class="Contenedor">
        <div class="Registro">
            <div class="card-body">
                <div class="form-group">
                    <div class="form-floating mb-3">
                        <input runat="server" type="email" class="form-control" id="txtEmail" placeholder="name@example.com" />
                        <label for="txtEmail">Email address</label>
                    </div>
                    <div class="form-floating">
                        <input runat="server" type="password" class="form-control" id="txtPwd" placeholder="Password" />
                        <label for="txtPwd">Password</label>
                    </div>
                    <hr />
                    <div class="row">
                        <button runat="server" id="btnRegistro" class="btn btn-primary" onserverclick="btnRegistro_ServerClick">Registro</button>
                    </div>
                </div>
            </div>
            <div id="divLogout" runat="server" class="card-body" hidden="hidden">
                <button runat="server" id="btnLogout" class="btn btn-primary" onserverclick="btnLogout_ServerClick">Logout</button>
            </div>
        </div>
    </div>
</body>
</html>
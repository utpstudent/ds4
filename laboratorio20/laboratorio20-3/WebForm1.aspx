<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="laboratorio20_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRUD Laptops - Web Forms</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        .container {
            max-width: 800px;
            margin-top: 20px;
        }
        .toolbar {
            margin-bottom: 20px;
            padding: 15px;
            background-color: #f8f9fa;
            border-radius: 5px;
        }
        .form-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }
        .search-container {
            background-color: #e9ecef;
            padding: 15px;
            border-radius: 5px;
            margin-bottom: 20px;
        }
        .btn-icon {
            width: 32px;
            height: 32px;
            margin-right: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="text-center mb-4">Gestion de Inventario de Tienda de Tecnologia</h2>
            
            
            <asp:Label ID="lblMensaje" runat="server" Visible="false" CssClass="alert d-block" />
            
            
            <div class="search-container">
                <div class="row align-items-center">
                    <div class="col-md-6">
                        <label class="form-label">Buscar por ID:</label>
                        <div class="input-group">
                            <asp:TextBox ID="txtBuscarId" runat="server" CssClass="form-control" TextMode="Number" placeholder="ID del producto" />
                            <asp:Button ID="btnBuscar" runat="server" Text="🔍" CssClass="btn btn-outline-secondary" OnClick="btnBuscar_Click" />
                        </div>
                    </div>
                </div>
            </div>

            
            <div class="toolbar">
                <div class="btn-group" role="group">
                    <asp:Button ID="btnNuevo" runat="server" Text="➕ Nuevo" CssClass="btn btn-primary" OnClick="btnNuevo_Click" />
                    <asp:Button ID="btnGuardar" runat="server" Text="💾 Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="❌ Cancelar" CssClass="btn btn-warning" OnClick="btnCancelar_Click" />
                    <asp:Button ID="btnEliminar" runat="server" Text="🗑️ Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                    <asp:Button ID="btnSalir" runat="server" Text="🚪 Salir" CssClass="btn btn-secondary" OnClick="btnSalir_Click" />
                </div>
            </div>

            
            <div class="form-container">
                <div class="row">
                    <div class="col-md-6">
                        <div class="mb-3">
                            <label class="form-label">ID</label>
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="true" BackColor="#f8f9fa" />
                        </div>
                    </div>
                </div>
                
                <div class="row">
                    <div class="col-md-6">
                        <div class="mb-3">
                            <label class="form-label">Nombre</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre del producto" />
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <div class="mb-3">
                            <label class="form-label">Precio</label>
                            <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" TextMode="Number" step="0.01" placeholder="0.00" />
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="mb-3">
                            <label class="form-label">Stock</label>
                            <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" TextMode="Number" placeholder="0" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
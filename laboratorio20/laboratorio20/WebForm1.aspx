<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="laboratorio20.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicar</title>
    <style>
        .container {
            padding: 20px;
            font-family: Arial, sans-serif;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .error-message {
            color: red;
            font-weight: bold;
            margin: 10px 0;
            display: block;
        }
        .list-box {
            width: 300px;
            height: 400px;
            margin-top: 20px;
            font-family: Consolas, monospace;
        }
        .selection-info {
            color: blue;
            margin-top: 10px;
            font-style: italic;
            display: block;
        }
        input[type="text"], input[type="number"] {
            padding: 5px;
            width: 200px;
        }
        input[type="button"], input[type="submit"] {
            padding: 8px 15px;
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
        }
        input[type="button"]:hover, input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Generador de Tablas de Multiplicar</h2>
            
            <div class="form-group">
                <asp:Label ID="lblNumero" runat="server" Text="Ingrese un número entero:" />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="200px" 
                    placeholder="Ej: 5" TextMode="Number" />
            </div>
            
            <asp:Button ID="Button1" runat="server" Text="Generar Tabla" OnClick="Button1_Click" />
            
            <br />
            
            <asp:Label ID="lblError" runat="server" Visible="false" CssClass="error-message" />
            
            <div class="form-group">
                
                <asp:ListBox ID="ListBox1" runat="server" CssClass="list-box" 
                    OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" 
                    AutoPostBack="true" Visible="false" />
            </div>
            
            
            <asp:Label ID="lblSeleccion" runat="server" Visible="false" CssClass="selection-info" />
        </div>
    </form>
</body>
</html>
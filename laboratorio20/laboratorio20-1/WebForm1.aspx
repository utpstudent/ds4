<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="laboratorio20_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz Diagonal Inversa</title>
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
            width: 400px;
            height: 500px;
            margin-top: 20px;
            font-family: Consolas, monospace;
            font-size: 14px;
        }
        .matrix-title {
            font-weight: bold;
            color: #2c3e50;
        }
        input[type="text"], input[type="number"] {
            padding: 8px;
            width: 200px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        input[type="button"], input[type="submit"] {
            padding: 10px 20px;
            background-color: #3498db;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 14px;
        }
        input[type="button"]:hover, input[type="submit"]:hover {
            background-color: #2980b9;
        }
        .instructions {
            background-color: #f8f9fa;
            padding: 10px;
            border-left: 4px solid #3498db;
            margin-bottom: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Generador de Matriz Diagonal Inversa</h2>
            
            <div class="instructions">
                <strong>Instrucciones:</strong> Ingrese la dimensión N para generar una matriz N×N 
                donde la diagonal inversa es 1 y el resto de elementos son 0.
            </div>
            
            <div class="form-group">
                <asp:Label ID="lblDimension" runat="server" Text="Dimensión N de la matriz:" />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="200px" 
                    placeholder="Ej: 5" TextMode="Number" />
            </div>
            
            <asp:Button ID="Button1" runat="server" Text="Generar Matriz" OnClick="Button1_Click" />
            
            <br />
            <!-- Label para mostrar errores -->
            <asp:Label ID="lblError" runat="server" Visible="false" CssClass="error-message" />
            
            <div class="form-group">
                <!-- ListBox para mostrar la matriz -->
                <asp:ListBox ID="ListBox1" runat="server" CssClass="list-box" 
                    OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" 
                    AutoPostBack="true" Visible="false" />
            </div>
        </div>
    </form>
</body>
</html>

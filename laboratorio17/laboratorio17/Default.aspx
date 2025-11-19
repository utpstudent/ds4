<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="laboratorio17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        

        <div class="row">
         <div>
             <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
                 AllowSorting="True" AllowPaging="True"
                 DataKeyNames="ProductID"
                 AutoGenerateEditButton="True"
             Runat="server" />

             <asp:SqlDataSource ID="MyDataSource1" runat="server"
                 ConnectionString="data source=.\sqlexpress;initial catalog=northwind;persist security info=True;Integrated Security=SSPI;"
                 ProviderName="System.Data.SqlClient"
                 SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"
                 UpdateCommand="UPDATE Product Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductId]=@ProductId">
             </asp:SqlDataSource>
         </div>  
           
           
        </div>
  

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="interfaz.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row filaUno">
        <div class="caja">
            <h1>GESTOR POKEDEX</h1>


        </div>
    </div>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%
            foreach (dominio.Pokemon poke in ListadoPokemon)
            {
        %>

        <div class="col">
            <div class="card tarjetita">
                <img src="<%:poke.UrlImagen %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%:poke.Nombre %></h5>
                    <p class="card-text"><%:poke.Descripcion %></p>
                </div>
            </div>
        </div>
        <%}
        %>
    </div>
</asp:Content>

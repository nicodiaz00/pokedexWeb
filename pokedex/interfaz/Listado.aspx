<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="interfaz.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-10">
                <asp:GridView ID="dgvPokemon" runat="server" CssClass="table table-striped table-dark">

                </asp:GridView>
                <asp:Button  runat="server"  ID="btnAgregar" Text="Ingresar Pokemon" class="btn btn-outline-primary"/>
            </div>
        </div>
    </div>
</asp:Content>

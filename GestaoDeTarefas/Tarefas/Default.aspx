﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAcesso.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tarefas.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <title>Tarefas - Acesso</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCorpo" runat="server">
    
       <div class="pagination-centered formAcesso"> 
            <h3>Tarefas - Acesso Restrito</h3>

            <label>
                <asp:TextBox runat="server" ID="lbEmail" Text="" PlaceHolder="Informe seu Email"></asp:TextBox>
            </label>
            <label>
                <asp:TextBox runat="server" ID="lbSenha" Text="" TextMode="Password" PlaceHolder="Informe sua Senha"></asp:TextBox>
            </label>

            <asp:Button runat="server" ID="btAcessar" Text="Acessar" CssClass="btn btn-primary btn-success" />
        </div>
    
</asp:Content>

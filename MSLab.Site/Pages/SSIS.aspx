<%@ Page Title="SSIS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SSIS.aspx.cs" Inherits="MSLab.Site.Pages.SSIS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="SSIS est un projet qu'il est possible de créer sous Visual Studio."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Il permet de planifier une suite d'actions impliquant des requetes SQL, des procédures stockées et des logiciels sous forme de batch."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Les paramètres à configurer sont les paths (ou chemeins) où sont les batchs."></asp:Label>
    <br/>
    <asp:Label runat="server"  CssClass="LabSiteZoneConseil" Text="N.B : Il faut faire attention au path, car le ssis est déployer sur un serveur SQL. Donc les paths ne seront pas forcement les mêmes."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Les batchs font de la lecture et de l'écriture de données d'un point A à un point B"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Pour le publier, il y a deux solutions :"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="-Depuis Visual Studio"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="-Depuis le serveur qui heberge l'instance SQL, avec le aaaaaa manager"></asp:Label>
</asp:Content>
<%@ Page Title="SQL Server" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlServer.aspx.cs" Inherits="MSLab.Site.Pages.SqlServer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="SQL Serveur est l'application qui stocke des données sous formes de bases (puis de fichiers pour les sauvegarder)."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Il est également possible de créer :"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="-Des types de données fait maison"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="-Des procédures stockées"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="-Des packages SSIS"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Cette application est utilisé par beaucoup de Saas, d'ERP, de CRM et Sharepoint pour stocker et indexer un grand nombre de données et d'identifiants."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Tous les domaines d'entreprise ont au moins un SI avec un serveur SQL."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Un identifiant de connexion peut être lié à différentes bases avec des roles de sécurités différents."></asp:Label>

    <br/> <br/>
    <asp:Label runat="server" Text="Concernant les BDD, il est possible :"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="-d'effectuer des requetes sur une interface dédiée"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Les requetes sont des requetes SQL, qui est un langage à lui tout seul."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="N.B : Pour effectuer des requetes en C#, il faut utiliser un ADO ou Entity Framework."></asp:Label>

    <br/>
    <asp:Label runat="server" Text="-de créer les procédues liées à une base"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Les procédures sont formulées sous la forme de requetes filtrées ou de simple compteur d'elements"></asp:Label>

    <br/>
    <asp:Label runat="server" Text="-d'extraire le script de création de la BDD, avec ou sans les valeurs"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Pour en faire une sauvegarde, ou pour pouvoir la créer lors de la phase création d'une application"></asp:Label>
</asp:Content>
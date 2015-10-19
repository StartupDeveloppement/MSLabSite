<%@ Page Title="Console" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Console.aspx.cs" Inherits="MSLab.Site.Pages.Console" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="La console est la première étape avant les fenêtres graphiques."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Elle permet de réaliser des affichages et d'intéragir avec un utilisateur lors de programme basic."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Elle est utile lors de la réalisation de batch pour afficher l'état d'avancement."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Voici les lignes d'appels :"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Affichage : WriteLine(Hello, World);"></asp:Label>
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Guillemets à ajouter"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Demander une saisie : ReadLine();"></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Afin d'éviter des messages d'erreurs dit Exceptions, il est conseillé de tester la valeur saisie par l'utilisateur."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Au moyen d'une boucle, tant que la valeur saisie n'est pas du type ou du format ou taille attendu."></asp:Label>
    <br/>
    <asp:Label runat="server" Text="Les premiers affichages sont des énoncés ou des menus afin de dialoguer le plus possible avec l'utilisateur."></asp:Label>
</asp:Content>
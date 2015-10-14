<%@ Page Title="Visual Studio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VisualStudio.aspx.cs" Inherits="MSLab.Site.Pages.VisualStudio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="Visual Studio possède des numéros de version qu'il faut connaitre : <br />"></asp:Label>
    <asp:Label runat="server" Text="Visual Studio 2010 à la version 10<br />"></asp:Label>
    <asp:Label runat="server" Text="Visual Studio 2012 à la version 12<br />"></asp:Label>
    <asp:Label runat="server" Text="Visual Studio 2013 à la version 13<br />"></asp:Label>
    <asp:Label runat="server" Text="Visual Studio 2015 à la version 14<br />"></asp:Label>

    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="Lors de l'ouverture de Visual Studio, l'interface est composée en deux parties :<br />"></asp:Label>
    <asp:Label runat="server" Text="- Au sein de la partie centrale, la colonne de gauche permet de créer une solution ou d'ouvrir une des plus récentes et la partie droite concernent des élements de Microsoft<br />"></asp:Label>
    <asp:Label runat="server" Text="- La colonne de gauche permet de visualiser les répositorys Git disponibles<br />"></asp:Label>

    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="Lors de l'ouverture d'une solution, les dernier fichiers ouverts sont conservés.<br />"></asp:Label>
    <asp:Label runat="server" Text="Dans la baree à droite, il faut ce rendre dans l'onglet Team explorer, et cliquer sur la maison dans la barre de menu.<br />"></asp:Label>
    <asp:Label runat="server" Text="Il y a 4 fonctions puis une liste de solutions, voici leur action : .<br />"></asp:Label>
    <asp:Label runat="server" Text="Changes : Affiche la liste des fichiers modifiés qui sont près à etre commit sur la branche actuelle.<br />"></asp:Label>
    <asp:Label runat="server" Text="Branches : Affiche toutes les branches du repo local sur lesquelles il y est possible de les merger ou de les supprimer.<br />"></asp:Label>
    <asp:Label runat="server" Text="Sync : Permet de réaliser des actions de synchronisation entre la branche local et la branche distante.<br />"></asp:Label>
    <asp:Label runat="server" Text="Settings : Permet de parametrer les settings du répo local et celui de toute la session en cours .<br />"></asp:Label>

    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="Les extensions sont accessibles graçe au Menu Tools puis Extensions and Updates<br />"></asp:Label>
    <asp:Label runat="server" Text="Installed est la liste des extensions installés<br />"></asp:Label>
    <asp:Label runat="server" Text="Online est le catalogue des extensions disponibles<br />"></asp:Label>
    <asp:Label runat="server" Text="Updates affiche les extensions disposant d'une nouvelle version<br />"></asp:Label>
    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="Voici une liste conseillée :<br />"></asp:Label>
    <asp:Label runat="server" Text="- Indent Guides<br />"></asp:Label>
    <asp:Label runat="server" Text="- Visual SVN<br />"></asp:Label>
    <asp:Label runat="server" Text="- Regex tester<br />"></asp:Label>
    <asp:Label runat="server" Text="<br />"></asp:Label>
</asp:Content>
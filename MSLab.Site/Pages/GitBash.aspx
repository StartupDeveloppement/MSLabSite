<%@ Page Title="GitBash" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GitBash.aspx.cs" Inherits="MSLab.Site.Pages.GitBash" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="GitBash est un outil en ligne de commande qui remplace TortoiseGit, il ne faut JAMAIS utiliser les deux outils en parallèle.<br />"></asp:Label>
    <asp:Label runat="server" Text="Double clic dans le repo puis Git Bash :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/GitBash/GitBash_Use_1.PNG"/>
    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="Voici un guide d'utilisation de toutes les commandes :"></asp:Label>
    <asp:HyperLink ID="hyperlink1"
                   NavigateUrl="http://www.codeproject.com/Articles/457305/Basic-Git-Command-Line-Reference-for-Windows-Users"
                   Text="Article"
                   runat="server"/>
</asp:Content>

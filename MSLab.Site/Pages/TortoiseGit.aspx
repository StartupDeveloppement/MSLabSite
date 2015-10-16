<%@ Page Title="TortoiseGit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TortoiseGit.aspx.cs" Inherits="MSLab.Site.Pages.TortoiseGit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Installation"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Tortoise est une surcouche pour les icones windows basé sur le statut Git des fichiers"></asp:Label>
    <br />
    <asp:Label runat="server" Text="Afin d'utiliser Git, il faut installer l'outil pour y acceder :  " CssClass="LabSiteZoneConseil"></asp:Label>
    <asp:HyperLink ID="hyperlink1"
        NavigateUrl="https://tortoisegit.org"
        Text="https://tortoisegit.org"
        runat="server" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_1.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Faire next :"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_2.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Faire Install et Finish :"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_3.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Cloner un repository"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Cloner le repository est l'étape initiale qui permet d'instancier le lien avec le repository cible du serveur GitHub"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Les fonctions disponibles depuis le menu contextuel de windows (clic droit)"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Nous nous servirons ici presque uniquement de la fonction Git Clone"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Clone_1.png" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Faire Ok et vos identifiants GitHub vous serons demandés et le répertoire sera créé :"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Clone_2.png" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="<br /> NB : Si votre projet existe, il suffit de faire TortoiseGit puis Add et Git Commit puis Push"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="<br />"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Voici la liste de toutes les commandes et les actions : "></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Commands.png" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Push : Permet d'envoyer les commits sur GitHub"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Pull : Permet de rapatrier les denières modifications venant de GitHub"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Show log : Permet de lister tous les commits d'une branche"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Revert : Restore le fichier à sa valeur de commit"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Switch/Checkout : Permet de changer de branche, et d'obtenir une branche venant de GitBuh "></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Merge : Permet de fusionner deux branches en étant d'abord sur la branche cible"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="<br />"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Vous avez surement de nouvelles icones sur vos dossier concernant les repos, voici leurs significations :"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_State.png" />
</asp:Content>

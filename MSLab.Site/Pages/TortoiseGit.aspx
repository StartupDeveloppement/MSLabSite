<%@ Page Title="TortoiseGit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TortoiseGit.aspx.cs" Inherits="MSLab.Site.Pages.TortoiseGit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="<br />"></asp:Label>
    <asp:Label runat="server" Text="Afin d'utiliser Git, il faut installer l'outil pour y acceder : "></asp:Label>
    <asp:HyperLink ID="hyperlink1"
                   NavigateUrl="https://tortoisegit.org"
                   Text="https://tortoisegit.org"
                   runat="server"/>
<asp:Label runat="server" Text="<br /> Double clic sur le fichier téléchargé puis faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_1.PNG"/>
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_2.PNG"/>
    <asp:Label runat="server" Text="<br /> Faire Install et Finish :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_3.PNG"/>
    <asp:Label runat="server" Text="<br /><br /> Il faut ensuite ouvrir une fenetre explorer et de determiner un répertoire cible du répo GitHub.<br />"></asp:Label>
    <asp:Label runat="server" Text="Il ne faut pas créer un dossier correspondant au nom du projet, TortoiseGit va le faire pour vous.<br />"></asp:Label>
    <asp:Label runat="server" Text="Clic droit dans la fenêtre puis Git Clone :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Clone_1.png"/>
    <asp:Label runat="server" Text="<br />Faire Ok et vos identifiants GitHub vous serons demandés et le répertoire sera créé :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Clone_2.png"/>
    <asp:Label runat="server" Text="<br /> NB : Si votre projet existe, il suffit de faire TortoiseGit puis Add et Git Commit puis Push<br />"></asp:Label>

    <asp:Label runat="server" Text="<br /><br />"></asp:Label>
    <asp:Label runat="server" Text="Voici la liste de toutes les commandes et les actions : <br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Commands.png"/>
    <asp:Label runat="server" Text="<br />Pull : Permet de rapatrier les denières modifications venant de GitHub<br />"></asp:Label>
    <asp:Label runat="server" Text="Fetch : Permet de <br />"></asp:Label>
    <asp:Label runat="server" Text="Push : Permet d'envoyer les commits sur GitHub<br />"></asp:Label>
    <asp:Label runat="server" Text="Pull : Permet de rapatrier les denières modifications venant de GitHub<br />"></asp:Label>
    <asp:Label runat="server" Text="Show log : Permet de lister tous les commits d'une branche<br />"></asp:Label>
    <asp:Label runat="server" Text="Stash save : Permet de sauvegarder un état à un instant T et de pouvoir le reprendre si un collègue vient vous demander de l'aide et que vous faite le fix sur votre ordinateur<br />"></asp:Label>
    <asp:Label runat="server" Text="Resolve : Permet de résoudre les conflits suite à un pull<br />"></asp:Label>
    <asp:Label runat="server" Text="Revert : Permet de revenir en arriere<br />"></asp:Label>
    <asp:Label runat="server" Text="Clean up : Permet de nettoyer tous les répertoires bin et obj du répo<br />"></asp:Label>
    <asp:Label runat="server" Text="Switch/Checkout : Permet de changer de branche, et d'obtenir une branche venant de GitBuh <br />"></asp:Label>
    <asp:Label runat="server" Text="Merge : Permet de fusionner deux branches en étant d'abord sur la branche cible"></asp:Label>
    
    <asp:Label runat="server" Text="<br /><br />"></asp:Label>
    <asp:Label runat="server" Text="Vous avez surement de nouvelles icones sur vos dossier concernant les repos, voici leurs significations :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_State.png"/>
</asp:Content>

<%@ Page Title="Visual Studio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VisualStudio.aspx.cs" Inherits="MSLab.Site.Pages.VisualStudio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Téléchargement & Installation"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Visual Studio est disponible en téléchargement depuis la plateforme DreamSpark."></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Connectez vous sur votre espace extranet Ynov :"></asp:Label>
    <asp:HyperLink runat="server" Text="http://extranet.ynov.com/" NavigateUrl="http://extranet.ynov.com/"></asp:HyperLink>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Entrez sur le portail des offres Microsoft puis sur le programme DreamSpark"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Trouvez Visual Studio 2015 Enterprise, choisissez la langue d'installation et ajoutez à votre panier :"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/VisualStudio/VisualStudio_0.png" Width="500" Height="200" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Poursuivez la commande jusqu'a téléchargement d'un Iso contenant VS :"></asp:Label>
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/VisualStudio/VisualStudio_1.png" Width="500" Height="200" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Une fois téléchargé, vous pouvez monter l'Iso avec le logiciel Clone Drive et installer le contenu."></asp:Label>
    <asp:HyperLink runat="server">http://www.slysoft.com/fr/virtual-clonedrive.html</asp:HyperLink>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Visual Studio 2012 à la version 11"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Visual Studio 2013 à la version 12"></asp:Label>
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Visual Studio 2015 à la version 14"></asp:Label>

    <br />
    <br />
    <asp:Label runat="server" Text="Lors de l'ouverture de Visual Studio, l'interface est composée en deux parties :"></asp:Label>
    <br />
    <asp:Label runat="server" Text="- Au sein de la partie centrale, la colonne de gauche permet de créer une solution ou d'ouvrir une des plus récentes et la partie droite concernent des élements de Microsoft"></asp:Label>
    <br />
    <asp:Label runat="server" Text="- La colonne de gauche permet de visualiser les répositorys Git disponibles"></asp:Label>

    <br />
    <asp:Label runat="server" Text="Lors de l'ouverture d'une solution, les dernier fichiers ouverts sont conservés."></asp:Label>
    <br />
    <asp:Label runat="server" Text="Dans la baree à droite, il faut ce rendre dans l'onglet Team explorer, et cliquer sur la maison dans la barre de menu."></asp:Label>
    <br />
    <asp:Label runat="server" Text="Il y a 4 fonctions puis une liste de solutions, voici leur action : ."></asp:Label>
    <br />
    <asp:Label runat="server" Text="Changes : Affiche la liste des fichiers modifiés qui sont près à etre commit sur la branche actuelle."></asp:Label>
    <br />
    <asp:Label runat="server" Text="Branches : Affiche toutes les branches du repo local sur lesquelles il y est possible de les merger ou de les supprimer."></asp:Label>
    <br />
    <asp:Label runat="server" Text="Sync : Permet de réaliser des actions de synchronisation entre la branche local et la branche distante."></asp:Label>
    <br />
    <asp:Label runat="server" Text="Settings : Permet de parametrer les settings du répo local et celui de toute la session en cours ."></asp:Label>

    <br />
    <asp:Label runat="server" Text="Extensions" CssClass="LabSitePageTitle2" />
        <br />
    <asp:Label runat="server" Text="Les extensions sont accessibles graçe au Menu Tools puis Extensions and Updates"></asp:Label>
    <br />
    <asp:Label runat="server" Text="Installed est la liste des extensions installés"></asp:Label>
    <br />
    <asp:Label runat="server" Text="Online est le catalogue des extensions disponibles"></asp:Label>
    <br />
    <asp:Label runat="server" Text="Updates affiche les extensions disposant d'une nouvelle version"></asp:Label>
    <br />
    <asp:Label runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Voici une liste conseillée :"></asp:Label>
    <br />
    <asp:Label runat="server" Text="- Indent Guides"></asp:Label>
    <br />
    <asp:Label runat="server" Text="- Visual SVN"></asp:Label>
    <br />
    <asp:Label runat="server" Text="- Regex tester"></asp:Label>
    <br />
    <asp:Label runat="server" Text="- Highlight"></asp:Label>
    <br />
    <asp:Label runat="server" Text=""></asp:Label>
</asp:Content>

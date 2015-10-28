<%@ Page Title="TortoiseGit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TortoiseGit.aspx.cs" Inherits="MSLab.Site.Pages.TortoiseGit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Installation" ID="TitleInstallation" />
    <asp:Panel runat="server" ID="ContentInstallation">
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Tortoise permet d'avoir une surcouche des icones windows basé sur le statut Git des fichiers ainsi que des options dans le menu contextuel (clic droit)"></asp:Label>
        <br />
        <asp:Label runat="server" Text="Afin d'utiliser Git, il faut installer l'outil pour y acceder :  " CssClass="LabSiteZoneConseil"></asp:Label>
        <asp:HyperLink ID="hyperlink1"
            NavigateUrl="https://tortoisegit.org"
            Text="https://tortoisegit.org"
            runat="server" />
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_1.PNG" />
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text=" Faire next :"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_2.PNG" />
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Faire Install et Finish :"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Install_3.PNG" />
        <br />
    </asp:Panel>
    <ajaxToolkit:CollapsiblePanelExtender runat="server" ID="CollapsiblePanelInstallation"
        TargetControlID="ContentInstallation"
        AutoCollapse="False"
        AutoExpand="False"
        ScrollContents="True"
        Collapsed="True"
        CollapseControlID="TitleInstallation"
        ExpandControlID="TitleInstallation" />
    <br />

    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Cloner un repository" ID="TitleCloneRepository"></asp:Label>
    <asp:Panel runat="server" ID="ContentClonerRepository">
        <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Cloner le repository est l'étape initiale qui permet d'instancier le lien avec le repository GitHub"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Les fonctions disponibles depuis le menu contextuel de windows (clic droit)"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Nous nous servirons ici presque uniquement de la fonction Git Clone"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Clone_1.png" />
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Faire Ok et vos identifiants GitHub vous serons demandés et le répertoire sera créé :"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Clone_2.png" />
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Les icones windows seront changées selon le statut de vos fichiers :"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_State.png" />
    </asp:Panel>
    <ajaxToolkit:CollapsiblePanelExtender runat="server" ID="CollapsiblePanelClonerRepository"
        TargetControlID="ContentClonerRepository"
        AutoCollapse="False"
        AutoExpand="False"
        ScrollContents="True"
        Collapsed="True"
        CollapseControlID="TitleCloneRepository"
        ExpandControlID="TitleCloneRepository" />

    <br />

    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Fonctionnement" ID="TitleFonctionnement" />
    <asp:Panel runat="server" ID="ContentFonctionnement">
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Le cycle :"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/Start_TortoiseGit_1.png" CssClass="LabSiteImageMedium" />
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Le schéma de fonctionnement de git avec les commandes principales à utiliser :"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Use.png" CssClass="LabSiteImageMedium" />
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Commit : envoyer vos modifications au repository local"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Sync : contient les actions d'interraction entre le repository local et GitHub :"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="     -Pull : recupérer les modifications de GitHub"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="     -Push : envoyer les commits vers GitHub"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Important : avant un Push, il faut toujours faire un Pull pour récupérer les eventuelles modifications des autres contributeurs."></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Il est possible de faire plusieurs commits et de se synchroniser ensuite avec GitHub"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="En cas de conflit lors d'un Pull ou Push, contactez vos Dirlabs :-)"></asp:Label>
        <br />
        <asp:Label runat="server" CssClass="LabSiteZoneTexte" Text="Démonstration de modification de code et d'envoi vers le repository GitHub"></asp:Label>
        <br />
        <asp:Image runat="server" ImageUrl="~/Resources/TortoiseGit/TortoiseGit_Demo.gif" CssClass="LabSiteImageLarge" />
        <br />
    </asp:Panel>
    <ajaxToolkit:CollapsiblePanelExtender runat="server" ID="CollapsiblePanelFonctionnement"
        TargetControlID="ContentFonctionnement"
        AutoCollapse="False"
        AutoExpand="False"
        ScrollContents="True"
        Collapsed="True"
        CollapseControlID="TitleFonctionnement"
        ExpandControlID="TitleFonctionnement" />


</asp:Content>

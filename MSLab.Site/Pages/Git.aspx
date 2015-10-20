<%@ Page Title="Git" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Git.aspx.cs" Inherits="MSLab.Site.Pages.Git" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Installation et création de compte" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Créez un compte sur GitHub :" />
    <asp:HyperLink runat="server" NavigateUrl="https://github.com/" Text="https://github.com/" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Telecharger la derniere version de Git :" />
    <asp:HyperLink runat="server" NavigateUrl="https://git-scm.com/downloads" Text="https://git-scm.com/downloads" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Lancez le setup :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_1.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Il est possible de décocher l'installation des logiciels GitBash et Git GUI si vous n'avez pas l'utilisation :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_3.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_4.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Selectionner Windows-Style puis faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_5.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_6.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_7.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_8.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text=" Faire finish :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_9.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="GIT + Visual Studio" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Afin de faire fonctionner Git avec Visual Studio, il faut installer cette extension :" />
    <asp:HyperLink ID="hyperlink2"
        NavigateUrl="~/Resources/Git/msysgitVS.exe"
        Text="Extension Git"
        runat="server" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Install puis Accept et attendre la fin de l'installation puis Finish et Exit" />
    <br />
    <asp:Label runat="server" CssClass="LabSitePageTitle2" Text="Utiliser Git...Hub" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Tous les repositorys seront crées en avance en tant que projet du groupe StartUpDev" />
    <asp:HyperLink NavigateUrl="https://github.com/StartupDeveloppement"
        Text="https://github.com/StartupDeveloppement"
        runat="server" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil" Text="Copiez l'URL du repository et clonez le à l'aide de Tortoise Git :" />
        <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_0.png" CssClass="LabSiteImageLarge"/>
    <br />
</asp:Content>

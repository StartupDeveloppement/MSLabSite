<%@ Page Title="Git" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Git.aspx.cs" Inherits="MSLab.Site.Pages.Git" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text="Telecharger la derniere version de Git :" />
    <br />
    <asp:HyperLink ID="hyperlink1"
        NavigateUrl="https://git-scm.com/downloads"
        Text="https://git-scm.com/downloads"
        runat="server" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Double clic sur le fichier téléchargé puis faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_1.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_2.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_3.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_4.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Selectionner Windows-Style puis faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_5.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_6.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_7.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire next :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_8.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text=" Faire finish :" />
    <br />
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_9.PNG" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text="<br />" />
    <br />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text="Afin de faire fonctionner Git avec Visual Studio, il faut installer cette application :" />
    <br />
    <asp:HyperLink ID="hyperlink2"
        NavigateUrl="~/Resources/Git/msysgitVS.exe"
        Text="Extension Git"
        runat="server" />
    <asp:Label runat="server" CssClass="LabSiteZoneConseil"  Text="Install puis Accept et attendre la fin de l'installation puis Finish et Exit" />
</asp:Content>

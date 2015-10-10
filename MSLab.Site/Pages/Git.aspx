<%@ Page Title="Git" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Git.aspx.cs" Inherits="MSLab.Site.Pages.Git" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="Telecharger la derniere version de Git :"></asp:Label>
    <asp:HyperLink ID="hyperlink1"
        NavigateUrl="https://git-scm.com/downloads"
        Text="https://git-scm.com/downloads"
        runat="server" />
    <asp:Label runat="server" Text="<br /> Double clic sur le fichier téléchargé puis faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_1.PNG" />
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_2.PNG" />
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_3.PNG" />
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_4.PNG" />
    <asp:Label runat="server" Text="<br /> Selectionner Windows-Style puis faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_5.PNG" />
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_6.PNG" />
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_7.PNG" />
    <asp:Label runat="server" Text="<br /> Faire next :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_8.PNG" />
    <asp:Label runat="server" Text="<br /> Faire finish :<br />"></asp:Label>
    <asp:Image runat="server" ImageUrl="~/Resources/Git/Git_Install_9.PNG" />
    
    <asp:Label runat="server" Text="<br /><br /><br />"></asp:Label>
    <asp:Label runat="server" Text="Afin de faire fonctionner Git avec Visual Studio, il faut installer cette application :"></asp:Label>
    <asp:HyperLink ID="hyperlink2"
        NavigateUrl="~/Resources/Git/msysgitVS.exe"
        Text="Extension Git"
        runat="server" />
</asp:Content>

<%@ Page Title="Start" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="MSLab.Site.Pages.Start" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="LabSiteZoneConseil">
        <asp:Label runat="server" Text="Afin de bien débuter dans le laboratoire Developpement > Microsoft, il vous faut faire les installations de base :"></asp:Label>
    </div>
    <table class="LabSiteTableau">
        <tr>
            <td>
                <asp:HyperLink runat="server" Text="Git/Github" NavigateUrl="~/Pages/GIT.aspx"/>
                <asp:Label runat="server" Text=" : controle de sources pour gérer le projet à plusieurs"></asp:Label>
            </td>
            <td>
                <asp:HyperLink runat="server" Text="Visual Studio" NavigateUrl="~/Pages/VisualStudio.aspx" />
                <asp:Label runat="server" Text=" : LE logiciel de développement !" />
            </td>
            <td>
                <asp:HyperLink runat="server" Text="Tortoise Git" NavigateUrl="~/Pages/TortoiseGit.aspx"/>
                <asp:Label runat="server" Text=" : surcouche pour les icones windows"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Image runat="server" ImageUrl="~/Resources/Start/Start_GitHub.png" Width="400" Height="300" />
            </td>
            <td>
                <asp:Image runat="server" ImageUrl="~/Resources/Start/Start_VisualStudio.png" Width="400" Height="300" />
            </td>
            <td>
                <asp:Image runat="server" ImageUrl="~/Resources/Start/Start_TortoiseGit.png" Width="400" Height="300" />
            </td>
        </tr>
    </table>
</asp:Content>

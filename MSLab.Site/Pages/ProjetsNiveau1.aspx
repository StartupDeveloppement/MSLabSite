<%@ Page Title="Projets Niveau 1" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjetsNiveau1.aspx.cs" Inherits="MSLab.Site.Pages.ProjetsNiveau1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="LabSiteZoneConseil">
            <asp:Label runat="server" Text="Toutes les solutions de projets débutants sont fournies" CssClass=""></asp:Label>
    </div>
    <div class="LabSiteZoneProjet">
        <table>
            <tr>
                <td>
                    <div class="LabSitePageTitle2">
                        <asp:Label runat="server" Text="Projet console : calculatrice"></asp:Label>
                    </div>                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Image runat="server" ImageUrl="~/Resources/ProjetsNiveau1/ProjetNiveau1_Calculatrice_1.PNG"/>
                </td>
            </tr>
        </table>
        <div class="LabSiteZoneTexteClient">
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Le client souhaiterais ajouter des fonctions à sa calculatrice:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="-Pouvoir utiliser des chiffres à virgule"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="-Faire différents types d'opérations"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="-Changer la couleur du texte selon le type de message"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="-Avoir un client graphiquement avancé"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
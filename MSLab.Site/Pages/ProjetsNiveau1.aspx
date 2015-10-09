<%@ Page Title="Projets Niveau 1" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjetsNiveau1.aspx.cs" Inherits="MSLab.Site.Pages.ProjetsNiveau1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="LabSiteZoneProjet">
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Projet console : calculatrice" CssClass="LabSitePageTitle2"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Image runat="server" ImageUrl="~/Resources/ProjetsNiveau1/ProjetNiveau1_Calculatrice_1.PNG" />
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
                        <asp:Label runat="server" Text="-Pouvoir utiliser des chiffres à virgule"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

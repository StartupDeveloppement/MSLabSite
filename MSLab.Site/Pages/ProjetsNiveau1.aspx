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
                    <asp:Image runat="server" ImageUrl="~/Resources/ProjetsNiveau1/ProjetNiveau1_Calculatrice_1.PNG" />
                </td>
            </tr>
        </table>
        <div class="LabSiteZoneTexteClient">
            <asp:Label runat="server" Text="Le client souhaiterais ajouter des fonctions à sa calculatrice:"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Partie fonctionnelle"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Partie technique"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Pouvoir utiliser des chiffres à virgule"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Utiliser le type double"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Faire différents types d'opérations"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Ajouter des méthodes à une classe"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Gérer les cas particuliers"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Utiliser tryParse sur un type"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Changer la couleur du texte selon le type de message"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <div class="LabSiteZoneProjet">
        <table>
            <tr>
                <td>
                    <div class="LabSitePageTitle2">
                        <asp:Label runat="server" Text="Projet console : MoneyManagement"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Image runat="server" ImageUrl="~/Resources/ProjetsNiveau1/ProjetNiveau1_MoneyManagement_1.PNG" />
                </td>
            </tr>
        </table>
        <div class="LabSiteZoneTexteClient">
            <asp:Label runat="server" Text="Le client souhaiterais ajouter des fonctions à son logiciel:"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Partie fonctionnelle"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Partie technique"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Faire différents types d'opérations, gérer l'affichage correspondant (exemple : edf, gaz, mobile, salaire ...)"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="- Pouvoir utiliser des chiffres à virgule"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Ajouter de la sécurité à l'application avec un identifiant/mot de passe"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="- Séparer la notion d'opération et de compte en banque avec un MoneyManager"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Avoir un client graphiquement avancé"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Utiliser string.Format()"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <div class="LabSiteZoneProjet">
        <table>
            <tr>
                <td>
                    <div class="LabSitePageTitle2">
                        <asp:Label runat="server" Text="Projet console : repertoire"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Image runat="server" ImageUrl="~/Resources/ProjetsNiveau1/ProjetNiveau1_Repertoire_1.PNG" />
                </td>
            </tr>
        </table>
        <div class="LabSiteZoneTexteClient">
            <asp:Label runat="server" Text="Le client souhaiterais ajouter des fonctions à son repertoire:"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Partie fonctionnelle"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Partie technique"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Ajouter le numero de téléphone"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Ajout de balises en Xaml"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Ajouter l'adresse"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Supprimer un élément donné"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Coder dans le code behind"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="- Ouvrir et enregistrer un fichier"></asp:Label>
                    </td>
                                        <td>
                        <asp:Label runat="server" Text="Serialisation des données"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

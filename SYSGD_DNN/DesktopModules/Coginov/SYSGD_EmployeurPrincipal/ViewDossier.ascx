<%@ Control language="C#" Inherits="Coginov.Modules.EmployeurPrincipal.ViewDossier" CodeFile="ViewDossier.ascx.cs" AutoEventWireup="true"%>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<link href="../../../Portals/_default/Skins/DarkKnight/skin.css" rel="stylesheet"
        type="text/css" />


<style type="text/css">
    .Col1
    {
        width: 180px;
    }
</style>


<div style="border-style: outset; padding: 10px; width: 950px; height: 450px;">
    <table>
        <tr>
        <td class="Col1"><asp:Label ID="lblNoEmployeur" runat="server" Text="Label" resourceKey="NoEmployeur" CssClass="Normal" />&nbsp;:</td>
        <td><asp:TextBox ID="tbNoEmployeur" runat="server"  Enabled="False" ReadOnly="True" Width="6em"></asp:TextBox>&nbsp;&nbsp;&nbsp;</td>
        <td><asp:Label ID="lblStatut" runat="server" Text="Label" resourceKey="Statut" CssClass="Normal" />&nbsp;:</td>
        <td><asp:TextBox ID="tbStatut" runat="server"  Enabled="False" ReadOnly="True" Width="10em"></asp:TextBox>&nbsp;&nbsp;&nbsp;</td>
        <td><asp:Label ID="lblLangue" runat="server" Text="Label" resourceKey="LangueCorresp" CssClass="Normal" />&nbsp;:</td>
        <td><asp:DropDownList ID="ddlLangue" runat="server" CssClass="Normal">
            <asp:ListItem Selected="True" Value="1">Francais</asp:ListItem>
            <asp:ListItem Value="2">Anglais</asp:ListItem>
            </asp:DropDownList></td>
        </tr>

    </table>
    <table>
        <tr>
            <td class="Col1"><asp:Label ID="lblraisonSociale" runat="server" Text="Label" resourceKey="RaisonSoc" CssClass="Normal" />&nbsp;:</td>
            <td><asp:TextBox ID="tbRaisonSociale" runat="server" Width="50em"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblraisonSocialeAbregee" runat="server" Text="Label" resourceKey="RaisonSocAbr" CssClass="Normal" />&nbsp;:</td>
            <td><asp:TextBox ID="tbRaisonSocialeAbregee" runat="server"  Width="50em"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="AdressePrincipale" runat="server" Text="Label" resourceKey="AdrPrincipale" CssClass="Normal" />&nbsp;:</td>
            <td>
                <asp:TextBox ID="tbNoCivique" runat="server"  Width="6em" />&nbsp;&nbsp;
                <asp:TextBox ID="tbRue" runat="server" Width="43em" /></td>
            <td></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:TextBox ID="tbVille" runat="server"  Width="50em" /></td>
            <td></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="tbRegion" runat="server" Width="10em" />&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlPays"  runat="server"  Width="20em"/>&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbCodePostal" runat="server"  Width="10em"/>
                
            </td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblURL" runat="server" Text="Label" resourceKey="SiteWeb" CssClass="Normal" />&nbsp;:</td>
            <td><asp:TextBox ID="tbURL" runat="server"  Width="50em"></asp:TextBox></td>
            <td></td>
        </tr>
 
    </table>
    <table>
        <tr>
            <td class="Col1"><asp:Label ID="lblTelephone" runat="server" Text="Label" resourceKey="Telephone" CssClass="Normal" />&nbsp;:</td>
            <td><asp:TextBox ID="tbTelephone" runat="server" Width="20em"></asp:TextBox></td>
            <td><asp:Label ID="lblFax" runat="server" Text="Label" resourceKey="Fax" CssClass="Normal" />&nbsp;:</td>
            <td><asp:TextBox ID="tbFax" runat="server" Width="21em"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="Col1"><asp:Label ID="lblDateAssujettissement" runat="server" Text="Label" resourceKey="DateAssujeti" CssClass="Normal" />&nbsp;:</td>
            <td>
                <telerik:RadDatePicker ID="RadDatePicker1" runat="server">
                </telerik:RadDatePicker>
                </td>
            <td><asp:Label ID="lblEmployeDepart" runat="server" Text="Label" resourceKey="EmployeDepart" CssClass="Normal" />&nbsp;:</td>
            <td><asp:TextBox ID="tbNbEmplDepart" runat="server" Width="6em" Enabled="False" /></td>
        </tr>
        <tr>
            <td class="Col1"><asp:Label ID="lblAssociation" runat="server" Text="Label" resourceKey="Association" CssClass="Normal" />&nbsp;:</td>
            <td colspan="3"><asp:TextBox ID="tbAssociation" runat="server" Width="30em" 
                    Enabled="False" ReadOnly="True" />                
        </tr>



    </table>





</div>

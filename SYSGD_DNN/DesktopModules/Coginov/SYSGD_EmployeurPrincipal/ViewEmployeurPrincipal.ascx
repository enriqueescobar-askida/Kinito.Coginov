<%@ Control language="C#" Inherits="Coginov.Modules.EmployeurPrincipal.ViewEmployeurPrincipal" CodeFile="ViewEmployeurPrincipal.ascx.cs" AutoEventWireup="true"%>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register TagPrefix="cog" TagName="dossier" Src="ViewDossier.ascx" %>
<%--~/desktopModules/Coginov/SYSGDEmployeurPrincipal/
--%>

<telerik:radtabstrip runat="server" ID="radTabStrip1" MultiPageID="RadMultiPage1" SelectedIndex="0" >
    <tabs>
        <telerik:RadTab runat="server" Text="Dossier" Selected="True" PageViewID="rpv_Dossier" />
        <telerik:RadTab runat="server" Text="Contacts"/>
        <telerik:RadTab runat="server" Text="RMP" />
        <telerik:RadTab runat="server" Text="Salaries" />
        <telerik:RadTab runat="server" Text="Syndicats" />
        <telerik:RadTab runat="server" Text="Notes" />
        <telerik:RadTab runat="server" Text="Reclamations" />
        <telerik:RadTab runat="server" Text="Inspections" />
        <telerik:RadTab runat="server" Text="Correspondance" />
    </tabs>
</telerik:radtabstrip>
<telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0" >
    <telerik:RadPageView ID="rpv_Dossier" runat="server">
           <cog:dossier ID="ViewDossier" runat="server" />
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView2" runat="server">
    Contacts
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView3" runat="server">
    RMP
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView4" runat="server">
    Salaries
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView5" runat="server">
    Syndcats
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView6" runat="server">
    Notes
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView7" runat="server">
    reclamations
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView8" runat="server">
    Inspections
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView1" runat="server">
    Correspondance 
    Ne pas oublier de mettre le bouton Retenir correspondance
    </telerik:RadPageView>



</telerik:RadMultiPage>


<%@ Control language="C#" Inherits="Coginov.Modules.SYSGD_ResultatsRecherche.ViewResultatsRecherche"
 CodeFile="ViewResultatsRecherche.ascx.cs" AutoEventWireup="true"%>
<%--Modifiez la section Inherits pour Coginov.Modules.NOMDUMODULE.viewFilename
Modifier egalement le codefile pour ViewFileName.ascx.cs
Assurez vous que le namespace et le nom de la classe du fichier ascx.cs soit identique.
Compilez et codez.
--%>
<asp:Label runat="server" id="lblSearch" Text="Salut"/>
<br/>
<br/>
<asp:TextBox runat="server" ID="txtSearchArg" style="margin-bottom: 0px">
</asp:TextBox>
<div id="divSearch" runat="server" title="DivSearch" Visible="false">
    <div id="divPlus" runat="server" title="DivPlus"  Visible="false"></div></br>
        <asp:Repeater id="rptSearch" runat="server">
            <ItemTemplate>
            <asp:LinkButton Text='<%#Eval("fieldString")%>' CommandArgument='<%#Eval("fieldID")%>' ID="lnkSearch" runat="server" OnClick="Btn_Search" ></asp:LinkButton></br>
            </ItemTemplate>
        </asp:Repeater>
    <div id="divNull" runat="server" title="DivNull"  Visible="false"></div></br>
    <asp:Button id="btnClear" runat="server" Visible="false" OnClick="Btn_Clear" />
</div>
<asp:HiddenField ID="hdID" runat="server"/>

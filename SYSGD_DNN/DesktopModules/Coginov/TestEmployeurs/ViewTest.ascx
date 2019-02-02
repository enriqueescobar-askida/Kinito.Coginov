<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewTest.ascx.cs" Inherits="DesktopModules_Coginov_TestEmployeurs_ViewTest" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<asp:linkbutton cssclass="CommandButton" id="cmdUpdate" resourcekey="cmdUpdate" runat="server" borderstyle="none" text="Update" OnClick="cmdUpdate_Click"></asp:linkbutton>&nbsp;
<asp:linkbutton cssclass="CommandButton" id="cmdCancel" resourcekey="cmdCancel" runat="server" borderstyle="none" text="Cancel" causesvalidation="False" OnClick="cmdCancel_Click"></asp:linkbutton>&nbsp;
<p></p><asp:TextBox  ID="TextBox2" runat="server"></asp:TextBox>
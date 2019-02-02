<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebEditToolBar.ascx.cs" Inherits="Coginov.Modules.EditToolbar.WebEditToolBar" %>

<style type="text/css">
    .style1
    {
        width: 20px;
        height:20px;
        
    }
    .style2
    {
        width: 50px;
        height: 23px;
    }
    .style3
    {
       height: 35px;
    }
  
  
</style>
<%--
<table>
    <tr>
        <td class="style1"></td>

        <td class="style2"><asp:ImageButton ID="imgBtnRefresh" runat="server" 
                onclick="imgBtnRefresh_Click" CssClass="style1" 
                ImageUrl="~/images/refresh.gif" /></td>
        <td class="style2"><asp:ImageButton ID="imgBtnNew" runat="server" 
                onclick="imgBtnNew_Click"  CssClass="style1" 
                ImageUrl="~/images/add.gif" /></td>
        <td class="style2"><asp:ImageButton ID="imgBtnEdit" runat="server" 
                onclick="imgBtnEdit_Click"  CssClass="style1" 
                ImageUrl="~/images/edit.gif" /></td>
        <td class="style2"><asp:ImageButton ID="imgBtnSave" runat="server" 
                onclick="imgBtnSave_Click" CssClass="style1" 
                ImageUrl="~/images/save.gif"  /></td>
        <td class="style2"><asp:ImageButton ID="imgBtnPrint" runat="server" 
                onclick="imgBtnPrint_Click" CssClass="style1" 
                ImageUrl="~/images/action_print.gif"  /></td>
    </tr>

    <tr>
        <td class="style1"></td>
        <td colspan="3" class="style3">
            <asp:TextBox ID="txtSearch" runat="server" Height="23px"></asp:TextBox>
        </td>
        <td class="style2" >
           <asp:ImageButton ID="imgSearch" runat="server" onclick="imgBtnSave_Click" 
                  ImageUrl="~/images/search_go.gif"  /></td>
        <td class="style2" >
            <asp:ImageButton ID="imgSearchAdvance" runat="server" onclick="imgBtnPrint_Click" 
                  ImageUrl="~/images/icon_search_16px.gif"  /></td>
   </tr>
</table>

--%>
<div style="width: 300px; text-align: right;">
<asp:ImageButton ID="imgBtnRefresh" runat="server" onclick="imgBtnRefresh_Click" CssClass="style1" ImageUrl="~/images/refresh.gif" />&nbsp;&nbsp;
<asp:ImageButton ID="imgBtnNew" runat="server" onclick="imgBtnNew_Click"  CssClass="style1" ImageUrl="~/images/add.gif" />&nbsp;&nbsp;
<asp:ImageButton ID="imgBtnEdit" runat="server" onclick="imgBtnEdit_Click"  CssClass="style1" ImageUrl="~/images/edit.gif" />&nbsp;&nbsp;
<asp:ImageButton ID="imgBtnSave" runat="server" onclick="imgBtnSave_Click" CssClass="style1" ImageUrl="~/images/save.gif"  />&nbsp;&nbsp;
<asp:ImageButton ID="imgBtnPrint" runat="server" onclick="imgBtnPrint_Click" CssClass="style1" ImageUrl="~/images/action_print.gif"  />
</div>
<div style="width: 300px; text-align: right; vertical-align: bottom;">
<asp:TextBox ID="txtSearchString" runat="server" Height="15px"></asp:TextBox>&nbsp;&nbsp;
<asp:ImageButton ID="imgBtnSearch" runat="server" 
        ImageUrl="~/images/Search/google-icon.gif" onclick="imgBtnSearch_Click"   />&nbsp;&nbsp;
<asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/images/icon_search_16px.gif"  />
</div>


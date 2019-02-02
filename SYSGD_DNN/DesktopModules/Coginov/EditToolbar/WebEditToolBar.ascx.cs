using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Modules.Communications;
using DotNetNuke.Security;




namespace Coginov.Modules.EditToolbar
{


public partial class WebEditToolBar : PortalModuleBase,  IModuleCommunicator
{
    public event ModuleCommunicationEventHandler ModuleCommunication;


    protected void Page_Load(object sender, EventArgs e)
    {
        this.imgBtnRefresh.AlternateText = Localization.GetString("btnRefresh",LocalResourceFile);
        this.imgBtnRefresh.ToolTip = Localization.GetString("btnRefresh",LocalResourceFile);

        this.imgBtnEdit.AlternateText = Localization.GetString("btnEdit", LocalResourceFile);
        this.imgBtnEdit.ToolTip = Localization.GetString("btnEdit", LocalResourceFile);

        this.imgBtnNew.AlternateText = Localization.GetString("btnNew", LocalResourceFile);
        this.imgBtnNew.ToolTip = Localization.GetString("btnNew", LocalResourceFile);

        this.imgBtnPrint.AlternateText = Localization.GetString("btnPrint", LocalResourceFile);
        this.imgBtnPrint.ToolTip = Localization.GetString("btnPrint", LocalResourceFile);

        this.imgBtnSave.AlternateText = Localization.GetString("btnSave", LocalResourceFile);
        this.imgBtnSave.ToolTip = Localization.GetString("btnSave", LocalResourceFile);

    }
        protected void imgBtnRefresh_Click(object sender, ImageClickEventArgs e)
        {
            ModuleCommunicationEventArgs mcArgs = GetMCArgs("btnRefresh");
            SendIMC(mcArgs);
        }

        protected void imgBtnNew_Click(object sender, ImageClickEventArgs e)
        {
           ModuleCommunicationEventArgs mcArgs = GetMCArgs("btnNew");
           SendIMC(mcArgs);
           
        }

        protected void imgBtnEdit_Click(object sender, ImageClickEventArgs e)
        {
            ModuleCommunicationEventArgs mcArgs = GetMCArgs("btnEdit");
            SendIMC(mcArgs);

        }

        protected void imgBtnSave_Click(object sender, ImageClickEventArgs e)
        {
            ModuleCommunicationEventArgs mcArgs = GetMCArgs("btnSave");
            SendIMC(mcArgs);

        }

        protected void imgBtnPrint_Click(object sender, ImageClickEventArgs e)
        {
            ModuleCommunicationEventArgs mcArgs = GetMCArgs("btnPrint");
            SendIMC(mcArgs);

        }

        protected void imgBtnSearch_Click(object sender, ImageClickEventArgs e)
        {
            ModuleCommunicationEventArgs mcArgs = GetMCArgs("");
            mcArgs.Target = "SYSGD_ResultatsRecherche";
            mcArgs.Text = txtSearchString.Text;

            SendIMC(mcArgs);
        }


        protected ModuleCommunicationEventArgs GetMCArgs(string txt)
        {
            ModuleCommunicationEventArgs mcArgs = 
                new ModuleCommunicationEventArgs();
            mcArgs.Sender = "WebEditToolBar";
            mcArgs.Target = "ToolBarMessageUser";
            mcArgs.Text = txt;
            return mcArgs;
        }
    
        protected void SendIMC(ModuleCommunicationEventArgs args)
        {
            if (ModuleCommunication != null)
            {
                ModuleCommunication(this, args);
            }
        }

   
}
}
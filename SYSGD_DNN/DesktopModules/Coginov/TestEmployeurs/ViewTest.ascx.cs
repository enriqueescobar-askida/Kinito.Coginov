using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;


using SYSGD_DAL;

using DotNetNuke.Entities.Modules.Communications;

public partial class DesktopModules_Coginov_TestEmployeurs_ViewTest : PortalModuleBase, IModuleListener
{

    public void OnModuleCommunication(object s,
        ModuleCommunicationEventArgs e)
    {
        this.TextBox2.Text = e.Text + " "  + e.Target;
            
                
    }
    
    
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        { 
        EmployeursDataCtrl ED = new EmployeursDataCtrl();

        Employeur ebo = ED.Select(1);


        this.TextBox1.Text = ebo.NomOriginal;
        this.Label1.Text = ebo.FicheEmployeurs.LastOrDefault().NoEmployeur;
        }
    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        EmployeursDataCtrl ED = new EmployeursDataCtrl();
        Employeur ebo = ED.Select(1);
        ebo.NomOriginal = this.TextBox1.Text;
        ebo.DateUpdate = System.DateTime.Now;





   
        if (ED.Save(ebo))
        {
            Response.Redirect(Request.Url.ToString());
        }
            
    }
    protected void cmdCancel_Click(object sender, EventArgs e)
    {

    }
}
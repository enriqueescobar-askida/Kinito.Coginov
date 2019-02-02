


using System;
using System.Linq;
using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;


using DotNetNuke.Entities.Modules.Communications;

using SYSGD_DAL;



namespace Coginov.Modules.EmployeurPrincipal
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The EditEmployeurPrincipal class is used to manage content
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <history>
    /// </history>
    /// -----------------------------------------------------------------------------
    partial class ViewDossier : UserUserControlBase,  IModuleListener
    {

        public void OnModuleCommunication(object s,  ModuleCommunicationEventArgs e)
        {
            if (e.Target == "ToolBarMessageUser")
            {
               // this.TextBox1.Text = e.Text;
            }
        
        }

    #region Private Members

        private int ItemId = Null.NullInteger;

    #endregion

    #region Event Handlers

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Page_Load runs when the control is loaded
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        protected void Page_Load(System.Object sender, System.EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    //Determine ItemId of EmployeurPrincipal to Update
                    int ItemID = 1;
                    LoadData(ItemId);
                //EmployeursDataCtrl ED = new EmployeursDataCtrl();

                //Employeur ebo = ED.Select(2);
                //FicheEmployeur ebo1 = ebo.FicheEmployeurs.LastOrDefault();
                //this.Label1.Text = ebo1.NoEmployeur + " - " + ebo1.RaisonSociale1;
                }
    
           }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// cmdCancel_Click runs when the cancel button is clicked
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        protected void cmdCancel_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.Response.Redirect(Globals.NavigateURL(this.TabId), true);
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// cmdDelete_Click runs when the delete button is clicked
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        protected void cmdDelete_Click(System.Object sender, System.EventArgs e)
        {
            try
            {


                this.Response.Redirect(Globals.NavigateURL(this.TabId), true);
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// cmdUpdate_Click runs when the update button is clicked
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        protected void cmdUpdate_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                //Redirect back to the portal home page
                this.Response.Redirect(Globals.NavigateURL(this.TabId), true);
             }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

    #endregion

        protected void SetLabels() 
        { 
        }
        protected void LoadData(int ItemID)
        {
            EmployeursDataCtrl ED = new EmployeursDataCtrl();

            Employeur ebo = ED.Select(2);
            FicheEmployeur ebo1 = ebo.FicheEmployeurs.LastOrDefault();

            this.tbRaisonSociale.Text = ebo1.RaisonSociale1;
        }

    }
}


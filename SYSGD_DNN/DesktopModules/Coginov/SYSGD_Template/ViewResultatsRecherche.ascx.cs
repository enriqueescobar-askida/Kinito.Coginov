// 
// Coginov® - http://www.coginov.com
// Copyright (c) 2011 
// par Coginov inc
// 
// Ce module est la propriété exclusive de Coginov inc. 
// 
// Description:
// Le module permet de gérer la table des congés fériés.
//
// Auteur principal:
//
// DATE: AAAA.MM.JJ
//--------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;

using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;

using DotNetNuke.Entities.Modules.Communications;

using Telerik.Web.UI;

namespace Coginov.Modules.NomModule
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The ViewEmployeurPrincipal class displays the content
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <history>
    /// </history>
    /// -----------------------------------------------------------------------------
    partial class ViewFileName : PortalModuleBase, IActionable
    {

        // Interfaces optionnelles : IModuleListener et IModuleCommunicator





        #region Private Members

        private string strTemplate;

        #endregion


        #region Private Methods

            /// <summary>
            /// Charge les valeurs de l'objet dans les controles.
            /// </summary>
            private void LoadData()
            { 
                //Creer une instance du DataController
                // Creer un objet d'affaire avec le select(ID) et
                // Utiliser cet objet pour hydrater le controle.
        
            }
        
        
        #endregion



        #region Public Methods

        public bool DisplayAudit()
        {
            bool retValue = false;

            if ((string)Settings["auditinfo"] == "Y")
            {
                retValue = true;
            }

            return retValue;
        }

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
                if (!Page.IsPostBack)
                {
                    LoadData();    
                }
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }

        }

   
        #endregion

      
        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Registers the module actions required for interfacing with the portal framework
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <history>
        /// </history>
        /// -----------------------------------------------------------------------------
        public ModuleActionCollection ModuleActions
        {
            get
            {
                ModuleActionCollection Actions = new ModuleActionCollection();
                Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
                return Actions;
            }
        }


        // Ce code est associé à l'interface IModuleListener
        //-----------------------------------------------------------
        //public void OnModuleCommunication(object s,  ModuleCommunicationEventArgs e)
        //{
        //    if (e.Target == "MessageID")
        //    {
        //        //Ajouter ici le traitement des messages
        //    }
        //}
        //--------------------------------------------------------------------------- 






        #endregion

    }
}


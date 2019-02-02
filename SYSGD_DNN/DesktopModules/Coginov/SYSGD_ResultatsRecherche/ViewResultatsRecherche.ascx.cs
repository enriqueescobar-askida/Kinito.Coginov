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
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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
using SYSGD_DAL;
using Telerik.Web.UI;

namespace Coginov.Modules.SYSGD_ResultatsRecherche
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
    partial class ViewResultatsRecherche : PortalModuleBase, IActionable, IModuleListener, IModuleCommunicator
    {
        // Interfaces optionnelles : IModuleListener et IModuleCommunicator
        #region Private Members
        private string strTemplate;
        #endregion

        #region Private Methods
        /// <summary>
        /// Charge les valeurs de l'objet dans les controles.
        /// </summary>
        /// <param name="s">The s.</param>
        private void LoadData(string s)
        {
            //Creer une instance du DataController
            SYSGD_DAL.FicheEmployeursDataCtrl fEmployeursDataCtrl = new SYSGD_DAL.FicheEmployeursDataCtrl();
            // Creer un objet d'affaire avec le select(ID) et
            IEnumerable<FicheEmployeur> fEmployeurs = fEmployeursDataCtrl.Select(s);
            var fields = (from ficheEmployeur in fEmployeurs
                               where ficheEmployeur != null
                               select new {
                                   fieldString =
                                   ficheEmployeur.NoEmployeur + " ; " +
                                   ficheEmployeur.RaisonSocialeAbregee + " ; " +
                                   ficheEmployeur.RaisonSociale1,
                                            fieldID =
                                   ficheEmployeur.FicheEmployeurID
                                          }).ToList();
            int result = fields.Count;
            //cleaning repeater first
            this.rptSearch.DataSource = null;
            this.rptSearch.DataBind();
            // Utiliser cet objet pour hydrater le controle.
            if (result > 0)
            {
                this.rptSearch.DataSource = fields;
                this.rptSearch.DataBind();
                Show_Plus();
                Hide_Null();
            }
            else
            {
                Hide_Plus();
                Show_Null();
            }
        }

        /// <summary>
        /// Loads the strings.
        /// </summary>
        private void LoadStrings()
        {
            this.lblSearch.Text = Localization.GetString("lblSearch", LocalResourceFile);
            this.btnClear.Text = Localization.GetString("btnClear", LocalResourceFile);
            this.divPlus.InnerText = Localization.GetString("divPlus", LocalResourceFile);
            this.divNull.InnerText = Localization.GetString("divNull", LocalResourceFile);
        }
        /// <summary>
        /// Show_s the reso.
        /// </summary>
        private void Show_Reso()
        {
            this.divSearch.Visible = true;
            this.divPlus.Visible = true;
            this.divNull.Visible = true;
        }
        /// <summary>
        /// Show_s the plus.
        /// </summary>
        private void Show_Plus()
        {
            this.divPlus.Visible = true;
        }
        /// <summary>
        /// Show_s the null.
        /// </summary>
        private void Show_Null()
        {
            this.divNull.Visible = true;
        }
        /// <summary>
        /// Hide_s the reso.
        /// </summary>
        private void Hide_Reso()
        {
            this.divSearch.Visible = false;
            this.divPlus.Visible = false;
            this.divNull.Visible = false;
        }
        /// <summary>
        /// Hide_s the plus.
        /// </summary>
        private void Hide_Plus()
        {
            this.divPlus.Visible = false;
        }
        /// <summary>
        /// Hide_s the null.
        /// </summary>
        private void Hide_Null()
        {
            this.divNull.Visible = false;
        }
        #endregion

        #region Public Methods
            /// <summary>
            /// Displays the audit.
            /// </summary>
            /// <returns></returns>
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
        /// <summary>
        /// Handles the Search event of the Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Btn_Search(System.Object sender, System.EventArgs e)
        {
            ModuleCommunicationEventArgs mcArgs =
                new ModuleCommunicationEventArgs();
            mcArgs.Target = "EntitePrincipale";
            mcArgs.Sender = "SYSGD_ResultatsRecherche";
            mcArgs.Text = ((LinkButton)sender).CommandArgument;
            if (ModuleCommunication != null)
                ModuleCommunication(this, mcArgs);
        }

        /// <summary>
        /// Handles the Clear event of the Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Btn_Clear(System.Object sender, System.EventArgs e)
        {
            this.txtSearchArg.Text = String.Empty;
            this.btnClear.Visible = false;
            this.rptSearch.DataSource = null;
            this.rptSearch.DataBind();
            Hide_Reso();
        }
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
                    LoadStrings();   
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

        /// <summary>
        /// Called when [module communication]. Ce code est associé à l'interface IModuleListener
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="e">The <see cref="DotNetNuke.Entities.Modules.Communications.ModuleCommunicationEventArgs"/> instance containing the event data.</param>
        public void OnModuleCommunication(object s, ModuleCommunicationEventArgs e)
        {
            if (e.Target == "SYSGD_ResultatsRecherche")
            {
                this.divSearch.Visible = true;
                this.btnClear.Visible = true;
                this.txtSearchArg.Text = e.Text;
                //Ajouter ici le traitement des messages
                LoadData(e.Text);
            }
        }
        #endregion

        #region Implementation of IModuleCommunicator
        /// <summary>
        /// Occurs when [module communication].
        /// </summary>
        public event ModuleCommunicationEventHandler ModuleCommunication;
        #endregion
    }
}


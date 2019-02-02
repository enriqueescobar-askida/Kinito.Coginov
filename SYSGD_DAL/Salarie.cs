namespace SYSGD_DAL
{
    using System;
    using System.ComponentModel;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Salarie")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Salarie : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Salarie object.
        /// </summary>
        /// <param name="salarieID">Initial value of the SalarieID property.</param>
        /// <param name="agentID">Initial value of the AgentID property.</param>
        /// <param name="employeurID">Initial value of the EmployeurID property.</param>
        /// <param name="dateUpdate">Initial value of the DateUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        public static Salarie CreateSalarie(global::System.Int32 salarieID, global::System.Int32 agentID, global::System.Int32 employeurID, global::System.DateTime dateUpdate, global::System.Int32 auteurUpdate, global::System.DateTime dateInsert, global::System.Int32 auteurInsert)
        {
            Salarie salarie = new Salarie();
            salarie.SalarieID = salarieID;
            salarie.AgentID = agentID;
            salarie.EmployeurID = employeurID;
            salarie.DateUpdate = dateUpdate;
            salarie.AuteurUpdate = auteurUpdate;
            salarie.DateInsert = dateInsert;
            salarie.AuteurInsert = auteurInsert;
            return salarie;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SalarieID
        {
            get
            {
                return this._SalarieID;
            }
            set
            {
                if (this._SalarieID != value)
                {
                    this.OnSalarieIDChanging(value);
                    this.ReportPropertyChanging("SalarieID");
                    this._SalarieID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("SalarieID");
                    this.OnSalarieIDChanged();
                }
            }
        }
        private global::System.Int32 _SalarieID;
        partial void OnSalarieIDChanging(global::System.Int32 value);
        partial void OnSalarieIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AgentID
        {
            get
            {
                return this._AgentID;
            }
            set
            {
                this.OnAgentIDChanging(value);
                this.ReportPropertyChanging("AgentID");
                this._AgentID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AgentID");
                this.OnAgentIDChanged();
            }
        }
        private global::System.Int32 _AgentID;
        partial void OnAgentIDChanging(global::System.Int32 value);
        partial void OnAgentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 EmployeurID
        {
            get
            {
                return this._EmployeurID;
            }
            set
            {
                this.OnEmployeurIDChanging(value);
                this.ReportPropertyChanging("EmployeurID");
                this._EmployeurID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("EmployeurID");
                this.OnEmployeurIDChanged();
            }
        }
        private global::System.Int32 _EmployeurID;
        partial void OnEmployeurIDChanging(global::System.Int32 value);
        partial void OnEmployeurIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DateUpdate
        {
            get
            {
                return this._DateUpdate;
            }
            set
            {
                this.OnDateUpdateChanging(value);
                this.ReportPropertyChanging("DateUpdate");
                this._DateUpdate = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateUpdate");
                this.OnDateUpdateChanged();
            }
        }
        private global::System.DateTime _DateUpdate;
        partial void OnDateUpdateChanging(global::System.DateTime value);
        partial void OnDateUpdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AuteurUpdate
        {
            get
            {
                return this._AuteurUpdate;
            }
            set
            {
                this.OnAuteurUpdateChanging(value);
                this.ReportPropertyChanging("AuteurUpdate");
                this._AuteurUpdate = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AuteurUpdate");
                this.OnAuteurUpdateChanged();
            }
        }
        private global::System.Int32 _AuteurUpdate;
        partial void OnAuteurUpdateChanging(global::System.Int32 value);
        partial void OnAuteurUpdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DateInsert
        {
            get
            {
                return this._DateInsert;
            }
            set
            {
                this.OnDateInsertChanging(value);
                this.ReportPropertyChanging("DateInsert");
                this._DateInsert = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateInsert");
                this.OnDateInsertChanged();
            }
        }
        private global::System.DateTime _DateInsert;
        partial void OnDateInsertChanging(global::System.DateTime value);
        partial void OnDateInsertChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AuteurInsert
        {
            get
            {
                return this._AuteurInsert;
            }
            set
            {
                this.OnAuteurInsertChanging(value);
                this.ReportPropertyChanging("AuteurInsert");
                this._AuteurInsert = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AuteurInsert");
                this.OnAuteurInsertChanged();
            }
        }
        private global::System.Int32 _AuteurInsert;
        partial void OnAuteurInsertChanging(global::System.Int32 value);
        partial void OnAuteurInsertChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_AgentSalarie", "Agent")]
        public Agent Agent
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Agent>("SYSGDIIModel.FK_AgentSalarie", "Agent").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Agent>("SYSGDIIModel.FK_AgentSalarie", "Agent").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Agent> AgentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Agent>("SYSGDIIModel.FK_AgentSalarie", "Agent");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Agent>("SYSGDIIModel.FK_AgentSalarie", "Agent", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_EmployeurSalarie", "Employeur")]
        public Employeur Employeur
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurSalarie", "Employeur").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurSalarie", "Employeur").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Employeur> EmployeurReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurSalarie", "Employeur");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurSalarie", "Employeur", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SalarieEpisode", "Episodes")]
        public EntityCollection<Episode> Episodes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Episode>("SYSGDIIModel.FK_SalarieEpisode", "Episodes");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Episode>("SYSGDIIModel.FK_SalarieEpisode", "Episodes", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SalarieFicheSalarie", "FicheSalaries")]
        public EntityCollection<FicheSalarie> FicheSalaries
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheSalarie>("SYSGDIIModel.FK_SalarieFicheSalarie", "FicheSalaries");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheSalarie>("SYSGDIIModel.FK_SalarieFicheSalarie", "FicheSalaries", value);
                }
            }
        }

        #endregion
    }
}
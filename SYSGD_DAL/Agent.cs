namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Agent")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Agent : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Agent object.
        /// </summary>
        /// <param name="agentID">Initial value of the AgentID property.</param>
        /// <param name="nomOriginal">Initial value of the NomOriginal property.</param>
        /// <param name="prenomOriginal">Initial value of the PrenomOriginal property.</param>
        /// <param name="nASOriginal">Initial value of the NASOriginal property.</param>
        /// <param name="dateUpdate">Initial value of the DateUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        public static Agent CreateAgent(global::System.Int32 agentID, global::System.String nomOriginal, global::System.String prenomOriginal, global::System.String nASOriginal, global::System.DateTime dateUpdate, global::System.Int32 auteurUpdate, global::System.DateTime dateInsert, global::System.Int32 auteurInsert)
        {
            Agent agent = new Agent();
            agent.AgentID = agentID;
            agent.NomOriginal = nomOriginal;
            agent.PrenomOriginal = prenomOriginal;
            agent.NASOriginal = nASOriginal;
            agent.DateUpdate = dateUpdate;
            agent.AuteurUpdate = auteurUpdate;
            agent.DateInsert = dateInsert;
            agent.AuteurInsert = auteurInsert;
            return agent;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AgentID
        {
            get
            {
                return this._AgentID;
            }
            set
            {
                if (this._AgentID != value)
                {
                    this.OnAgentIDChanging(value);
                    this.ReportPropertyChanging("AgentID");
                    this._AgentID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("AgentID");
                    this.OnAgentIDChanged();
                }
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
        public global::System.String NomOriginal
        {
            get
            {
                return this._NomOriginal;
            }
            set
            {
                this.OnNomOriginalChanging(value);
                this.ReportPropertyChanging("NomOriginal");
                this._NomOriginal = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NomOriginal");
                this.OnNomOriginalChanged();
            }
        }
        private global::System.String _NomOriginal;
        partial void OnNomOriginalChanging(global::System.String value);
        partial void OnNomOriginalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String PrenomOriginal
        {
            get
            {
                return this._PrenomOriginal;
            }
            set
            {
                this.OnPrenomOriginalChanging(value);
                this.ReportPropertyChanging("PrenomOriginal");
                this._PrenomOriginal = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("PrenomOriginal");
                this.OnPrenomOriginalChanged();
            }
        }
        private global::System.String _PrenomOriginal;
        partial void OnPrenomOriginalChanging(global::System.String value);
        partial void OnPrenomOriginalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String NASOriginal
        {
            get
            {
                return this._NASOriginal;
            }
            set
            {
                this.OnNASOriginalChanging(value);
                this.ReportPropertyChanging("NASOriginal");
                this._NASOriginal = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NASOriginal");
                this.OnNASOriginalChanged();
            }
        }
        private global::System.String _NASOriginal;
        partial void OnNASOriginalChanging(global::System.String value);
        partial void OnNASOriginalChanged();
    
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_AgentSalarie", "Salaries")]
        public EntityCollection<Salarie> Salaries
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Salarie>("SYSGDIIModel.FK_AgentSalarie", "Salaries");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Salarie>("SYSGDIIModel.FK_AgentSalarie", "Salaries", value);
                }
            }
        }

        #endregion
    }
}
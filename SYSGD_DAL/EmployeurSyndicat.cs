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
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="EmployeurSyndicat")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class EmployeurSyndicat : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmployeurSyndicat object.
        /// </summary>
        /// <param name="employeurSyndicatID">Initial value of the EmployeurSyndicatID property.</param>
        /// <param name="employeurID">Initial value of the EmployeurID property.</param>
        /// <param name="syndicatID">Initial value of the SyndicatID property.</param>
        /// <param name="dateUpdate">Initial value of the DateUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        public static EmployeurSyndicat CreateEmployeurSyndicat(global::System.Int32 employeurSyndicatID, global::System.Int32 employeurID, global::System.Int32 syndicatID, global::System.DateTime dateUpdate, global::System.Int32 auteurUpdate, global::System.DateTime dateInsert, global::System.Int32 auteurInsert)
        {
            EmployeurSyndicat employeurSyndicat = new EmployeurSyndicat();
            employeurSyndicat.EmployeurSyndicatID = employeurSyndicatID;
            employeurSyndicat.EmployeurID = employeurID;
            employeurSyndicat.SyndicatID = syndicatID;
            employeurSyndicat.DateUpdate = dateUpdate;
            employeurSyndicat.AuteurUpdate = auteurUpdate;
            employeurSyndicat.DateInsert = dateInsert;
            employeurSyndicat.AuteurInsert = auteurInsert;
            return employeurSyndicat;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 EmployeurSyndicatID
        {
            get
            {
                return this._EmployeurSyndicatID;
            }
            set
            {
                if (this._EmployeurSyndicatID != value)
                {
                    this.OnEmployeurSyndicatIDChanging(value);
                    this.ReportPropertyChanging("EmployeurSyndicatID");
                    this._EmployeurSyndicatID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("EmployeurSyndicatID");
                    this.OnEmployeurSyndicatIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeurSyndicatID;
        partial void OnEmployeurSyndicatIDChanging(global::System.Int32 value);
        partial void OnEmployeurSyndicatIDChanged();
    
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
        public global::System.Int32 SyndicatID
        {
            get
            {
                return this._SyndicatID;
            }
            set
            {
                this.OnSyndicatIDChanging(value);
                this.ReportPropertyChanging("SyndicatID");
                this._SyndicatID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SyndicatID");
                this.OnSyndicatIDChanged();
            }
        }
        private global::System.Int32 _SyndicatID;
        partial void OnSyndicatIDChanging(global::System.Int32 value);
        partial void OnSyndicatIDChanged();
    
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_EmployeurEmployeurSyndicat", "Employeur")]
        public Employeur Employeur
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurEmployeurSyndicat", "Employeur").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurEmployeurSyndicat", "Employeur").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurEmployeurSyndicat", "Employeur");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurEmployeurSyndicat", "Employeur", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SyndicatEmployeurSyndicat", "Syndicats")]
        public Syndicat Syndicats
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatEmployeurSyndicat", "Syndicats").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatEmployeurSyndicat", "Syndicats").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Syndicat> SyndicatsReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatEmployeurSyndicat", "Syndicats");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatEmployeurSyndicat", "Syndicats", value);
                }
            }
        }

        #endregion
    }
}
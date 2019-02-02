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
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Affectation")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Affectation : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Affectation object.
        /// </summary>
        /// <param name="affectationID">Initial value of the AffectationID property.</param>
        /// <param name="roleID">Initial value of the RoleID property.</param>
        /// <param name="debutAffectation">Initial value of the DebutAffectation property.</param>
        /// <param name="employeurID">Initial value of the EmployeurID property.</param>
        /// <param name="contactID">Initial value of the ContactID property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        /// <param name="dateUpdate">Initial value of the DateUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        public static Affectation CreateAffectation(global::System.Int32 affectationID, global::System.Int32 roleID, global::System.DateTime debutAffectation, global::System.Int32 employeurID, global::System.Int32 contactID, global::System.DateTime dateInsert, global::System.Int32 auteurInsert, global::System.DateTime dateUpdate, global::System.Int32 auteurUpdate)
        {
            Affectation affectation = new Affectation();
            affectation.AffectationID = affectationID;
            affectation.RoleID = roleID;
            affectation.DebutAffectation = debutAffectation;
            affectation.EmployeurID = employeurID;
            affectation.ContactID = contactID;
            affectation.DateInsert = dateInsert;
            affectation.AuteurInsert = auteurInsert;
            affectation.DateUpdate = dateUpdate;
            affectation.AuteurUpdate = auteurUpdate;
            return affectation;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AffectationID
        {
            get
            {
                return this._AffectationID;
            }
            set
            {
                if (this._AffectationID != value)
                {
                    this.OnAffectationIDChanging(value);
                    this.ReportPropertyChanging("AffectationID");
                    this._AffectationID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("AffectationID");
                    this.OnAffectationIDChanged();
                }
            }
        }
        private global::System.Int32 _AffectationID;
        partial void OnAffectationIDChanging(global::System.Int32 value);
        partial void OnAffectationIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 RoleID
        {
            get
            {
                return this._RoleID;
            }
            set
            {
                this.OnRoleIDChanging(value);
                this.ReportPropertyChanging("RoleID");
                this._RoleID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("RoleID");
                this.OnRoleIDChanged();
            }
        }
        private global::System.Int32 _RoleID;
        partial void OnRoleIDChanging(global::System.Int32 value);
        partial void OnRoleIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DebutAffectation
        {
            get
            {
                return this._DebutAffectation;
            }
            set
            {
                this.OnDebutAffectationChanging(value);
                this.ReportPropertyChanging("DebutAffectation");
                this._DebutAffectation = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DebutAffectation");
                this.OnDebutAffectationChanged();
            }
        }
        private global::System.DateTime _DebutAffectation;
        partial void OnDebutAffectationChanging(global::System.DateTime value);
        partial void OnDebutAffectationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.DateTime> FinAffectation
        {
            get
            {
                return this._FinAffectation;
            }
            set
            {
                this.OnFinAffectationChanging(value);
                this.ReportPropertyChanging("FinAffectation");
                this._FinAffectation = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("FinAffectation");
                this.OnFinAffectationChanged();
            }
        }
        private Nullable<global::System.DateTime> _FinAffectation;
        partial void OnFinAffectationChanging(Nullable<global::System.DateTime> value);
        partial void OnFinAffectationChanged();
    
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
        public global::System.Int32 ContactID
        {
            get
            {
                return this._ContactID;
            }
            set
            {
                this.OnContactIDChanging(value);
                this.ReportPropertyChanging("ContactID");
                this._ContactID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ContactID");
                this.OnContactIDChanged();
            }
        }
        private global::System.Int32 _ContactID;
        partial void OnContactIDChanging(global::System.Int32 value);
        partial void OnContactIDChanged();
    
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

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_Affectation_Contact", "Contact")]
        public Contact Contact
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("SYSGDIIModel.FK_Affectation_Contact", "Contact").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("SYSGDIIModel.FK_Affectation_Contact", "Contact").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Contact> ContactReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("SYSGDIIModel.FK_Affectation_Contact", "Contact");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Contact>("SYSGDIIModel.FK_Affectation_Contact", "Contact", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_Affectation_Employeur", "Employeur")]
        public Employeur Employeur
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_Affectation_Employeur", "Employeur").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_Affectation_Employeur", "Employeur").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_Affectation_Employeur", "Employeur");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employeur>("SYSGDIIModel.FK_Affectation_Employeur", "Employeur", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_Affectation_Role", "Role")]
        public Role Role
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("SYSGDIIModel.FK_Affectation_Role", "Role").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("SYSGDIIModel.FK_Affectation_Role", "Role").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Role> RoleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("SYSGDIIModel.FK_Affectation_Role", "Role");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Role>("SYSGDIIModel.FK_Affectation_Role", "Role", value);
                }
            }
        }

        #endregion
    }
}
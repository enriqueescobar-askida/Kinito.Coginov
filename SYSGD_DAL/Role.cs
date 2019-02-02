namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Role")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Role : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Role object.
        /// </summary>
        /// <param name="roleID">Initial value of the RoleID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        /// <param name="obligatoire">Initial value of the Obligatoire property.</param>
        /// <param name="ordre">Initial value of the Ordre property.</param>
        public static Role CreateRole(global::System.Int32 roleID, global::System.String nom, global::System.Boolean obligatoire, global::System.Int32 ordre)
        {
            Role role = new Role();
            role.RoleID = roleID;
            role.Nom = nom;
            role.Obligatoire = obligatoire;
            role.Ordre = ordre;
            return role;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 RoleID
        {
            get
            {
                return this._RoleID;
            }
            set
            {
                if (this._RoleID != value)
                {
                    this.OnRoleIDChanging(value);
                    this.ReportPropertyChanging("RoleID");
                    this._RoleID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
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
        public global::System.String Nom
        {
            get
            {
                return this._Nom;
            }
            set
            {
                this.OnNomChanging(value);
                this.ReportPropertyChanging("Nom");
                this._Nom = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Nom");
                this.OnNomChanged();
            }
        }
        private global::System.String _Nom;
        partial void OnNomChanging(global::System.String value);
        partial void OnNomChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Boolean Obligatoire
        {
            get
            {
                return this._Obligatoire;
            }
            set
            {
                this.OnObligatoireChanging(value);
                this.ReportPropertyChanging("Obligatoire");
                this._Obligatoire = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Obligatoire");
                this.OnObligatoireChanged();
            }
        }
        private global::System.Boolean _Obligatoire;
        partial void OnObligatoireChanging(global::System.Boolean value);
        partial void OnObligatoireChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 Ordre
        {
            get
            {
                return this._Ordre;
            }
            set
            {
                this.OnOrdreChanging(value);
                this.ReportPropertyChanging("Ordre");
                this._Ordre = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Ordre");
                this.OnOrdreChanged();
            }
        }
        private global::System.Int32 _Ordre;
        partial void OnOrdreChanging(global::System.Int32 value);
        partial void OnOrdreChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_Affectation_Role", "Affectation")]
        public EntityCollection<Affectation> Affectations
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Affectation>("SYSGDIIModel.FK_Affectation_Role", "Affectation");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Affectation>("SYSGDIIModel.FK_Affectation_Role", "Affectation", value);
                }
            }
        }

        #endregion
    }
}
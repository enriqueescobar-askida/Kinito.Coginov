namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Employeur")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Employeur : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employeur object.
        /// </summary>
        /// <param name="employeurID">Initial value of the EmployeurID property.</param>
        /// <param name="nomOriginal">Initial value of the NomOriginal property.</param>
        /// <param name="dateUpdate">Initial value of the DateUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        public static Employeur CreateEmployeur(global::System.Int32 employeurID, global::System.String nomOriginal, global::System.DateTime dateUpdate, global::System.Int32 auteurUpdate, global::System.DateTime dateInsert, global::System.Int32 auteurInsert)
        {
            Employeur employeur = new Employeur();
            employeur.EmployeurID = employeurID;
            employeur.NomOriginal = nomOriginal;
            employeur.DateUpdate = dateUpdate;
            employeur.AuteurUpdate = auteurUpdate;
            employeur.DateInsert = dateInsert;
            employeur.AuteurInsert = auteurInsert;
            return employeur;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 EmployeurID
        {
            get
            {
                return this._EmployeurID;
            }
            set
            {
                if (this._EmployeurID != value)
                {
                    this.OnEmployeurIDChanging(value);
                    this.ReportPropertyChanging("EmployeurID");
                    this._EmployeurID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("EmployeurID");
                    this.OnEmployeurIDChanged();
                }
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_EmployeurEmployeurSyndicat", "EmployeurSyndicats")]
        public EntityCollection<EmployeurSyndicat> EmployeurSyndicats
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EmployeurSyndicat>("SYSGDIIModel.FK_EmployeurEmployeurSyndicat", "EmployeurSyndicats");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EmployeurSyndicat>("SYSGDIIModel.FK_EmployeurEmployeurSyndicat", "EmployeurSyndicats", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_EmployeurFicheEmployeur", "FicheEmployeurs")]
        public EntityCollection<FicheEmployeur> FicheEmployeurs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheEmployeur>("SYSGDIIModel.FK_EmployeurFicheEmployeur", "FicheEmployeurs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheEmployeur>("SYSGDIIModel.FK_EmployeurFicheEmployeur", "FicheEmployeurs", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_EmployeurSalarie", "Salaries")]
        public EntityCollection<Salarie> Salaries
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Salarie>("SYSGDIIModel.FK_EmployeurSalarie", "Salaries");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Salarie>("SYSGDIIModel.FK_EmployeurSalarie", "Salaries", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_Affectation_Employeur", "Affectation")]
        public EntityCollection<Affectation> Affectations
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Affectation>("SYSGDIIModel.FK_Affectation_Employeur", "Affectation");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Affectation>("SYSGDIIModel.FK_Affectation_Employeur", "Affectation", value);
                }
            }
        }

        #endregion
    }
}
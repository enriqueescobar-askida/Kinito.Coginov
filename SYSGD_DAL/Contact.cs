namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Contact")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Contact : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contact object.
        /// </summary>
        /// <param name="contactID">Initial value of the ContactID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        /// <param name="prenom">Initial value of the Prenom property.</param>
        /// <param name="dataUpdate">Initial value of the DataUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        /// <param name="titre">Initial value of the Titre property.</param>
        public static Contact CreateContact(global::System.Int32 contactID, global::System.String nom, global::System.String prenom, global::System.DateTime dataUpdate, global::System.Int32 auteurUpdate, global::System.DateTime dateInsert, global::System.Int32 auteurInsert, global::System.String titre)
        {
            Contact contact = new Contact();
            contact.ContactID = contactID;
            contact.Nom = nom;
            contact.Prenom = prenom;
            contact.DataUpdate = dataUpdate;
            contact.AuteurUpdate = auteurUpdate;
            contact.DateInsert = dateInsert;
            contact.AuteurInsert = auteurInsert;
            contact.Titre = titre;
            return contact;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 ContactID
        {
            get
            {
                return this._ContactID;
            }
            set
            {
                if (this._ContactID != value)
                {
                    this.OnContactIDChanging(value);
                    this.ReportPropertyChanging("ContactID");
                    this._ContactID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("ContactID");
                    this.OnContactIDChanged();
                }
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
        public global::System.String Prenom
        {
            get
            {
                return this._Prenom;
            }
            set
            {
                this.OnPrenomChanging(value);
                this.ReportPropertyChanging("Prenom");
                this._Prenom = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Prenom");
                this.OnPrenomChanged();
            }
        }
        private global::System.String _Prenom;
        partial void OnPrenomChanging(global::System.String value);
        partial void OnPrenomChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DataUpdate
        {
            get
            {
                return this._DataUpdate;
            }
            set
            {
                this.OnDataUpdateChanging(value);
                this.ReportPropertyChanging("DataUpdate");
                this._DataUpdate = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DataUpdate");
                this.OnDataUpdateChanged();
            }
        }
        private global::System.DateTime _DataUpdate;
        partial void OnDataUpdateChanging(global::System.DateTime value);
        partial void OnDataUpdateChanged();
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Titre
        {
            get
            {
                return this._Titre;
            }
            set
            {
                this.OnTitreChanging(value);
                this.ReportPropertyChanging("Titre");
                this._Titre = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Titre");
                this.OnTitreChanged();
            }
        }
        private global::System.String _Titre;
        partial void OnTitreChanging(global::System.String value);
        partial void OnTitreChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_ContactFicheContact", "FicheContacts")]
        public EntityCollection<FicheContact> FicheContacts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheContact>("SYSGDIIModel.FK_ContactFicheContact", "FicheContacts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheContact>("SYSGDIIModel.FK_ContactFicheContact", "FicheContacts", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_Affectation_Contact", "Affectation")]
        public EntityCollection<Affectation> Affectations
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Affectation>("SYSGDIIModel.FK_Affectation_Contact", "Affectation");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Affectation>("SYSGDIIModel.FK_Affectation_Contact", "Affectation", value);
                }
            }
        }

        #endregion
    }
}
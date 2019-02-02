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
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="FicheContact")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class FicheContact : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FicheContact object.
        /// </summary>
        /// <param name="ficheContactID">Initial value of the FicheContactID property.</param>
        /// <param name="contactID">Initial value of the ContactID property.</param>
        /// <param name="noCivique">Initial value of the NoCivique property.</param>
        /// <param name="rue">Initial value of the Rue property.</param>
        /// <param name="ville">Initial value of the Ville property.</param>
        /// <param name="region">Initial value of the Region property.</param>
        /// <param name="pays">Initial value of the Pays property.</param>
        /// <param name="valide">Initial value of the Valide property.</param>
        /// <param name="telephone1">Initial value of the Telephone1 property.</param>
        /// <param name="typeTelephone1">Initial value of the TypeTelephone1 property.</param>
        /// <param name="telephone2">Initial value of the Telephone2 property.</param>
        /// <param name="typeTelephone2">Initial value of the TypeTelephone2 property.</param>
        /// <param name="notes">Initial value of the Notes property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        /// <param name="telecopieur">Initial value of the Telecopieur property.</param>
        /// <param name="courriel">Initial value of the Courriel property.</param>
        public static FicheContact CreateFicheContact(global::System.Int32 ficheContactID, global::System.Int32 contactID, global::System.String noCivique, global::System.String rue, global::System.String ville, global::System.String region, global::System.String pays, global::System.Boolean valide, global::System.String telephone1, global::System.Int32 typeTelephone1, global::System.String telephone2, global::System.Int32 typeTelephone2, global::System.String notes, global::System.DateTime dateInsert, global::System.Int32 auteurInsert, global::System.String telecopieur, global::System.String courriel)
        {
            FicheContact ficheContact = new FicheContact();
            ficheContact.FicheContactID = ficheContactID;
            ficheContact.ContactID = contactID;
            ficheContact.NoCivique = noCivique;
            ficheContact.Rue = rue;
            ficheContact.Ville = ville;
            ficheContact.Region = region;
            ficheContact.Pays = pays;
            ficheContact.Valide = valide;
            ficheContact.Telephone1 = telephone1;
            ficheContact.TypeTelephone1 = typeTelephone1;
            ficheContact.Telephone2 = telephone2;
            ficheContact.TypeTelephone2 = typeTelephone2;
            ficheContact.Notes = notes;
            ficheContact.DateInsert = dateInsert;
            ficheContact.AuteurInsert = auteurInsert;
            ficheContact.Telecopieur = telecopieur;
            ficheContact.Courriel = courriel;
            return ficheContact;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 FicheContactID
        {
            get
            {
                return this._FicheContactID;
            }
            set
            {
                if (this._FicheContactID != value)
                {
                    this.OnFicheContactIDChanging(value);
                    this.ReportPropertyChanging("FicheContactID");
                    this._FicheContactID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("FicheContactID");
                    this.OnFicheContactIDChanged();
                }
            }
        }
        private global::System.Int32 _FicheContactID;
        partial void OnFicheContactIDChanging(global::System.Int32 value);
        partial void OnFicheContactIDChanged();
    
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
        public global::System.String NoCivique
        {
            get
            {
                return this._NoCivique;
            }
            set
            {
                this.OnNoCiviqueChanging(value);
                this.ReportPropertyChanging("NoCivique");
                this._NoCivique = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NoCivique");
                this.OnNoCiviqueChanged();
            }
        }
        private global::System.String _NoCivique;
        partial void OnNoCiviqueChanging(global::System.String value);
        partial void OnNoCiviqueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Rue
        {
            get
            {
                return this._Rue;
            }
            set
            {
                this.OnRueChanging(value);
                this.ReportPropertyChanging("Rue");
                this._Rue = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Rue");
                this.OnRueChanged();
            }
        }
        private global::System.String _Rue;
        partial void OnRueChanging(global::System.String value);
        partial void OnRueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Ville
        {
            get
            {
                return this._Ville;
            }
            set
            {
                this.OnVilleChanging(value);
                this.ReportPropertyChanging("Ville");
                this._Ville = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Ville");
                this.OnVilleChanged();
            }
        }
        private global::System.String _Ville;
        partial void OnVilleChanging(global::System.String value);
        partial void OnVilleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Region
        {
            get
            {
                return this._Region;
            }
            set
            {
                this.OnRegionChanging(value);
                this.ReportPropertyChanging("Region");
                this._Region = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Region");
                this.OnRegionChanged();
            }
        }
        private global::System.String _Region;
        partial void OnRegionChanging(global::System.String value);
        partial void OnRegionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Pays
        {
            get
            {
                return this._Pays;
            }
            set
            {
                this.OnPaysChanging(value);
                this.ReportPropertyChanging("Pays");
                this._Pays = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Pays");
                this.OnPaysChanged();
            }
        }
        private global::System.String _Pays;
        partial void OnPaysChanging(global::System.String value);
        partial void OnPaysChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Boolean Valide
        {
            get
            {
                return this._Valide;
            }
            set
            {
                this.OnValideChanging(value);
                this.ReportPropertyChanging("Valide");
                this._Valide = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Valide");
                this.OnValideChanged();
            }
        }
        private global::System.Boolean _Valide;
        partial void OnValideChanging(global::System.Boolean value);
        partial void OnValideChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Telephone1
        {
            get
            {
                return this._Telephone1;
            }
            set
            {
                this.OnTelephone1Changing(value);
                this.ReportPropertyChanging("Telephone1");
                this._Telephone1 = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Telephone1");
                this.OnTelephone1Changed();
            }
        }
        private global::System.String _Telephone1;
        partial void OnTelephone1Changing(global::System.String value);
        partial void OnTelephone1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 TypeTelephone1
        {
            get
            {
                return this._TypeTelephone1;
            }
            set
            {
                this.OnTypeTelephone1Changing(value);
                this.ReportPropertyChanging("TypeTelephone1");
                this._TypeTelephone1 = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("TypeTelephone1");
                this.OnTypeTelephone1Changed();
            }
        }
        private global::System.Int32 _TypeTelephone1;
        partial void OnTypeTelephone1Changing(global::System.Int32 value);
        partial void OnTypeTelephone1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Telephone2
        {
            get
            {
                return this._Telephone2;
            }
            set
            {
                this.OnTelephone2Changing(value);
                this.ReportPropertyChanging("Telephone2");
                this._Telephone2 = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Telephone2");
                this.OnTelephone2Changed();
            }
        }
        private global::System.String _Telephone2;
        partial void OnTelephone2Changing(global::System.String value);
        partial void OnTelephone2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 TypeTelephone2
        {
            get
            {
                return this._TypeTelephone2;
            }
            set
            {
                this.OnTypeTelephone2Changing(value);
                this.ReportPropertyChanging("TypeTelephone2");
                this._TypeTelephone2 = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("TypeTelephone2");
                this.OnTypeTelephone2Changed();
            }
        }
        private global::System.Int32 _TypeTelephone2;
        partial void OnTypeTelephone2Changing(global::System.Int32 value);
        partial void OnTypeTelephone2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this.ReportPropertyChanging("Notes");
                this._Notes = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Notes");
                this.OnNotesChanged();
            }
        }
        private global::System.String _Notes;
        partial void OnNotesChanging(global::System.String value);
        partial void OnNotesChanged();
    
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
        public global::System.String Telecopieur
        {
            get
            {
                return this._Telecopieur;
            }
            set
            {
                this.OnTelecopieurChanging(value);
                this.ReportPropertyChanging("Telecopieur");
                this._Telecopieur = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Telecopieur");
                this.OnTelecopieurChanged();
            }
        }
        private global::System.String _Telecopieur;
        partial void OnTelecopieurChanging(global::System.String value);
        partial void OnTelecopieurChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Courriel
        {
            get
            {
                return this._Courriel;
            }
            set
            {
                this.OnCourrielChanging(value);
                this.ReportPropertyChanging("Courriel");
                this._Courriel = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Courriel");
                this.OnCourrielChanged();
            }
        }
        private global::System.String _Courriel;
        partial void OnCourrielChanging(global::System.String value);
        partial void OnCourrielChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_ContactFicheContact", "Contact")]
        public Contact Contact
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("SYSGDIIModel.FK_ContactFicheContact", "Contact").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("SYSGDIIModel.FK_ContactFicheContact", "Contact").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Contact>("SYSGDIIModel.FK_ContactFicheContact", "Contact");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Contact>("SYSGDIIModel.FK_ContactFicheContact", "Contact", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheContact", "Telephone")]
        public Telephone Telephone
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact", "Telephone").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact", "Telephone").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Telephone> TelephoneReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact", "Telephone");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact", "Telephone", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheContact1", "Telephone")]
        public Telephone Telephone_1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact1", "Telephone").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact1", "Telephone").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Telephone> Telephone_1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact1", "Telephone");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheContact1", "Telephone", value);
                }
            }
        }

        #endregion
    }
}
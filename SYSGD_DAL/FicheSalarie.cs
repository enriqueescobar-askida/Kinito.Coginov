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
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="FicheSalarie")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class FicheSalarie : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FicheSalarie object.
        /// </summary>
        /// <param name="ficheSalarieID">Initial value of the FicheSalarieID property.</param>
        /// <param name="salarieID">Initial value of the SalarieID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        /// <param name="prenom">Initial value of the Prenom property.</param>
        /// <param name="sexeID">Initial value of the SexeID property.</param>
        /// <param name="syndicatID">Initial value of the SyndicatID property.</param>
        /// <param name="dateNaissance">Initial value of the DateNaissance property.</param>
        /// <param name="nAS">Initial value of the NAS property.</param>
        /// <param name="noEmploye">Initial value of the NoEmploye property.</param>
        /// <param name="noCivique">Initial value of the NoCivique property.</param>
        /// <param name="rue">Initial value of the Rue property.</param>
        /// <param name="ville">Initial value of the Ville property.</param>
        /// <param name="region">Initial value of the Region property.</param>
        /// <param name="pays">Initial value of the Pays property.</param>
        /// <param name="codePostal">Initial value of the CodePostal property.</param>
        /// <param name="telephone1">Initial value of the Telephone1 property.</param>
        /// <param name="typeTelephone1">Initial value of the TypeTelephone1 property.</param>
        /// <param name="telephone2">Initial value of the Telephone2 property.</param>
        /// <param name="typeTelephone2">Initial value of the TypeTelephone2 property.</param>
        /// <param name="couriel">Initial value of the Couriel property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        public static FicheSalarie CreateFicheSalarie(global::System.Int32 ficheSalarieID, global::System.Int32 salarieID, global::System.String nom, global::System.String prenom, global::System.Int32 sexeID, global::System.Int32 syndicatID, global::System.DateTime dateNaissance, global::System.String nAS, global::System.String noEmploye, global::System.String noCivique, global::System.String rue, global::System.String ville, global::System.String region, global::System.String pays, global::System.String codePostal, global::System.String telephone1, global::System.Int32 typeTelephone1, global::System.String telephone2, global::System.Int32 typeTelephone2, global::System.String couriel, global::System.DateTime dateInsert, global::System.Int32 auteurInsert)
        {
            FicheSalarie ficheSalarie = new FicheSalarie();
            ficheSalarie.FicheSalarieID = ficheSalarieID;
            ficheSalarie.SalarieID = salarieID;
            ficheSalarie.Nom = nom;
            ficheSalarie.Prenom = prenom;
            ficheSalarie.SexeID = sexeID;
            ficheSalarie.SyndicatID = syndicatID;
            ficheSalarie.DateNaissance = dateNaissance;
            ficheSalarie.NAS = nAS;
            ficheSalarie.NoEmploye = noEmploye;
            ficheSalarie.NoCivique = noCivique;
            ficheSalarie.Rue = rue;
            ficheSalarie.Ville = ville;
            ficheSalarie.Region = region;
            ficheSalarie.Pays = pays;
            ficheSalarie.CodePostal = codePostal;
            ficheSalarie.Telephone1 = telephone1;
            ficheSalarie.TypeTelephone1 = typeTelephone1;
            ficheSalarie.Telephone2 = telephone2;
            ficheSalarie.TypeTelephone2 = typeTelephone2;
            ficheSalarie.Couriel = couriel;
            ficheSalarie.DateInsert = dateInsert;
            ficheSalarie.AuteurInsert = auteurInsert;
            return ficheSalarie;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 FicheSalarieID
        {
            get
            {
                return this._FicheSalarieID;
            }
            set
            {
                if (this._FicheSalarieID != value)
                {
                    this.OnFicheSalarieIDChanging(value);
                    this.ReportPropertyChanging("FicheSalarieID");
                    this._FicheSalarieID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("FicheSalarieID");
                    this.OnFicheSalarieIDChanged();
                }
            }
        }
        private global::System.Int32 _FicheSalarieID;
        partial void OnFicheSalarieIDChanging(global::System.Int32 value);
        partial void OnFicheSalarieIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SalarieID
        {
            get
            {
                return this._SalarieID;
            }
            set
            {
                this.OnSalarieIDChanging(value);
                this.ReportPropertyChanging("SalarieID");
                this._SalarieID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SalarieID");
                this.OnSalarieIDChanged();
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
        public global::System.Int32 SexeID
        {
            get
            {
                return this._SexeID;
            }
            set
            {
                this.OnSexeIDChanging(value);
                this.ReportPropertyChanging("SexeID");
                this._SexeID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SexeID");
                this.OnSexeIDChanged();
            }
        }
        private global::System.Int32 _SexeID;
        partial void OnSexeIDChanging(global::System.Int32 value);
        partial void OnSexeIDChanged();
    
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
        public global::System.DateTime DateNaissance
        {
            get
            {
                return this._DateNaissance;
            }
            set
            {
                this.OnDateNaissanceChanging(value);
                this.ReportPropertyChanging("DateNaissance");
                this._DateNaissance = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateNaissance");
                this.OnDateNaissanceChanged();
            }
        }
        private global::System.DateTime _DateNaissance;
        partial void OnDateNaissanceChanging(global::System.DateTime value);
        partial void OnDateNaissanceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String NAS
        {
            get
            {
                return this._NAS;
            }
            set
            {
                this.OnNASChanging(value);
                this.ReportPropertyChanging("NAS");
                this._NAS = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NAS");
                this.OnNASChanged();
            }
        }
        private global::System.String _NAS;
        partial void OnNASChanging(global::System.String value);
        partial void OnNASChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String NoEmploye
        {
            get
            {
                return this._NoEmploye;
            }
            set
            {
                this.OnNoEmployeChanging(value);
                this.ReportPropertyChanging("NoEmploye");
                this._NoEmploye = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NoEmploye");
                this.OnNoEmployeChanged();
            }
        }
        private global::System.String _NoEmploye;
        partial void OnNoEmployeChanging(global::System.String value);
        partial void OnNoEmployeChanged();
    
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
        public global::System.String CodePostal
        {
            get
            {
                return this._CodePostal;
            }
            set
            {
                this.OnCodePostalChanging(value);
                this.ReportPropertyChanging("CodePostal");
                this._CodePostal = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("CodePostal");
                this.OnCodePostalChanged();
            }
        }
        private global::System.String _CodePostal;
        partial void OnCodePostalChanging(global::System.String value);
        partial void OnCodePostalChanged();
    
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
        public global::System.String Couriel
        {
            get
            {
                return this._Couriel;
            }
            set
            {
                this.OnCourielChanging(value);
                this.ReportPropertyChanging("Couriel");
                this._Couriel = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Couriel");
                this.OnCourielChanged();
            }
        }
        private global::System.String _Couriel;
        partial void OnCourielChanging(global::System.String value);
        partial void OnCourielChanged();
    
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SalarieFicheSalarie", "Salarie")]
        public Salarie Salarie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieFicheSalarie", "Salarie").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieFicheSalarie", "Salarie").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Salarie> SalarieReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieFicheSalarie", "Salarie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieFicheSalarie", "Salarie", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SyndicatFicheSalarie", "Syndicats")]
        public Syndicat Syndicat
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatFicheSalarie", "Syndicats").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatFicheSalarie", "Syndicats").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Syndicat> SyndicatReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatFicheSalarie", "Syndicats");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Syndicat>("SYSGDIIModel.FK_SyndicatFicheSalarie", "Syndicats", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheSalarie", "Telephone")]
        public Telephone Telephone
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie", "Telephone").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie", "Telephone").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie", "Telephone");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie", "Telephone", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheSalarie1", "Telephone")]
        public Telephone Telephone_1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie1", "Telephone").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie1", "Telephone").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie1", "Telephone");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Telephone>("SYSGDIIModel.TelephoneFicheSalarie1", "Telephone", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "SexeFicheSalarie", "Sexe")]
        public Sexe Sexe
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sexe>("SYSGDIIModel.SexeFicheSalarie", "Sexe").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sexe>("SYSGDIIModel.SexeFicheSalarie", "Sexe").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Sexe> SexeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Sexe>("SYSGDIIModel.SexeFicheSalarie", "Sexe");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Sexe>("SYSGDIIModel.SexeFicheSalarie", "Sexe", value);
                }
            }
        }

        #endregion
    }
}
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
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="FicheEmployeur")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class FicheEmployeur : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FicheEmployeur object.
        /// </summary>
        /// <param name="ficheEmployeurID">Initial value of the FicheEmployeurID property.</param>
        /// <param name="employeurID">Initial value of the EmployeurID property.</param>
        /// <param name="langueCorespondanceID">Initial value of the LangueCorespondanceID property.</param>
        /// <param name="typeRMPID">Initial value of the TypeRMPID property.</param>
        /// <param name="natureEntrepriseID">Initial value of the NatureEntrepriseID property.</param>
        /// <param name="periodeReferenceID">Initial value of the PeriodeReferenceID property.</param>
        /// <param name="noEmployeur">Initial value of the NoEmployeur property.</param>
        /// <param name="raisonSociale1">Initial value of the RaisonSociale1 property.</param>
        /// <param name="raisonSocialeAbregee">Initial value of the RaisonSocialeAbregee property.</param>
        /// <param name="actif">Initial value of the Actif property.</param>
        /// <param name="periodePaieID">Initial value of the PeriodePaieID property.</param>
        /// <param name="semainePaieID">Initial value of the SemainePaieID property.</param>
        /// <param name="associationPatronaleID">Initial value of the AssociationPatronaleID property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        /// <param name="dateDebutActivite">Initial value of the DateDebutActivite property.</param>
        /// <param name="noCivique">Initial value of the NoCivique property.</param>
        /// <param name="rue">Initial value of the Rue property.</param>
        /// <param name="ville">Initial value of the Ville property.</param>
        /// <param name="region">Initial value of the Region property.</param>
        /// <param name="pays">Initial value of the Pays property.</param>
        /// <param name="codePostal">Initial value of the CodePostal property.</param>
        /// <param name="telephone">Initial value of the Telephone property.</param>
        public static FicheEmployeur CreateFicheEmployeur(global::System.Int32 ficheEmployeurID, global::System.Int32 employeurID, global::System.Int32 langueCorespondanceID, global::System.Int32 typeRMPID, global::System.Int32 natureEntrepriseID, global::System.Int32 periodeReferenceID, global::System.String noEmployeur, global::System.String raisonSociale1, global::System.String raisonSocialeAbregee, global::System.Boolean actif, global::System.Int32 periodePaieID, global::System.Int32 semainePaieID, global::System.Int32 associationPatronaleID, global::System.DateTime dateInsert, global::System.Int32 auteurInsert, global::System.DateTime dateDebutActivite, global::System.String noCivique, global::System.String rue, global::System.String ville, global::System.String region, global::System.String pays, global::System.String codePostal, global::System.String telephone)
        {
            FicheEmployeur ficheEmployeur = new FicheEmployeur();
            ficheEmployeur.FicheEmployeurID = ficheEmployeurID;
            ficheEmployeur.EmployeurID = employeurID;
            ficheEmployeur.LangueCorespondanceID = langueCorespondanceID;
            ficheEmployeur.TypeRMPID = typeRMPID;
            ficheEmployeur.NatureEntrepriseID = natureEntrepriseID;
            ficheEmployeur.PeriodeReferenceID = periodeReferenceID;
            ficheEmployeur.NoEmployeur = noEmployeur;
            ficheEmployeur.RaisonSociale1 = raisonSociale1;
            ficheEmployeur.RaisonSocialeAbregee = raisonSocialeAbregee;
            ficheEmployeur.Actif = actif;
            ficheEmployeur.PeriodePaieID = periodePaieID;
            ficheEmployeur.SemainePaieID = semainePaieID;
            ficheEmployeur.AssociationPatronaleID = associationPatronaleID;
            ficheEmployeur.DateInsert = dateInsert;
            ficheEmployeur.AuteurInsert = auteurInsert;
            ficheEmployeur.DateDebutActivite = dateDebutActivite;
            ficheEmployeur.NoCivique = noCivique;
            ficheEmployeur.Rue = rue;
            ficheEmployeur.Ville = ville;
            ficheEmployeur.Region = region;
            ficheEmployeur.Pays = pays;
            ficheEmployeur.CodePostal = codePostal;
            ficheEmployeur.Telephone = telephone;
            return ficheEmployeur;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 FicheEmployeurID
        {
            get
            {
                return this._FicheEmployeurID;
            }
            set
            {
                if (this._FicheEmployeurID != value)
                {
                    this.OnFicheEmployeurIDChanging(value);
                    this.ReportPropertyChanging("FicheEmployeurID");
                    this._FicheEmployeurID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("FicheEmployeurID");
                    this.OnFicheEmployeurIDChanged();
                }
            }
        }
        private global::System.Int32 _FicheEmployeurID;
        partial void OnFicheEmployeurIDChanging(global::System.Int32 value);
        partial void OnFicheEmployeurIDChanged();
    
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
        public global::System.Int32 LangueCorespondanceID
        {
            get
            {
                return this._LangueCorespondanceID;
            }
            set
            {
                this.OnLangueCorespondanceIDChanging(value);
                this.ReportPropertyChanging("LangueCorespondanceID");
                this._LangueCorespondanceID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LangueCorespondanceID");
                this.OnLangueCorespondanceIDChanged();
            }
        }
        private global::System.Int32 _LangueCorespondanceID;
        partial void OnLangueCorespondanceIDChanging(global::System.Int32 value);
        partial void OnLangueCorespondanceIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 TypeRMPID
        {
            get
            {
                return this._TypeRMPID;
            }
            set
            {
                this.OnTypeRMPIDChanging(value);
                this.ReportPropertyChanging("TypeRMPID");
                this._TypeRMPID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("TypeRMPID");
                this.OnTypeRMPIDChanged();
            }
        }
        private global::System.Int32 _TypeRMPID;
        partial void OnTypeRMPIDChanging(global::System.Int32 value);
        partial void OnTypeRMPIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 NatureEntrepriseID
        {
            get
            {
                return this._NatureEntrepriseID;
            }
            set
            {
                this.OnNatureEntrepriseIDChanging(value);
                this.ReportPropertyChanging("NatureEntrepriseID");
                this._NatureEntrepriseID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("NatureEntrepriseID");
                this.OnNatureEntrepriseIDChanged();
            }
        }
        private global::System.Int32 _NatureEntrepriseID;
        partial void OnNatureEntrepriseIDChanging(global::System.Int32 value);
        partial void OnNatureEntrepriseIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 PeriodeReferenceID
        {
            get
            {
                return this._PeriodeReferenceID;
            }
            set
            {
                this.OnPeriodeReferenceIDChanging(value);
                this.ReportPropertyChanging("PeriodeReferenceID");
                this._PeriodeReferenceID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PeriodeReferenceID");
                this.OnPeriodeReferenceIDChanged();
            }
        }
        private global::System.Int32 _PeriodeReferenceID;
        partial void OnPeriodeReferenceIDChanging(global::System.Int32 value);
        partial void OnPeriodeReferenceIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String NoEmployeur
        {
            get
            {
                return this._NoEmployeur;
            }
            set
            {
                this.OnNoEmployeurChanging(value);
                this.ReportPropertyChanging("NoEmployeur");
                this._NoEmployeur = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("NoEmployeur");
                this.OnNoEmployeurChanged();
            }
        }
        private global::System.String _NoEmployeur;
        partial void OnNoEmployeurChanging(global::System.String value);
        partial void OnNoEmployeurChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String RaisonSociale1
        {
            get
            {
                return this._RaisonSociale1;
            }
            set
            {
                this.OnRaisonSociale1Changing(value);
                this.ReportPropertyChanging("RaisonSociale1");
                this._RaisonSociale1 = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("RaisonSociale1");
                this.OnRaisonSociale1Changed();
            }
        }
        private global::System.String _RaisonSociale1;
        partial void OnRaisonSociale1Changing(global::System.String value);
        partial void OnRaisonSociale1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String RaisonSocialeAbregee
        {
            get
            {
                return this._RaisonSocialeAbregee;
            }
            set
            {
                this.OnRaisonSocialeAbregeeChanging(value);
                this.ReportPropertyChanging("RaisonSocialeAbregee");
                this._RaisonSocialeAbregee = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("RaisonSocialeAbregee");
                this.OnRaisonSocialeAbregeeChanged();
            }
        }
        private global::System.String _RaisonSocialeAbregee;
        partial void OnRaisonSocialeAbregeeChanging(global::System.String value);
        partial void OnRaisonSocialeAbregeeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Boolean Actif
        {
            get
            {
                return this._Actif;
            }
            set
            {
                this.OnActifChanging(value);
                this.ReportPropertyChanging("Actif");
                this._Actif = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Actif");
                this.OnActifChanged();
            }
        }
        private global::System.Boolean _Actif;
        partial void OnActifChanging(global::System.Boolean value);
        partial void OnActifChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 PeriodePaieID
        {
            get
            {
                return this._PeriodePaieID;
            }
            set
            {
                this.OnPeriodePaieIDChanging(value);
                this.ReportPropertyChanging("PeriodePaieID");
                this._PeriodePaieID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("PeriodePaieID");
                this.OnPeriodePaieIDChanged();
            }
        }
        private global::System.Int32 _PeriodePaieID;
        partial void OnPeriodePaieIDChanging(global::System.Int32 value);
        partial void OnPeriodePaieIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SemainePaieID
        {
            get
            {
                return this._SemainePaieID;
            }
            set
            {
                this.OnSemainePaieIDChanging(value);
                this.ReportPropertyChanging("SemainePaieID");
                this._SemainePaieID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SemainePaieID");
                this.OnSemainePaieIDChanged();
            }
        }
        private global::System.Int32 _SemainePaieID;
        partial void OnSemainePaieIDChanging(global::System.Int32 value);
        partial void OnSemainePaieIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AssociationPatronaleID
        {
            get
            {
                return this._AssociationPatronaleID;
            }
            set
            {
                this.OnAssociationPatronaleIDChanging(value);
                this.ReportPropertyChanging("AssociationPatronaleID");
                this._AssociationPatronaleID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AssociationPatronaleID");
                this.OnAssociationPatronaleIDChanged();
            }
        }
        private global::System.Int32 _AssociationPatronaleID;
        partial void OnAssociationPatronaleIDChanging(global::System.Int32 value);
        partial void OnAssociationPatronaleIDChanged();
    
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
        public global::System.DateTime DateDebutActivite
        {
            get
            {
                return this._DateDebutActivite;
            }
            set
            {
                this.OnDateDebutActiviteChanging(value);
                this.ReportPropertyChanging("DateDebutActivite");
                this._DateDebutActivite = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateDebutActivite");
                this.OnDateDebutActiviteChanged();
            }
        }
        private global::System.DateTime _DateDebutActivite;
        partial void OnDateDebutActiviteChanging(global::System.DateTime value);
        partial void OnDateDebutActiviteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.DateTime> DateDebutRMP
        {
            get
            {
                return this._DateDebutRMP;
            }
            set
            {
                this.OnDateDebutRMPChanging(value);
                this.ReportPropertyChanging("DateDebutRMP");
                this._DateDebutRMP = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateDebutRMP");
                this.OnDateDebutRMPChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateDebutRMP;
        partial void OnDateDebutRMPChanging(Nullable<global::System.DateTime> value);
        partial void OnDateDebutRMPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
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
                this._Telecopieur = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> RetenirCorrespondance
        {
            get
            {
                return this._RetenirCorrespondance;
            }
            set
            {
                this.OnRetenirCorrespondanceChanging(value);
                this.ReportPropertyChanging("RetenirCorrespondance");
                this._RetenirCorrespondance = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("RetenirCorrespondance");
                this.OnRetenirCorrespondanceChanged();
            }
        }
        private Nullable<global::System.Boolean> _RetenirCorrespondance;
        partial void OnRetenirCorrespondanceChanging(Nullable<global::System.Boolean> value);
        partial void OnRetenirCorrespondanceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> ParentEmployeurID
        {
            get
            {
                return this._ParentEmployeurID;
            }
            set
            {
                this.OnParentEmployeurIDChanging(value);
                this.ReportPropertyChanging("ParentEmployeurID");
                this._ParentEmployeurID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ParentEmployeurID");
                this.OnParentEmployeurIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ParentEmployeurID;
        partial void OnParentEmployeurIDChanging(Nullable<global::System.Int32> value);
        partial void OnParentEmployeurIDChanged();
    
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
        public global::System.String Telephone
        {
            get
            {
                return this._Telephone;
            }
            set
            {
                this.OnTelephoneChanging(value);
                this.ReportPropertyChanging("Telephone");
                this._Telephone = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Telephone");
                this.OnTelephoneChanged();
            }
        }
        private global::System.String _Telephone;
        partial void OnTelephoneChanging(global::System.String value);
        partial void OnTelephoneChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_EmployeurFicheEmployeur", "Employeur")]
        public Employeur Employeur
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurFicheEmployeur", "Employeur").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurFicheEmployeur", "Employeur").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurFicheEmployeur", "Employeur");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employeur>("SYSGDIIModel.FK_EmployeurFicheEmployeur", "Employeur", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TypeRMPFicheEmployeur", "TypeRMP")]
        public TypeRMP TypeRMP
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TypeRMP>("SYSGDIIModel.TypeRMPFicheEmployeur", "TypeRMP").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TypeRMP>("SYSGDIIModel.TypeRMPFicheEmployeur", "TypeRMP").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<TypeRMP> TypeRMPReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TypeRMP>("SYSGDIIModel.TypeRMPFicheEmployeur", "TypeRMP");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TypeRMP>("SYSGDIIModel.TypeRMPFicheEmployeur", "TypeRMP", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "PeriodeReferenceFicheEmployeur", "PeriodeReference")]
        public PeriodeReference PeriodeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PeriodeReference>("SYSGDIIModel.PeriodeReferenceFicheEmployeur", "PeriodeReference").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PeriodeReference>("SYSGDIIModel.PeriodeReferenceFicheEmployeur", "PeriodeReference").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<PeriodeReference> PeriodeReferenceReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PeriodeReference>("SYSGDIIModel.PeriodeReferenceFicheEmployeur", "PeriodeReference");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<PeriodeReference>("SYSGDIIModel.PeriodeReferenceFicheEmployeur", "PeriodeReference", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "PeriodePaieFicheEmployeur", "PeriodePaie")]
        public PeriodePaie PeriodePaie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PeriodePaie>("SYSGDIIModel.PeriodePaieFicheEmployeur", "PeriodePaie").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PeriodePaie>("SYSGDIIModel.PeriodePaieFicheEmployeur", "PeriodePaie").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<PeriodePaie> PeriodePaieReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PeriodePaie>("SYSGDIIModel.PeriodePaieFicheEmployeur", "PeriodePaie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<PeriodePaie>("SYSGDIIModel.PeriodePaieFicheEmployeur", "PeriodePaie", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "NatureEntrepriseFicheEmployeur", "NatureEntreprise")]
        public NatureEntreprise NatureEntreprise
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NatureEntreprise>("SYSGDIIModel.NatureEntrepriseFicheEmployeur", "NatureEntreprise").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NatureEntreprise>("SYSGDIIModel.NatureEntrepriseFicheEmployeur", "NatureEntreprise").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<NatureEntreprise> NatureEntrepriseReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<NatureEntreprise>("SYSGDIIModel.NatureEntrepriseFicheEmployeur", "NatureEntreprise");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<NatureEntreprise>("SYSGDIIModel.NatureEntrepriseFicheEmployeur", "NatureEntreprise", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "LangueFicheEmployeur", "Langue")]
        public Langue Langue
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Langue>("SYSGDIIModel.LangueFicheEmployeur", "Langue").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Langue>("SYSGDIIModel.LangueFicheEmployeur", "Langue").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Langue> LangueReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Langue>("SYSGDIIModel.LangueFicheEmployeur", "Langue");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Langue>("SYSGDIIModel.LangueFicheEmployeur", "Langue", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "AssociationPatronaleFicheEmployeur", "AssociationPatronale")]
        public AssociationPatronale AssociationPatronale
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AssociationPatronale>("SYSGDIIModel.AssociationPatronaleFicheEmployeur", "AssociationPatronale").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AssociationPatronale>("SYSGDIIModel.AssociationPatronaleFicheEmployeur", "AssociationPatronale").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<AssociationPatronale> AssociationPatronaleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<AssociationPatronale>("SYSGDIIModel.AssociationPatronaleFicheEmployeur", "AssociationPatronale");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<AssociationPatronale>("SYSGDIIModel.AssociationPatronaleFicheEmployeur", "AssociationPatronale", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "SemainePaieFicheEmployeur", "SemainePaie")]
        public SemainePaie SemainePaie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SemainePaie>("SYSGDIIModel.SemainePaieFicheEmployeur", "SemainePaie").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SemainePaie>("SYSGDIIModel.SemainePaieFicheEmployeur", "SemainePaie").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<SemainePaie> SemainePaieReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SemainePaie>("SYSGDIIModel.SemainePaieFicheEmployeur", "SemainePaie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SemainePaie>("SYSGDIIModel.SemainePaieFicheEmployeur", "SemainePaie", value);
                }
            }
        }

        #endregion
    }
}
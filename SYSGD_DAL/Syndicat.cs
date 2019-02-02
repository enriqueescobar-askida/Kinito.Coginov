namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Syndicat")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Syndicat : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Syndicat object.
        /// </summary>
        /// <param name="syndicatID">Initial value of the SyndicatID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        public static Syndicat CreateSyndicat(global::System.Int32 syndicatID, global::System.String nom)
        {
            Syndicat syndicat = new Syndicat();
            syndicat.SyndicatID = syndicatID;
            syndicat.Nom = nom;
            return syndicat;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SyndicatID
        {
            get
            {
                return this._SyndicatID;
            }
            set
            {
                if (this._SyndicatID != value)
                {
                    this.OnSyndicatIDChanging(value);
                    this.ReportPropertyChanging("SyndicatID");
                    this._SyndicatID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("SyndicatID");
                    this.OnSyndicatIDChanged();
                }
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

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SyndicatEmployeurSyndicat", "EmployeurSyndicats")]
        public EntityCollection<EmployeurSyndicat> EmployeurSyndicats
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EmployeurSyndicat>("SYSGDIIModel.FK_SyndicatEmployeurSyndicat", "EmployeurSyndicats");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EmployeurSyndicat>("SYSGDIIModel.FK_SyndicatEmployeurSyndicat", "EmployeurSyndicats", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SyndicatFicheSalarie", "FicheSalaries")]
        public EntityCollection<FicheSalarie> FicheSalaries
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheSalarie>("SYSGDIIModel.FK_SyndicatFicheSalarie", "FicheSalaries");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheSalarie>("SYSGDIIModel.FK_SyndicatFicheSalarie", "FicheSalaries", value);
                }
            }
        }

        #endregion
    }
}
namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Telephone")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Telephone : Pilotage
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Telephone object.
        /// </summary>
        /// <param name="pilotageID">Initial value of the PilotageID property.</param>
        /// <param name="nom">Initial value of the nom property.</param>
        public static Telephone CreateTelephone(global::System.Int32 pilotageID, global::System.String nom)
        {
            Telephone telephone = new Telephone();
            telephone.PilotageID = pilotageID;
            telephone.nom = nom;
            return telephone;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this.OnnomChanging(value);
                this.ReportPropertyChanging("nom");
                this._nom = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("nom");
                this.OnnomChanged();
            }
        }
        private global::System.String _nom;
        partial void OnnomChanging(global::System.String value);
        partial void OnnomChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheSalarie", "FicheSalarie")]
        public EntityCollection<FicheSalarie> FicheSalarie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheSalarie>("SYSGDIIModel.TelephoneFicheSalarie", "FicheSalarie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheSalarie>("SYSGDIIModel.TelephoneFicheSalarie", "FicheSalarie", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheSalarie1", "FicheSalarie")]
        public EntityCollection<FicheSalarie> FicheSalarie_1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheSalarie>("SYSGDIIModel.TelephoneFicheSalarie1", "FicheSalarie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheSalarie>("SYSGDIIModel.TelephoneFicheSalarie1", "FicheSalarie", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheContact", "FicheContact")]
        public EntityCollection<FicheContact> FicheContact
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheContact>("SYSGDIIModel.TelephoneFicheContact", "FicheContact");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheContact>("SYSGDIIModel.TelephoneFicheContact", "FicheContact", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "TelephoneFicheContact1", "FicheContact")]
        public EntityCollection<FicheContact> FicheContact_1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheContact>("SYSGDIIModel.TelephoneFicheContact1", "FicheContact");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheContact>("SYSGDIIModel.TelephoneFicheContact1", "FicheContact", value);
                }
            }
        }

        #endregion
    }
}
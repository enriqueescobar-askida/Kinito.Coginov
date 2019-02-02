namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="PeriodeReference")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class PeriodeReference : Pilotage
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PeriodeReference object.
        /// </summary>
        /// <param name="pilotageID">Initial value of the PilotageID property.</param>
        /// <param name="nom">Initial value of the nom property.</param>
        public static PeriodeReference CreatePeriodeReference(global::System.Int32 pilotageID, global::System.String nom)
        {
            PeriodeReference periodeReference = new PeriodeReference();
            periodeReference.PilotageID = pilotageID;
            periodeReference.nom = nom;
            return periodeReference;
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "PeriodeReferenceFicheEmployeur", "FicheEmployeur")]
        public EntityCollection<FicheEmployeur> FicheEmployeur
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheEmployeur>("SYSGDIIModel.PeriodeReferenceFicheEmployeur", "FicheEmployeur");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheEmployeur>("SYSGDIIModel.PeriodeReferenceFicheEmployeur", "FicheEmployeur", value);
                }
            }
        }

        #endregion
    }
}
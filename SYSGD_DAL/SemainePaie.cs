namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="SemainePaie")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class SemainePaie : Pilotage
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SemainePaie object.
        /// </summary>
        /// <param name="pilotageID">Initial value of the PilotageID property.</param>
        /// <param name="nom">Initial value of the nom property.</param>
        public static SemainePaie CreateSemainePaie(global::System.Int32 pilotageID, global::System.String nom)
        {
            SemainePaie semainePaie = new SemainePaie();
            semainePaie.PilotageID = pilotageID;
            semainePaie.nom = nom;
            return semainePaie;
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "SemainePaieFicheEmployeur", "FicheEmployeur")]
        public EntityCollection<FicheEmployeur> FicheEmployeur
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheEmployeur>("SYSGDIIModel.SemainePaieFicheEmployeur", "FicheEmployeur");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheEmployeur>("SYSGDIIModel.SemainePaieFicheEmployeur", "FicheEmployeur", value);
                }
            }
        }

        #endregion
    }
}
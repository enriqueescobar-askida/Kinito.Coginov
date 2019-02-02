namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Sexe")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Sexe : Pilotage
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Sexe object.
        /// </summary>
        /// <param name="pilotageID">Initial value of the PilotageID property.</param>
        /// <param name="nom">Initial value of the nom property.</param>
        public static Sexe CreateSexe(global::System.Int32 pilotageID, global::System.String nom)
        {
            Sexe sexe = new Sexe();
            sexe.PilotageID = pilotageID;
            sexe.nom = nom;
            return sexe;
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
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "SexeFicheSalarie", "FicheSalarie")]
        public EntityCollection<FicheSalarie> FicheSalarie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FicheSalarie>("SYSGDIIModel.SexeFicheSalarie", "FicheSalarie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FicheSalarie>("SYSGDIIModel.SexeFicheSalarie", "FicheSalarie", value);
                }
            }
        }

        #endregion
    }
}
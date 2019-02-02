namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="NatureEntreprises")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class NatureEntreprises : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new NatureEntreprises object.
        /// </summary>
        /// <param name="natureEntrepriseID">Initial value of the NatureEntrepriseID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        public static NatureEntreprises CreateNatureEntreprises(global::System.Int32 natureEntrepriseID, global::System.String nom)
        {
            NatureEntreprises natureEntreprises = new NatureEntreprises();
            natureEntreprises.NatureEntrepriseID = natureEntrepriseID;
            natureEntreprises.Nom = nom;
            return natureEntreprises;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 NatureEntrepriseID
        {
            get
            {
                return this._NatureEntrepriseID;
            }
            set
            {
                if (this._NatureEntrepriseID != value)
                {
                    this.OnNatureEntrepriseIDChanging(value);
                    this.ReportPropertyChanging("NatureEntrepriseID");
                    this._NatureEntrepriseID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("NatureEntrepriseID");
                    this.OnNatureEntrepriseIDChanged();
                }
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
    
    }
}
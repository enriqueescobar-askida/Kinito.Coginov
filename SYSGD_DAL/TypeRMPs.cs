namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="TypeRMPs")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class TypeRMPs : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TypeRMPs object.
        /// </summary>
        /// <param name="typeRMPID">Initial value of the TypeRMPID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        public static TypeRMPs CreateTypeRMPs(global::System.Int32 typeRMPID, global::System.String nom)
        {
            TypeRMPs typeRMPs = new TypeRMPs();
            typeRMPs.TypeRMPID = typeRMPID;
            typeRMPs.Nom = nom;
            return typeRMPs;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 TypeRMPID
        {
            get
            {
                return this._TypeRMPID;
            }
            set
            {
                if (this._TypeRMPID != value)
                {
                    this.OnTypeRMPIDChanging(value);
                    this.ReportPropertyChanging("TypeRMPID");
                    this._TypeRMPID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("TypeRMPID");
                    this.OnTypeRMPIDChanged();
                }
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
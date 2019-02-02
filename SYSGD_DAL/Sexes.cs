namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Sexes")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Sexes : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Sexes object.
        /// </summary>
        /// <param name="sexeID">Initial value of the SexeID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        public static Sexes CreateSexes(global::System.Int32 sexeID, global::System.String nom)
        {
            Sexes sexes = new Sexes();
            sexes.SexeID = sexeID;
            sexes.Nom = nom;
            return sexes;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SexeID
        {
            get
            {
                return this._SexeID;
            }
            set
            {
                if (this._SexeID != value)
                {
                    this.OnSexeIDChanging(value);
                    this.ReportPropertyChanging("SexeID");
                    this._SexeID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("SexeID");
                    this.OnSexeIDChanged();
                }
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
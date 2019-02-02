namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Langues")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Langues : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Langues object.
        /// </summary>
        /// <param name="langueID">Initial value of the LangueID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        public static Langues CreateLangues(global::System.Int32 langueID, global::System.String nom)
        {
            Langues langues = new Langues();
            langues.LangueID = langueID;
            langues.Nom = nom;
            return langues;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 LangueID
        {
            get
            {
                return this._LangueID;
            }
            set
            {
                if (this._LangueID != value)
                {
                    this.OnLangueIDChanging(value);
                    this.ReportPropertyChanging("LangueID");
                    this._LangueID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("LangueID");
                    this.OnLangueIDChanged();
                }
            }
        }
        private global::System.Int32 _LangueID;
        partial void OnLangueIDChanging(global::System.Int32 value);
        partial void OnLangueIDChanged();
    
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
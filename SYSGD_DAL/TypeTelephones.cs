namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="TypeTelephones")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class TypeTelephones : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TypeTelephones object.
        /// </summary>
        /// <param name="typeTelephoneID">Initial value of the TypeTelephoneID property.</param>
        /// <param name="qualifiant">Initial value of the Qualifiant property.</param>
        public static TypeTelephones CreateTypeTelephones(global::System.Int32 typeTelephoneID, global::System.String qualifiant)
        {
            TypeTelephones typeTelephones = new TypeTelephones();
            typeTelephones.TypeTelephoneID = typeTelephoneID;
            typeTelephones.Qualifiant = qualifiant;
            return typeTelephones;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 TypeTelephoneID
        {
            get
            {
                return this._TypeTelephoneID;
            }
            set
            {
                if (this._TypeTelephoneID != value)
                {
                    this.OnTypeTelephoneIDChanging(value);
                    this.ReportPropertyChanging("TypeTelephoneID");
                    this._TypeTelephoneID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("TypeTelephoneID");
                    this.OnTypeTelephoneIDChanged();
                }
            }
        }
        private global::System.Int32 _TypeTelephoneID;
        partial void OnTypeTelephoneIDChanging(global::System.Int32 value);
        partial void OnTypeTelephoneIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Qualifiant
        {
            get
            {
                return this._Qualifiant;
            }
            set
            {
                this.OnQualifiantChanging(value);
                this.ReportPropertyChanging("Qualifiant");
                this._Qualifiant = StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Qualifiant");
                this.OnQualifiantChanged();
            }
        }
        private global::System.String _Qualifiant;
        partial void OnQualifiantChanging(global::System.String value);
        partial void OnQualifiantChanged();

        #endregion
    
    }
}
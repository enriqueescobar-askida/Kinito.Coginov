namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="PeriodeReferences")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class PeriodeReferences : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PeriodeReferences object.
        /// </summary>
        /// <param name="periodeReferenceID">Initial value of the PeriodeReferenceID property.</param>
        public static PeriodeReferences CreatePeriodeReferences(global::System.Int32 periodeReferenceID)
        {
            PeriodeReferences periodeReferences = new PeriodeReferences();
            periodeReferences.PeriodeReferenceID = periodeReferenceID;
            return periodeReferences;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 PeriodeReferenceID
        {
            get
            {
                return this._PeriodeReferenceID;
            }
            set
            {
                if (this._PeriodeReferenceID != value)
                {
                    this.OnPeriodeReferenceIDChanging(value);
                    this.ReportPropertyChanging("PeriodeReferenceID");
                    this._PeriodeReferenceID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("PeriodeReferenceID");
                    this.OnPeriodeReferenceIDChanged();
                }
            }
        }
        private global::System.Int32 _PeriodeReferenceID;
        partial void OnPeriodeReferenceIDChanging(global::System.Int32 value);
        partial void OnPeriodeReferenceIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this.ReportPropertyChanging("Description");
                this._Description = StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Description");
                this.OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion
    
    }
}
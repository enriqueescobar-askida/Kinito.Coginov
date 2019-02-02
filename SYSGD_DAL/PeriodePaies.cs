namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="PeriodePaies")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class PeriodePaies : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PeriodePaies object.
        /// </summary>
        /// <param name="periodePaieID">Initial value of the PeriodePaieID property.</param>
        public static PeriodePaies CreatePeriodePaies(global::System.Int32 periodePaieID)
        {
            PeriodePaies periodePaies = new PeriodePaies();
            periodePaies.PeriodePaieID = periodePaieID;
            return periodePaies;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 PeriodePaieID
        {
            get
            {
                return this._PeriodePaieID;
            }
            set
            {
                if (this._PeriodePaieID != value)
                {
                    this.OnPeriodePaieIDChanging(value);
                    this.ReportPropertyChanging("PeriodePaieID");
                    this._PeriodePaieID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("PeriodePaieID");
                    this.OnPeriodePaieIDChanged();
                }
            }
        }
        private global::System.Int32 _PeriodePaieID;
        partial void OnPeriodePaieIDChanging(global::System.Int32 value);
        partial void OnPeriodePaieIDChanged();
    
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
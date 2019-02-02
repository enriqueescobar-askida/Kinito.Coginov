namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="SemainePaies")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class SemainePaies : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SemainePaies object.
        /// </summary>
        /// <param name="semainePaieID">Initial value of the SemainePaieID property.</param>
        public static SemainePaies CreateSemainePaies(global::System.Int32 semainePaieID)
        {
            SemainePaies semainePaies = new SemainePaies();
            semainePaies.SemainePaieID = semainePaieID;
            return semainePaies;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SemainePaieID
        {
            get
            {
                return this._SemainePaieID;
            }
            set
            {
                if (this._SemainePaieID != value)
                {
                    this.OnSemainePaieIDChanging(value);
                    this.ReportPropertyChanging("SemainePaieID");
                    this._SemainePaieID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("SemainePaieID");
                    this.OnSemainePaieIDChanged();
                }
            }
        }
        private global::System.Int32 _SemainePaieID;
        partial void OnSemainePaieIDChanging(global::System.Int32 value);
        partial void OnSemainePaieIDChanged();
    
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
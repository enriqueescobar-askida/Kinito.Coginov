namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Pilotage")]
    [Serializable()]
    [DataContract(IsReference=true)]
    [KnownType(typeof(Telephone))]
    [KnownType(typeof(TypeRMP))]
    [KnownType(typeof(PeriodeReference))]
    [KnownType(typeof(PeriodePaie))]
    [KnownType(typeof(NatureEntreprise))]
    [KnownType(typeof(Langue))]
    [KnownType(typeof(AssociationPatronale))]
    [KnownType(typeof(SemainePaie))]
    [KnownType(typeof(Sexe))]
    public abstract partial class Pilotage : CoginovEntityObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 PilotageID
        {
            get
            {
                return this._PilotageID;
            }
            set
            {
                if (this._PilotageID != value)
                {
                    this.OnPilotageIDChanging(value);
                    this.ReportPropertyChanging("PilotageID");
                    this._PilotageID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("PilotageID");
                    this.OnPilotageIDChanged();
                }
            }
        }
        private global::System.Int32 _PilotageID;
        partial void OnPilotageIDChanging(global::System.Int32 value);
        partial void OnPilotageIDChanged();

        #endregion
    
    }
}
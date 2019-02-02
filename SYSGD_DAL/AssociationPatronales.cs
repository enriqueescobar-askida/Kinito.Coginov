namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="AssociationPatronales")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class AssociationPatronales : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AssociationPatronales object.
        /// </summary>
        /// <param name="associationPatronaleID">Initial value of the AssociationPatronaleID property.</param>
        /// <param name="nom">Initial value of the Nom property.</param>
        public static AssociationPatronales CreateAssociationPatronales(global::System.Int32 associationPatronaleID, global::System.String nom)
        {
            AssociationPatronales associationPatronales = new AssociationPatronales();
            associationPatronales.AssociationPatronaleID = associationPatronaleID;
            associationPatronales.Nom = nom;
            return associationPatronales;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AssociationPatronaleID
        {
            get
            {
                return this._AssociationPatronaleID;
            }
            set
            {
                if (this._AssociationPatronaleID != value)
                {
                    this.OnAssociationPatronaleIDChanging(value);
                    this.ReportPropertyChanging("AssociationPatronaleID");
                    this._AssociationPatronaleID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("AssociationPatronaleID");
                    this.OnAssociationPatronaleIDChanged();
                }
            }
        }
        private global::System.Int32 _AssociationPatronaleID;
        partial void OnAssociationPatronaleIDChanging(global::System.Int32 value);
        partial void OnAssociationPatronaleIDChanged();
    
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
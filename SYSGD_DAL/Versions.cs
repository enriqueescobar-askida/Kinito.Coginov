namespace SYSGD_DAL
{
    using System;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Versions")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Versions : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Versions object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Versions CreateVersions(global::System.Int32 id)
        {
            Versions versions = new Versions();
            versions.Id = id;
            return versions;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.OnIdChanging(value);
                    this.ReportPropertyChanging("Id");
                    this._Id = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
    }
}
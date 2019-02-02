namespace SYSGD_DAL
{
    using System;
    using System.ComponentModel;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="SYSGDIIModel", Name="Episode")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Episode : CoginovEntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Episode object.
        /// </summary>
        /// <param name="episodeID">Initial value of the EpisodeID property.</param>
        /// <param name="salarieID">Initial value of the SalarieID property.</param>
        /// <param name="dateDebut">Initial value of the DateDebut property.</param>
        /// <param name="dateFin">Initial value of the DateFin property.</param>
        /// <param name="dateUpdate">Initial value of the DateUpdate property.</param>
        /// <param name="auteurUpdate">Initial value of the AuteurUpdate property.</param>
        /// <param name="dateInsert">Initial value of the DateInsert property.</param>
        /// <param name="auteurInsert">Initial value of the AuteurInsert property.</param>
        public static Episode CreateEpisode(global::System.Int32 episodeID, global::System.Int32 salarieID, global::System.DateTime dateDebut, global::System.DateTime dateFin, global::System.DateTime dateUpdate, global::System.Int32 auteurUpdate, global::System.DateTime dateInsert, global::System.Int32 auteurInsert)
        {
            Episode episode = new Episode();
            episode.EpisodeID = episodeID;
            episode.SalarieID = salarieID;
            episode.DateDebut = dateDebut;
            episode.DateFin = dateFin;
            episode.DateUpdate = dateUpdate;
            episode.AuteurUpdate = auteurUpdate;
            episode.DateInsert = dateInsert;
            episode.AuteurInsert = auteurInsert;
            return episode;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 EpisodeID
        {
            get
            {
                return this._EpisodeID;
            }
            set
            {
                if (this._EpisodeID != value)
                {
                    this.OnEpisodeIDChanging(value);
                    this.ReportPropertyChanging("EpisodeID");
                    this._EpisodeID = StructuralObject.SetValidValue(value);
                    this.ReportPropertyChanged("EpisodeID");
                    this.OnEpisodeIDChanged();
                }
            }
        }
        private global::System.Int32 _EpisodeID;
        partial void OnEpisodeIDChanging(global::System.Int32 value);
        partial void OnEpisodeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 SalarieID
        {
            get
            {
                return this._SalarieID;
            }
            set
            {
                this.OnSalarieIDChanging(value);
                this.ReportPropertyChanging("SalarieID");
                this._SalarieID = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SalarieID");
                this.OnSalarieIDChanged();
            }
        }
        private global::System.Int32 _SalarieID;
        partial void OnSalarieIDChanging(global::System.Int32 value);
        partial void OnSalarieIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DateDebut
        {
            get
            {
                return this._DateDebut;
            }
            set
            {
                this.OnDateDebutChanging(value);
                this.ReportPropertyChanging("DateDebut");
                this._DateDebut = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateDebut");
                this.OnDateDebutChanged();
            }
        }
        private global::System.DateTime _DateDebut;
        partial void OnDateDebutChanging(global::System.DateTime value);
        partial void OnDateDebutChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DateFin
        {
            get
            {
                return this._DateFin;
            }
            set
            {
                this.OnDateFinChanging(value);
                this.ReportPropertyChanging("DateFin");
                this._DateFin = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateFin");
                this.OnDateFinChanged();
            }
        }
        private global::System.DateTime _DateFin;
        partial void OnDateFinChanging(global::System.DateTime value);
        partial void OnDateFinChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DateUpdate
        {
            get
            {
                return this._DateUpdate;
            }
            set
            {
                this.OnDateUpdateChanging(value);
                this.ReportPropertyChanging("DateUpdate");
                this._DateUpdate = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateUpdate");
                this.OnDateUpdateChanged();
            }
        }
        private global::System.DateTime _DateUpdate;
        partial void OnDateUpdateChanging(global::System.DateTime value);
        partial void OnDateUpdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AuteurUpdate
        {
            get
            {
                return this._AuteurUpdate;
            }
            set
            {
                this.OnAuteurUpdateChanging(value);
                this.ReportPropertyChanging("AuteurUpdate");
                this._AuteurUpdate = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AuteurUpdate");
                this.OnAuteurUpdateChanged();
            }
        }
        private global::System.Int32 _AuteurUpdate;
        partial void OnAuteurUpdateChanging(global::System.Int32 value);
        partial void OnAuteurUpdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime DateInsert
        {
            get
            {
                return this._DateInsert;
            }
            set
            {
                this.OnDateInsertChanging(value);
                this.ReportPropertyChanging("DateInsert");
                this._DateInsert = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("DateInsert");
                this.OnDateInsertChanged();
            }
        }
        private global::System.DateTime _DateInsert;
        partial void OnDateInsertChanging(global::System.DateTime value);
        partial void OnDateInsertChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 AuteurInsert
        {
            get
            {
                return this._AuteurInsert;
            }
            set
            {
                this.OnAuteurInsertChanging(value);
                this.ReportPropertyChanging("AuteurInsert");
                this._AuteurInsert = StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("AuteurInsert");
                this.OnAuteurInsertChanged();
            }
        }
        private global::System.Int32 _AuteurInsert;
        partial void OnAuteurInsertChanging(global::System.Int32 value);
        partial void OnAuteurInsertChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("SYSGDIIModel", "FK_SalarieEpisode", "Salarie")]
        public Salarie Salarie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieEpisode", "Salarie").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieEpisode", "Salarie").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Salarie> SalarieReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieEpisode", "Salarie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Salarie>("SYSGDIIModel.FK_SalarieEpisode", "Salarie", value);
                }
            }
        }

        #endregion
    }
}
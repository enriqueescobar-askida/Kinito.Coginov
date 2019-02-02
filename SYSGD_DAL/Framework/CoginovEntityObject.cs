namespace SYSGD_DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.Text;

    [Serializable]
    public abstract class CoginovEntityObject : EntityObject
    {

        #region Membres protected
            // Dictionnaire contenant les erreurs de validation
            protected Dictionary<string, string> ValErr = new Dictionary<string, string>();

            // Valeur du checksum lors de l'instanciation
            protected string _OriginalCheckSumValue { get; set; }

            // Valeur du checksum avant la sauvegarde
            protected string _OldCheckSum { get; set; }
            
            // Affecte le comportement de la methode Delete().
            protected bool _CanDelete = false;
            
        #endregion

        #region membres publiques


        #endregion
    
        #region Membres Abstraits 
            protected virtual bool Validate() { return true; }
        #endregion

        #region Methodes protected
            /// <summary>
            /// Indique s'il y a conflit de concurence a la bd
            /// </summary>
            /// <param name="org"></param>
            /// <param name="old"></param>
            /// <returns></returns>
            protected bool CheckConcurrency(string org, string old)
            {
                if ((old != null) && (old != org))
                    return false;
                else
                    return true;
            }

            protected bool CheckConcurrency()
            {
                if ((_OldCheckSum != null) && (_OldCheckSum != _OriginalCheckSumValue))
                    return false;
                else
                    return true;
            }

       #endregion


       #region methodes publiques

            /// <summary>
            /// Initialise la valeur du checksum au départ.
            /// </summary>
            /// <param name="val"></param>
            public void SetOriginalCheckSumValue(string val)
            {
                _OriginalCheckSumValue = val;
            }
            
            /// <summary>
            /// Accepte le checksum précédent pour fin de comparaison
            /// </summary>
            /// <param name="val"></param>
            public void SetOldCheckSumValue(string val)
            {
                _OldCheckSum = val;
            }
            
            /// <summary>
            /// Expose le checksum initial de l'objet
            /// </summary>
            /// <returns></returns>
            public string GetOriginalCheckSumValue()
                { return _OriginalCheckSumValue; }


            /// <summary>
            /// Applique les règles de validation et sauvegarde
              /// </summary>
            /// <returns>lValide</returns>
            public bool Save()
            {
                ClearValErr();
                if (CheckConcurrency(_OriginalCheckSumValue, _OldCheckSum))
                {
                    if (Validate())
                    {
                        return true;
                    }
                    else
                        return false;
                
                }
                else
                {
                    AddValErr("GENERAL", "Conflit au niveau de la BD.");
                    return false;
                }

            }

            
            public bool Delete()
            {
                return this._CanDelete;
            }




            /// <summary>
            /// Retourne le message d'erreur pour un controle donné.
            /// </summary>
            /// <param name="ctrlKey"></param>
            /// <returns></returns>
            public string GetErrorMessage(string ctrlKey)
            {
                if (ValErr.ContainsKey(ctrlKey))
                    return ValErr[ctrlKey];
                else
                    return "";

            }

            
            /// <summary>
            /// Réinitialise la liste de validation.
            /// </summary>
            protected void ClearValErr() 
            {
                ValErr.Clear();
            }

            protected void AddValErr(string ctrlKey, string Message)
            {
                string m1 = GetErrorMessage(ctrlKey);
                if (m1 == "")
                    this.ValErr.Add(ctrlKey, Message);
                else 
                {
                    if (!m1.ToUpper().Contains(Message))
                    {
                        this.ValErr[ctrlKey] = m1 + "<br/>" + Message;
                    }
                }
            }

       #endregion
    }
}

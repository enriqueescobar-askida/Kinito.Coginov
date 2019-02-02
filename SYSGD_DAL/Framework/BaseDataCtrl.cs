// 
// Coginov® - http://www.coginov.com
// Copyright (c) 2011
// par Coginov inc
// 
// Ce code est la propriété exclusive de Coginov inc. 
// 
// Classe abstraite servant de base pour les classes de la DAL
// représentant des objets de type DataController.
//----------------------------------------------------------------------------------------

namespace SYSGD_DAL.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security.Cryptography;

    public abstract class BaseDataCtrl<T> 
    {
        #region Private/protected members 
            
           private SYSGDIIEntities _context;
           
           protected SYSGDIIEntities  context
           {
                get
                {
                    if (_context == null)
                    {
                        _context = new SYSGDIIEntities();
                        _context.SavingChanges += new EventHandler(context_SavingChanges);
                    }
                    return _context;
                }
           }

        #endregion
        
        #region Public members 
        
            public string errorMessage { get; set; }  

        #endregion      
    
        #region Abstract Methods

            /// <summary>
            /// Retourne une liste d'objets de type T
            /// </summary>
            /// <returns></returns>
            public abstract List<T> Select();

            /// <summary>
            /// Retourne un objet de type T correspondant 
            /// à la clé qui lui est passée.
            /// </summary>
            /// <param name="id">Cle primaire de l'objet a retourner</param>
            /// <returns></returns>
            public abstract T Select(int id);
        
            /// <summary>
            /// Retourne un objet vide initialisé avec les valeurs par defaut.
            /// </summary>
            /// <returns></returns>
            public abstract T Create();


        #endregion


        #region Public Methods

            /// <summary>
            /// Coordonne la sauvegarde de l'objet entitaire (BO) qui lui
            /// est passé en argument.
            /// </summary>
            /// <param name="ef">Objet entitaire (BO)</param>
            /// <returns>lRéussite</returns>
            public bool Save(CoginovEntityObject ef)
            {
                if (ef.Save())
                   return this.save();
                else
                    return false;
           }

            /// <summary>
            /// Coordonnateur de la suppression 
            /// </summary>
            /// <param name="ef"></param>
            /// <returns></returns>
            public bool Delete(CoginovEntityObject ef)
            {
                if (ef.Delete())
                   return this.delete(ef);
                else
                    return false;
            
            }

            
            /// <summary>
            /// Calcule le checksum de l'objet entitaire data. Ce string
            /// permet de determiner si deux objets sont identiques.
            /// </summary>
            /// <returns>Checksum</returns>
            public string GetChecksum(EntityObject eo)
            {
                if (eo == null)
                    return "";
                else
                { 
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, eo);

                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(ms.ToArray());

                return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }
            }



        #endregion


        #region Private methods


            /// <summary>
            /// Evenement appelé lors de la sauvegarde à la bd.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void context_SavingChanges(object sender, EventArgs e)
            {
                ObjectContext context = sender as ObjectContext;
                if (context != null)
                {
                    foreach (ObjectStateEntry entry in context.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Modified))
                    {
                        // Implante le mode de sauvegarde transactionnel sur les objets contenant la string .Fiche....
                        if (entry.Entity.GetType().ToString().ToUpper().Contains(".FICHE"))
                        {
                            context.ObjectStateManager.ChangeObjectState(entry.Entity, System.Data.EntityState.Added);
                        }
                    }
                }
            }
        
            /// <summary>
            /// Primitive chargé de la sauvegarde.
            /// </summary>
            /// <returns>lRéussite</returns>
            protected bool save()
            {
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (Exception exc)
                {
                    this.errorMessage = exc.Message;
                    //TODO: Ajouter un message au journal d'evenement.
                    return false;
                }
            }

            /// <summary>
            /// Primitive chargé de la suppression
            /// </summary>
            /// <param name="ef">Objet a supprimer</param>
            /// <returns>lRéussite</returns>
            protected bool delete(CoginovEntityObject ef)
            {
                try
                {
                    context.DeleteObject(ef);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception exc)
                {
                    this.errorMessage = exc.Message;
                    //TODO: Ajouter un message au journal d'evenement.
                    return false;
                }
            
            
            }


        #endregion


        #region Common Functions

            /// <summary>
            /// Service servant à determiner la préexistance d'un
            /// objet dans la bd.
            /// </summary>
            /// <param name="tableName">Nom de la table</param>
            /// <param name="fieldName">Nom de la colonne</param>
            /// <param name="fieldNameId"></param>
            /// <param name="value"></param>
            /// <param name="id"></param>
            /// <returns></returns>
            protected bool IsDuplicate(string tableName, string fieldName,
                string fieldNameId, string value, int id)
            {
                
                string sql =
                    "SELECT COUNT(" + fieldNameId + ") AS DuplicateCount " +
                      "FROM " + tableName +
                    " WHERE " + fieldName + " = {0}" +
                      " AND " + fieldNameId + " <> {1}";

                var result = context.ExecuteStoreQuery<DuplicateCheck>(sql, new object[] { value, id });
                List<DuplicateCheck> list = result.ToList();
                return (list[0].DuplicateCount > 0);
                
            }

            protected bool IsDuplicate( string tableName, string fieldName,
                string fieldNameId, DateTime value, int id)
            {

                string sql =
                    "SELECT COUNT(" + fieldNameId + ") AS DuplicateCount " +
                      "FROM " + tableName +
                    " WHERE " + fieldName + " = {0}" +
                      " AND " + fieldNameId + " <> {1}";

                var result = context.ExecuteStoreQuery<DuplicateCheck>(sql, new object[] { value, id });
                List<DuplicateCheck> list = result.ToList();

                return (list[0].DuplicateCount > 0);
            }

        #endregion Common Functions

    }

   
}
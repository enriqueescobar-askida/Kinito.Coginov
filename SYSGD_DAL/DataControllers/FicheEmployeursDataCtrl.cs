namespace SYSGD_DAL
{
    using System.Collections.Generic;
    using System.Linq;

    using SYSGD_DAL.Framework;

    public class FicheEmployeursDataCtrl : BaseDataCtrl<FicheEmployeur>
    {
        #region override abstract methods
        public override List<FicheEmployeur> Select()
        {
            var myList = this.context.FicheEmployeurSet.Include("Employeur").ToList();
            foreach (FicheEmployeur fe in myList)
            {
                fe.SetOriginalCheckSumValue(this.GetChecksum(fe));
            }
            return myList;
        }
        public override FicheEmployeur Select(int id)
        {
            var myFE = this.context.FicheEmployeurSet.Where(a => a.FicheEmployeurID.Equals(id)).FirstOrDefault();
            myFE.SetOriginalCheckSumValue(this.GetChecksum(myFE));
            return myFE;
        }
        public override FicheEmployeur Create()
        {
            var myFE = new FicheEmployeur();
            myFE.SetOriginalCheckSumValue(this.GetChecksum(myFE));
            return myFE;
        }
        #endregion
        /// <summary>
        /// Selects the specified a chercher.
        /// </summary>
        /// <param name="aChercher">A chercher.</param>
        /// <returns></returns>
        public IEnumerable<FicheEmployeur> Select(string aChercher)
        {
            IEnumerable<FicheEmployeur> ficheEmployeurs = (from fe in this.context.FicheEmployeurSet
                                                           where fe.RaisonSociale1.Contains(aChercher)
                                                                 || fe.RaisonSocialeAbregee.Contains(aChercher)
                                                                 || fe.NoEmployeur.Contains(aChercher)
                                                           select fe).OrderBy(a => a.RaisonSociale1).Take(10);
            return ficheEmployeurs;
        }
    }
}
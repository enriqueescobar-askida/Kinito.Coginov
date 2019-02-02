// 
// Coginov® - http://www.coginov.com
// Copyright (c) 2011
// par Coginov inc
// 
// Ce code est la propriété exclusive de Coginov inc. 
// 
// Implantation concrète d'un DataContrller à partir de la 
// classe abstraite BaseData.
//----------------------------------------------------------------------------------------

namespace SYSGD_DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using SYSGD_DAL.Framework;

    public class EmployeursDataCtrl : BaseDataCtrl<Employeur>
    {
       #region override abstract methods
        public override List<Employeur> Select()
        {
            var myList =  context.EmployeurSet.Include("FicheEmployeurs").ToList();

            foreach ( Employeur ef in myList)
            {
                //ef.context = this.context;
                ef.SetOriginalCheckSumValue( this.GetChecksum(ef));
            }
            return myList;
        }

        public override Employeur Select(int id)
        {
            var myEF = context.EmployeurSet.Where(a => a.EmployeurID.Equals(id)).FirstOrDefault();
            // myEF.context = this.context;
            myEF.SetOriginalCheckSumValue( this.GetChecksum(myEF));
            return myEF;
        }

        public override Employeur Create()
        {       
            var myEF = new Employeur();
            // myEF.context = this.context;
            // Ajouter ici les valeurs par defaut
            myEF.SetOriginalCheckSumValue(this.GetChecksum(myEF));
        
            return myEF;
        }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    public class ContactsDataCtrl : BaseDataCtrl<Contact>
    {
        #region override abstract methods

        public override List<Contact> Select()
        {
            var myList = context.ContactSet.ToList();

            foreach (Contact ef in myList)
            {
                ef.SetOriginalCheckSumValue(this.GetChecksum(ef));
            }
            return myList;
        }

        public override Contact Select(int id)
        {
            var myEF = context.ContactSet.Where(a => a.ContactID.Equals(id)).FirstOrDefault();
            // myEF.context = this.context;
            myEF.SetOriginalCheckSumValue(this.GetChecksum(myEF));
            return myEF;
        }

        public override Contact Create()
        {

            var myEF = new Contact();
  
            // Ajouter ici les valeurs par defaut
            myEF.SetOriginalCheckSumValue(this.GetChecksum(myEF));

            return myEF;
        }

        #endregion
    }
}

// 
// Coginov® - http://www.coginov.com
// Copyright (c) 2011
// par Coginov inc
// 
// Ce code est la propriété exclusive de Coginov inc. 
// 
// Contient les extensions des objets entitaires afin de les transformer en
// objet d'affaires.
//----------------------------------------------------------------------------------------


namespace SYSGD_DAL
{
    public partial class Employeur
    {

        /// <summary>
        /// Constructeur utilisé pour définir les
        /// parametres et le comportement général de l'objet.
        /// </summary>
        public Employeur()
        {
            this._CanDelete = false;
        }



        /// <summary>
        /// Ajouter ici le code pour l'implantation des regles de validation
        /// et les regles d'affaire.
        /// </summary>
        protected override bool Validate()
        {
            // Mettre ici le code de validation de l'objet.
            return (this.ValErr.Count == 0);
        }

    }
}

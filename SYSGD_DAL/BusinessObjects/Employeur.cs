// 
// Coginov� - http://www.coginov.com
// Copyright (c) 2011
// par Coginov inc
// 
// Ce code est la propri�t� exclusive de Coginov inc. 
// 
// Contient les extensions des objets entitaires afin de les transformer en
// objet d'affaires.
//----------------------------------------------------------------------------------------


namespace SYSGD_DAL
{
    public partial class Employeur
    {

        /// <summary>
        /// Constructeur utilis� pour d�finir les
        /// parametres et le comportement g�n�ral de l'objet.
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

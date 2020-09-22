using System;
using System.Collections.Generic;
using System.Text;

namespace Exo4.models
{

    public enum typeArticles
    {
        Droguerie,
        alimentaire,
        equipement,
        habillement,
        loisir

    }
    struct Article
    {
        public string nom { get; set; }
        public float prix { get; set; }

        public float quantite { get; set; }

        public typeArticles typeArticle;

        public Article(string nom, float prix, float quantite, typeArticles typeArticle)
        {
            this.typeArticle=typeArticle;
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;

        }



        public void Afficher()
        {
            Console.WriteLine($" Article : \n type : {typeArticle} \n nom {nom} \n prix {prix}\n quantite {quantite} \n");
        }

        /// <summary>
        /// Non utilisée
        /// TODO : A utiliser et à completer/modifier
        /// </summary>
        /// <returns></returns>
        private int SaisieUtilisateur()
        {
            Console.WriteLine("Quelle somme voulez vous retirer ? ");
            string saisie = Console.ReadLine();
            int valeur = Convert.ToInt32(saisie);

            return valeur;
        }
        public void Ajouter() 
        {
            try
            {
                Console.WriteLine("Quelle quantite voulez vous ajouter ? ");
                string saisie = Console.ReadLine();
                int valeur = Convert.ToInt32(saisie);

                if(valeur>0)
                {
                    this.quantite = this.quantite + Convert.ToSingle(valeur);
                }
                else
                {
                    Console.WriteLine("On ne peut ajouter cette valeur :/ elle est négative ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Il y a eu une erreur :/ \n {ex.ToString()}");
            };
           
        }
        /// <summary>
        /// classe  pour retirer de la quantitée
        /// TODO: Factoriser dans nv methode private la saisie utilisateur
        /// </summary>
        public void Retirer()
        {
            Console.WriteLine("Quelle somme voulez vous retirer ? ");
            string saisie = Console.ReadLine();
            int valeur = Convert.ToInt32(saisie);

            if (valeur > 0)
            {
                //si la saisie est positive
                this.quantite = quantite - valeur;
            }
            else
            {   // si la saisie est négative
                this.quantite = quantite + valeur;
            }
        }
    }
}

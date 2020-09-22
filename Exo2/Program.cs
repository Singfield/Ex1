using System;
using Exo2.models;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article("Article1",2f, 3f);

            article.Afficher();
            article.Ajouter();
            article.Afficher();
            article.Retirer();
            article.Afficher();
        }
    }
}

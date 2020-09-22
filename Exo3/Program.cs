using System;
using Exo3.models;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article("Article1", 2f, 3f, typeArticles.Droguerie);

            article.Afficher();
        }
    }
}

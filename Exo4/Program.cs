using System;
using Exo4.models;
namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article("Article1", 2f, 3f, typeArticles.Droguerie);
            Article article2 = new Article("Article2", 2f, 3f, typeArticles.Droguerie);

            ListArticles list = new ListArticles();

            list.addArticle(article);
            list.addArticle(article2);
            list.afficher();
            article.Afficher();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Exo4.models;

namespace Exo4
{
    class ListArticles
    {
        public List<Article> lArticle { get; set; }

        public ListArticles()
        {
            this.lArticle=new List<Article>();
        }

        public void addArticle(Article article)
        {
            this.lArticle.Add(article);
        }
        
        public void afficher()
        {
            Console.WriteLine("=========Tableau d'articles : ============= \n ");
            for (int i=0; i< this.lArticle.Count; i++)
            {
                Console.WriteLine($"{lArticle[i].nom}");
            }
            Console.WriteLine("=========FIN Tableau d'articles ============= \n ");
        }
    
    }


}

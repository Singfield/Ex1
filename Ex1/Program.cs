using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article("Ceci est un article", 1.2f);
            article.Acheter();

            Disque disque = new Disque(article.designation, article.prix, "label");
            disque.Ecouter();

            Livre livre = new Livre(article.designation, article.prix,100, 500);
            Console.WriteLine($" livre isbn {livre.isbn} livre nbpage {livre.nbPages}");

            Video video = new Video(100,article.designation, article.prix);

            video.Afficher();
        }
    }
}

using System;


namespace Ex1
{
    class Article
    {
        public string designation { get; set; }
        public float prix { get; set; }

        public Article(string designation, float prix)
        {
            this.designation = designation;
            this.prix = prix;
        }
        public void Acheter()
        {
            Console.WriteLine(designation + prix);
        }
    }
}


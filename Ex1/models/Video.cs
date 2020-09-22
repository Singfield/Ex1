using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Video : Article
    {
        public float Duree { get; set; }

        public Video(float Duree, string designation, float prix):base(designation, prix)
        {
            this.Duree = Duree;
        }
        public float Afficher() 
        {
            Console.WriteLine($"{Duree}");
            return Duree;
        }
    }
}

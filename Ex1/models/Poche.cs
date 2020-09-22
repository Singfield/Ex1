using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Poche : Livre
    {
        public string categorie { get; set; }

        public Poche(string designation, float prix, string categorie, int isbn, int nbPages) : base(designation, prix,isbn, nbPages)
        {
            this.categorie = categorie;
        }
    }
}

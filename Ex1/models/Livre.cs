using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
 

    class Livre : Article
    {

        public int isbn { get; set; }
        public int nbPages { get; set; }

        public Livre(string designation, float prix, int isbn, int nbPages) : base(designation, (float)prix)
        {
            this.isbn = isbn;
            this.nbPages = nbPages;
        }
    }
}

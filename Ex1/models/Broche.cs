using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Broche: Livre
    {
        public Broche(string designation, float prix, int isbn, int nbPages) : base(designation, prix, isbn, nbPages)
        {
           
        }
    }
}

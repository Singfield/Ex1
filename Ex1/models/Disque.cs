using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Disque : Article
    {
        public string label { get; set; }

        public Disque(string designation, float prix, string label) : base(designation, (float)prix)
        {
            this.label = label;
        }
        public string Ecouter() {
            Console.WriteLine($"{label}");
            return label;
        }
    }
}

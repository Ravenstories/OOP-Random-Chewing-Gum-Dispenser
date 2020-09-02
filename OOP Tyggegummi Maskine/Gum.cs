using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tyggegummi_Maskine
{
    class Gum
    {
        private string colour;
        private string flavour;
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Flavour
        {
            get { return flavour; }
            set { flavour = value; }
        }

        public Gum(string Colour, string Flavour)
        {
            this.colour = Colour;
            this.flavour = Flavour;
        }

        

    }
}

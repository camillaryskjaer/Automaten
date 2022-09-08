using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Machine.Products
{
    class Chips : Product
    {
        private string taffel;
        private string kims;
        private string lays;

        public Chips(string taffel, string kims, string lays)
        {
            this.taffel = taffel;
            this.kims = kims;
            this.lays = lays;
        }
        public string Lays
        {
            get { return lays; }
            set { lays = value; }
        }
        public string Kims
        {
            get { return kims; }
            set { kims = value; }
        }
        public string Taffel
        {
            get { return taffel; }
            set { taffel = value; }
        }
    }
}

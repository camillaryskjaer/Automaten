using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Machine.Products
{
    class Soda : Product
    {
        private string pepsi;
        private string faxe;
        private string cola;

        public Soda()
        {

        }
        public string Pepsi
        {
            get { return pepsi; }
            set { pepsi = value; }
        }
        public string Faxe
        {
            get { return faxe; }
            set { faxe = value; }
        }
        public string Cola
        {
            get { return cola; }
            set { cola = value; }
        }
        public Soda(string pepsi, string faxe, string cola)
        {
            this.pepsi = "Pepsi";
            this.faxe = "Faxe";
            this.cola = "Cola";

        }
    }
}

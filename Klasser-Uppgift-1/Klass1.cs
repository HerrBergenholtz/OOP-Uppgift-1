using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_Uppgift_1
{
    internal class Klass1
    {
        private string märke;
        private string modell;
        private string vikt;
        private string färg;
        private int hästkrafter;

        public string setMärke
        {
            get { return märke; }
            set { märke = value; }
        }

        public string setModell
        {
            get { return modell; }
            set { modell = value; }
        }

        public string setVikt
        {
            get { return vikt; }
            set { vikt = value; }
        }

        public string setFärg
        {
            get { return färg; }
            set { färg = value; }
        }

        public int setHästkraft
        {
            get { return hästkrafter; }
            set { hästkrafter = value; }
        }
    }   
}

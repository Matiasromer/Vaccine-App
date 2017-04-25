using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Registrering
    {
        public int Cpr { get; set; }
        public string Navn { get; set; }

        public Registrering(int Cpr, string Navn)
        {
            this.Cpr = Cpr;
            this.Navn = Navn;
        }
    }
}

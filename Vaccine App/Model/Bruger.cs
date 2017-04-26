using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Bruger
    {
        public string Navn { get; set; }
        public int Cpr { get; set; }
        public string Email { get; set; }
        public string Underbruger { get; set; }

        public Bruger(string Navn, int Cpr, string Email, string Underbruger)
        {
            this.Navn = Navn;
            this.Cpr = Cpr;
            this.Email = Email;
            this.Underbruger = Underbruger;
        }
    }
}

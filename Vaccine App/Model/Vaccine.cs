using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Vaccine
    {
        public string Navn { get; set; }
        public string Info { get; set; }

        public Vaccine(string Navn, string Info)
        {
            this.Navn = Navn;
            this.Info = Info;
        }

        public override string ToString()
        {
            return "";
        }
    }
}

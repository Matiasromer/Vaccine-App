using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Kalender
    {
        //Props
        public string VaccineNavn { get; set; }
        public DateTime Date { get; set; }

        //Constructor
        public Kalender(string VaccineNavn, DateTime DateTime)
        {
            this.VaccineNavn = VaccineNavn;
            this.Date = DateTime;
        }
    }
}

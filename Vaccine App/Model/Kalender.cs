using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Kalender
    {
        public double Vaccineret { get; set; }
        public DateTime Date { get; set; }

        public Kalender(double Vaccineret, DateTime DateTime)
        {
            this.Vaccineret = Vaccineret;
            this.Date = DateTime;
        }
    }
}

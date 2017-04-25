using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class VaccinePlan
    {
        public DateTime Dato { get; set; }

        public VaccinePlan(DateTime Dato)
        {
            this.Dato = Dato;
        }
    }
}

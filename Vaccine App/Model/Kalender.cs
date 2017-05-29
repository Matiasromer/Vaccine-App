using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    public class Kalender
    {
        //Props
        public int Barn_id { get; set; }
        public DateTime Dato { get; set; }
        public int Vac_id { get; set; }

        //Constructor
        public Kalender(DateTime injectionDate, int barnId, int vaccineid)
        {
            Dato = injectionDate;
            Barn_id = barnId;
            Vac_id = vaccineid;            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
   public class VaccinePlanView
    {
        //Properties
        public DateTime Dato { get; set; }
        public int Barn_id { get; set; }
        public int Kalender_id { get; set; }
        public string Vac_Navn { get; set; }

        //Constructor
        public VaccinePlanView(DateTime dato, int barnId, int kalenderId, string vacNavn)
        {
            Dato = dato;
            Barn_id = barnId;
            Kalender_id = kalenderId;
            Vac_Navn = vacNavn;
        }

        //Override ToString
        public override string ToString()
        {
            return $"{Vac_Navn}  -  {Dato:dd/MM/yyyy}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Barn
    {
        // Barn klasse (denne klasse) hed engang Bruger
        public string BarnNavn;
        public int DeviceId { get; set; }
        public int Fødselsdato { get; set; }
        // køn er int fordi vi kan nemmere binde den til fremtidige knapper
        public int Gender { get; set; }
       // public string Email { get; set; }
      //  public string Barn { get; set; }
        public int Tlfnr { get; set; }

        public Barn(int DeviceId, int Fødselsdato, int Gender, string Email, int Tlfnr)
        {
            this.DeviceId = DeviceId;
            this.Fødselsdato = Fødselsdato;
            this.Gender = Gender;
          //  this.Email = Email;
          //  this.Barn = Barn;
            this.Tlfnr = Tlfnr;
        }
    }
}

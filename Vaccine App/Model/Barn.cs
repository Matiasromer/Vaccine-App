using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
   public class Barn
    {
        // Barn klasse (denne klasse) hed engang Bruger.
        public string BarnNavn;
        public int DeviceId { get; set; }
        public int BarnId { get; set; }
        public int Foedselsdato { get; set; }
        // Gender er int fordi vi kan nemmere binde den til fremtidige knapper
        public int Gender { get; set; }
       // public string Email { get; set; }
      //  public string Barn { get; set; }
       // public int Tlfnr { get; set; }

        public Barn(string BarnNavn, int DeviceId, int Foedselsdato, int Gender)
        {
            this.BarnId = this.BarnId;
            this.BarnNavn = BarnNavn;
            this.DeviceId = DeviceId;
            this.Foedselsdato = Foedselsdato;
            this.Gender = Gender;
          //  this.Email = Email;
          //  this.Barn = Barn;
          //  this.Tlfnr = Tlfnr;
        }

        //public Barn(int fødselsdato, int deviceId, int gender, string barnNavn)
        //{
        //    Fødselsdato = fødselsdato;
        //    DeviceId = deviceId;
        //    Gender = gender;
        //    BarnNavn = barnNavn;
        //  //  Tlfnr = tlfnr;
        //}

        public override string ToString()
        {
            return $"{BarnNavn}  -  {DeviceId}  -  {Foedselsdato}  -  {Gender}  ";
        }
    }
}

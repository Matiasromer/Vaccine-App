using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
   public class Barn
    {   
        //Hej fra Jonatan
        // Barn klasse (denne klasse) hed engang Bruger.
        //Properties
        public string Barn_Navn;
        public int Device_id { get; set; }
        public int Barn_Id { get; set; }
        public DateTime Barn_Foedsel { get; set; }
        public String Gender { get; set; }

        //Constructor
        public Barn(string BarnNavn, int DeviceId, DateTime Fødselsdato, String Gender)
        {
            this.Barn_Navn = BarnNavn;
            this.Device_id = DeviceId;
            this.Barn_Foedsel = Fødselsdato;
            this.Gender = Gender;
        }

        //Override string. Format data hentes ind i.
        public override string ToString()
        {
            return $"{Barn_Navn}   -  {Barn_Foedsel:d} -  {Gender}  ";
        }
    }
}

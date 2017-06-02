using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class BarnListe
    {
        //Properties
        public string Barn_Navn;
        public int Barn_Id { get; set; }
        public string Info;

        //Constructor
        public BarnListe(string BarnNavn, int BarnId, string Info)
        {
            this.Barn_Navn = BarnNavn;
            this.Barn_Id = BarnId;
            this.Info = Info;
        }

        //Override string. Format data hentes ind i.
        public override string ToString()
        {
            return $"{Barn_Id}   -  {Barn_Navn} -  {Info}  ";
        }
    }
}

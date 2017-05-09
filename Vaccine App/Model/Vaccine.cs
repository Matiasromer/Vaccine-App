using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    public class Vaccine
    {
        //props
        public int Vac_Id { get; set; }
        public string Vac_Navn { get; set; }
        public string Vac_Info { get; set; }

        //constructor
        public Vaccine(int Id, string Navn, string Info)
        {
            this.Vac_Id = Id;
            this.Vac_Navn = Navn;
            this.Vac_Info = Info;
        }

        //Override method
        public override string ToString()
        {
            return $"{Vac_Id}  -  {Vac_Navn}  ";
        }
    }
}

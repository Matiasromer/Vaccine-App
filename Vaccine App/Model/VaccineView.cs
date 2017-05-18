using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{

  
    public partial class VaccineView
    {
        public int Vac_Id { get; set; }
        
        public string Vac_Navn { get; set; }
        
        public string Vac_Info { get; set; }
        
        public int RkFlg { get; set; }
        
        public int TidMdr { get; set; }

        public VaccineView()
        {
            
        }

        public VaccineView(int vacId, string vacNavn, string vacInfo, int rkFlg, int tidMdr)
        {
            Vac_Id = vacId;
            Vac_Navn = vacNavn;
            Vac_Info = vacInfo;
            RkFlg = rkFlg;
            TidMdr = tidMdr;
        }

        public override string ToString()
        {
            return $"{Vac_Navn}  -  {TidMdr}";
        }

    }

    

    
}

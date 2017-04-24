using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.ViewModel;
using Vaccine_App.Model;

namespace Vaccine_App.Handler
{
    class VaccineHandler
    {
        public VaccineViewmodel VaccineViewmodel { get; set; }

        public VaccineHandler(VaccineViewmodel vvm)
        {
            this.VaccineViewmodel = vvm;
        }
    }
}

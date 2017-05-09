using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.ViewModel;
using Vaccine_App.Model;

namespace Vaccine_App.Handler
{
   public class VaccineHandler
    {
        public VaccineViewmodel VaccineViewmodel { get; set; }

        public VaccineHandler(VaccineViewmodel vvm)
        {
            this.VaccineViewmodel = vvm;
        }

        //Post Metode
        //public void CreateVaccine()
        //{
        //    Vaccine tempVacc = new Vaccine(VaccineViewmodel.Vac_Id, VaccineViewmodel.Vac_Name, VaccineViewmodel.Vac_Info);
        //    tempVacc.Vac_Id = VaccineViewmodel.Vac_Id;
        //    tempVacc.Vac_Navn = VaccineViewmodel.Vac_Name;
        //    tempVacc.Vac_Info = VaccineViewmodel.Vac_Info;

        //    VaccineSingleton.Instance.AddVaccine(tempVacc);
            // Vaccine_App.Persistency.PersistencyService.PostVaccineAsync(tempVacc);
        //}

        public async void VaccineGet()
        {
            await VaccineSingleton.Instance.GetVaccineASync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        //Henter vaccine dataen
        public async void VaccineGet()
        {
            await VaccineViewSingleton.Instance.GetVaccineViewASync();
        }

        public async void KalenderOpret()
        {
            int tempList = new int();
            tempList = await Persistency.PersistencyService.GetKalenderSum(BrugerViewmodel.selectedBarn.Barn_Id);
            if (tempList.Equals(0))
            {
                VaccineViewSingleton.Instance.OpretKalender(BrugerViewmodel.selectedBarn);
            }
            await VaccineViewmodel.VaccineViewSingleton.GetVaccinePlanViewAsync(BrugerViewmodel.selectedBarn.Barn_Id);
        }
        
        //Sletter Vaccine fra liste
        public void DeleteVaccine()
        {            
            VaccineViewSingleton.Instance.RemoveVaccine(VaccineViewmodel.SelectedVaccine);            
        }

    }

}

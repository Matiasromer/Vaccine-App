using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.Model;
using Vaccine_App.View;
using Vaccine_App.ViewModel;
using Vaccine_App.Persistency;

namespace Vaccine_App.Handler
{
   public class BarnHandler
    {
        // denne klasse hed engang BrugerHandler.
        public BrugerViewmodel BrugerViewmodel { get; set; }
        public BarnHandler(BrugerViewmodel bvm)
        {
            this.BrugerViewmodel = bvm;
        }

        //createBarn - Laver temp barn, og tilføjer til Instancen i sngleton
        public void CreateBarn()
        {
            Barn tempBarn = new Barn(BrugerViewmodel.BarnNavn, BrugerViewmodel.DeviceId, BrugerViewmodel.Fødselsdato, BrugerViewmodel.Gender);
            tempBarn.Barn_Foedsel = BrugerViewmodel.Fødselsdato;
            tempBarn.Device_id = BrugerViewmodel.DeviceId;
            tempBarn.Gender = BrugerViewmodel.Gender;
            tempBarn.Barn_Navn = BrugerViewmodel.BarnNavn;
            BarnSingleton.Instance.AddBarn(tempBarn);
        }
         
        //DeleteBarn -sletter fra instances
        public void DeleteBarn()
        {
            BarnSingleton.Instance.RemoveBarn(BrugerViewmodel.SelectedBarn);
        }

        //henter dataen
        public async void GetBarn()
        {
            await BarnSingleton.Instance.GetBarnASync();
        }
    }
}

﻿using System;
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

        //Post Metode - laver temp vaccine, og tilføjer til Instancen
        //public void CreateVaccine()
        //{
        //    Vaccine tempVacc = new Vaccine(VaccineViewmodel.Vac_Id, VaccineViewmodel.Vac_Name, VaccineViewmodel.Vac_Info);
        //    tempVacc.Vac_Id = VaccineViewmodel.Vac_Id;
        //    tempVacc.Vac_Navn = VaccineViewmodel.Vac_Name;
        //    tempVacc.Vac_Info = VaccineViewmodel.Vac_Info;

        //    VaccineSingleton.Instance.AddVaccine(tempVacc);
        //}

        //Henter vaccine dataen
        public async void VaccineGet()
        {
            await VaccineViewSingleton.Instance.GetVaccineViewASync();
        }

        public async void KalenderOpret()
        {
            ObservableCollection<Kalender> tempList = new ObservableCollection<Kalender>();
            tempList = await Persistency.PersistencyService.GetKalenderAsync(BrugerViewmodel.selectedBarn.Barn_Id);
            if (tempList.Count == 0)
            {
                VaccineViewSingleton.Instance.OpretKalender(BrugerViewmodel.selectedBarn);
            }
        }
    }
}

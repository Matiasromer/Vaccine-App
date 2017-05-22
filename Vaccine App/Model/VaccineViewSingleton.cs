using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.Persistency;
using Vaccine_App.ViewModel;

namespace Vaccine_App.Model
{
    // VaccineViewPlan ligger også her inde 
    public class VaccineViewSingleton
    {
        public Barn barn { get; set; }
        //observableCollections - Lister
        private ObservableCollection<VaccineView> _vaccineView;
        public ObservableCollection<VaccineView> VaccineViewCollection
        {
            get { return _vaccineView; }
            set { _vaccineView = value; }
        }

        private ObservableCollection<VaccinePlanView> _vaccinePlanView;
        public ObservableCollection<VaccinePlanView> VaccinePlanViewCollection
        {
            get { return _vaccinePlanView; }
            set { _vaccinePlanView = value; }
        }

        //Singleton Instances
        private static VaccineViewSingleton instance;
        public static VaccineViewSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VaccineViewSingleton();
                }
                return instance;
            }

        }

        public VaccineViewSingleton()
        {
            VaccineViewCollection = new ObservableCollection<VaccineView>();
            VaccinePlanViewCollection = new ObservableCollection<VaccinePlanView>();
            GetVaccinePlanViewAsync();
            GetVaccineViewASync();
        }



        ////Add metode - ikke brugt for nu (fordi det ikke er needed)
        //public void AddVaccine(VaccineView VacAdd)
        //{
        //    VaccineViewCollection.Add(VacAdd);
        //    //  PersistencyService.PostVaccineAsync(VacAdd);
        //}

        //GetMetode - bruges samme måde som GetBarn. Henter vacciner fra Database, og tilføjer til Listen.
        public async Task GetVaccineViewASync()
        {
            foreach (var item in await PersistencyService.GetVaccineViewAsync())
            {
                this.VaccineViewCollection.Add(item);
            }
        }

        // problem med vaccplan atm
        public async Task GetVaccinePlanViewAsync()
        {
            ObservableCollection<VaccinePlanView> listen = await PersistencyService.GetVaccinePlanViewAsync(90);
            foreach (var item in listen)
            {
                this.VaccinePlanViewCollection.Add(item);
            }
        }
        public void OpretKalender(Barn kopret)
        {

            List<VaccineView> vacViewList = Instance.VaccineViewCollection.ToList();

            foreach (VaccineView v in vacViewList)
            {
                DateTime injDate = kopret.Barn_Foedsel.AddMonths(v.TidMdr);
                Kalender k = new Kalender(injDate, kopret.Barn_Id, v.Vac_Id);
                PersistencyService.PostKalenderAsync(k);
            }
        }
    }
}

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
    public class VaccineViewSingleton
    {

        //observableCollections - Lister
        private ObservableCollection<VaccineView> _vaccineView;
        public ObservableCollection<VaccineView> VaccineViewCollection
        {
            get { return _vaccineView; }
            set { _vaccineView = value; }
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
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.VoiceCommands;
using Vaccine_App.Model;
using Vaccine_App.Persistency;

namespace Vaccine_App.ViewModel
{
   public class VaccineSingleton
    {

        //observableCollections - Lister
        private ObservableCollection<Model.Vaccine> vaccine;
        public ObservableCollection<Model.Vaccine> VaccineCollection
        {   
            get { return vaccine; }
            set { vaccine = value; }
        }

        //Singleton Instances
        private static VaccineSingleton instance;
        public static VaccineSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VaccineSingleton();
                }
                return instance;
            }

        }

        public VaccineSingleton()
        {
            VaccineCollection = new ObservableCollection<Vaccine>();
        }

        //Mangler Persistency-metoder

        //Add metode
        public void AddVaccine(Vaccine VacAdd)
        {
            VaccineCollection.Add(VacAdd);
            PersistencyService.PostVaccineAsync(VacAdd);
        }
    }
}

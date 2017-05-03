using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.ViewModel
{
   public class VaccineSingleton
    {
        private ObservableCollection<Model.Vaccine> vaccine;

        public ObservableCollection<Model.Vaccine> VaccineCollection
        {   
            get { return vaccine; }
            set { vaccine = value; }

        }



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
    }
}

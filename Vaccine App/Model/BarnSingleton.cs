using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class BarnSingleton
    {
        //Denne klasse hed engang BrugerSingleton og ændre bruger og brugercollection til barn og Barncollection
        private ObservableCollection<Model.Barn> barn;

        public ObservableCollection<Model.Barn> BarnCollection
        {
            get { return barn; }
            set { barn = value; }

        }

        private static BarnSingleton instance;

        public static BarnSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BarnSingleton();
                }
                return instance;
            }
        }
                

        // mangler persistencyservice
        public void AddBarn(Barn BAdd)
        {
            BarnCollection.Add(BAdd);
        }

        public void RemoveBarn(Barn BRemove)
        {
            BarnCollection.Remove(BRemove);
        }
    }
}

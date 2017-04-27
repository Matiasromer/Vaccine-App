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
        //Denne klasse hed engang BrugerSingleton
        private ObservableCollection<Model.Barn> bruger;

        public ObservableCollection<Model.Barn> BrugerCollection
        {
            get { return bruger; }
            set { bruger = value; }

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

        
    }
}

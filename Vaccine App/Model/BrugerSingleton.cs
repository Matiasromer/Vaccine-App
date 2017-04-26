using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class BrugerSingleton
    {
        private ObservableCollection<Model.Bruger> bruger;

        public ObservableCollection<Model.Bruger> BrugerCollection
        {
            get { return bruger; }
            set { bruger = value; }

        }



        private static BrugerSingleton instance;

        public static BrugerSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BrugerSingleton();
                }
                return instance;
            }
        }
}

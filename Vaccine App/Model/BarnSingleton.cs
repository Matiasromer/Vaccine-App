using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.Persistency;

namespace Vaccine_App.Model
{
   public class BarnSingleton
    {
        //Denne klasse hed engang BrugerSingleton og ændre bruger og brugercollection til barn og Barncollection
        //ObservableCollections
        private ObservableCollection<Barn> barns;
        public ObservableCollection<Barn> BarnsCollection
        {
            get { return barns; }
            set { barns = value; }
        }

        //Singleton Instance
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

        public BarnSingleton()
        {
            BarnsCollection = new ObservableCollection<Barn>();
            GetBarnASync();
        }

        //AddBarn - tilføjer Barn til Liste og køre igennem Persistency Metode: Post
        public void AddBarn(Barn BAdd)
        {
            BarnsCollection.Add(BAdd);
            PersistencyService.PostBarnAsync(BAdd);
            BarnsCollection.Clear();
            GetBarnASync();
        }

        //RemoveBar - Fjerner barn fra liste og køre gennem Peristency: Delete
        public void RemoveBarn(Barn BRemove)
        {
            BarnsCollection.Remove(BRemove);
            PersistencyService.DeleteBarnAsync(BRemove);
        }

        //GetBarn - Henter data fra Databasen gennem Persistency: Get, og tilfæjer til listen.
        public async Task GetBarnASync()
        {
            foreach (var item in await PersistencyService.GetBarnAsync())
            {
                this.BarnsCollection.Add(item);
            }
        }
    }
}

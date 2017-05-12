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

        public void AddBarn(Barn BAdd)
        {
            BarnsCollection.Add(BAdd);
            PersistencyService.PostBarnAsync(BAdd);
            BarnsCollection.Clear();
            GetBarnASync();
        }

        public void RemoveBarn(Barn BRemove)
        {
            BarnsCollection.Remove(BRemove);
            PersistencyService.DeleteBarnAsync(BRemove);
        }

        //public void Hentbarn()
        //{
        //    BarnsCollection = PersistencyService.GetBarnAsync();
        //}

        public async Task GetBarnASync()
        {
            foreach (var item in await PersistencyService.GetBarnAsync())
            {
                this.BarnsCollection.Add(item);
            }
        }
    }
}

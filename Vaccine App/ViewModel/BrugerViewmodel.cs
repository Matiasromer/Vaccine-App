using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.UserDataAccounts.SystemAccess;
using Vaccine_App.Common;
using Vaccine_App.Handler;
using Vaccine_App.Model;

namespace Vaccine_App.ViewModel
{
   public class BrugerViewmodel : INotifyPropertyChanged
    {
        //Singletons
        public BarnSingleton BarnSingleton { get; set; }
       // public VaccineSingleton VaccineSingleton { get; set; }

        //ObersvableCollections
        private ObservableCollection<Barn> barnCollection;
        public ObservableCollection<Barn> BarnCollection
        {
            get { return barnCollection; }
            set { barnCollection = value; }
        }


        //Commands
        public ICommand CreateBarnCommand { get; set; }
        public ICommand DeleteBarnCommand { get; set; }
        public ICommand GetBarnCommand { get; set; }

        //Props
        private DateTime fødselsdato = DateTime.Now;
        public DateTime Fødselsdato
        {
            get { return fødselsdato; }
            set
            {
                fødselsdato = value.Date;   
                OnPropertyChanged(nameof(Fødselsdato));
            }
        }
        

        private string barnnavn;
        public string BarnNavn
        {
            get { return barnnavn; }
            set { barnnavn = value; }
        }

        //private string email;

       // public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}
        private String gender;
        public String Gender
        {
            get { return gender;}
            set
            {
                gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        private int tlfnr;
        public int Tlfnr
        {
            get { return tlfnr;}
            set { tlfnr = value; }
        }

        private int deviceId;
        public int DeviceId
        {
            get {return deviceId;}
            set { deviceId = value; }
        }

        private Barn selectedBarn;
        public Barn SelectedBarn
        {
            get { return selectedBarn; }
            set { selectedBarn = value; OnPropertyChanged(nameof(SelectedBarn)); }
        }

        //Handler
        public Handler.BarnHandler Bh { get; set; }

        //ViewModel
        public BrugerViewmodel()
        {
            BarnCollection = BarnSingleton.Instance.BarnsCollection;
            Bh = new Handler.BarnHandler(this);
            BarnSingleton = BarnSingleton.Instance;

            CreateBarnCommand = new RelayCommand(Bh.CreateBarn, null);
            DeleteBarnCommand = new RelayCommand(Bh.DeleteBarn, CanDeleteBarn);
            GetBarnCommand = new RelayCommand(Bh.GetBarn, null);
        }

        //Fail-Safe; Kan ikke bruge slette nap hvis der intet er i listen.
        public bool CanDeleteBarn()
        {
            if (SelectedBarn != null)
                return true;
            else
            {
                return false;
            }
           
        }


        //INotifyPropChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
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
        public BarnSingleton BarnSingleton { get; set; }
        public VaccineSingleton VaccineSingleton { get; set; }

        public ObservableCollection<Barn> Barn
        //Commands
        public ICommand CreateBarnCommand { get; set; }
        public ICommand DeleteBarnCommand { get; set; }


        //Handler

        private int fødselsdato;

        public int Fødselsdato
        {
            get { return fødselsdato; }
            set { fødselsdato = value; }
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
        private int gender;

        public int Gender
        {
            get { return gender;}
            set { gender = value; }
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
        public Handler.BarnHandler BarnHandler;

        //ViewModel
        public BrugerViewmodel()
        {
            BarnHandler = new Handler.BarnHandler(this);
            BarnSingleton = BarnSingleton.Instance;

            CreateBarnCommand = new RelayCommand(BarnHandler.CreateBarn);
            DeleteBarnCommand = new RelayCommand(BarnHandler.DeleteBarn);
        }

    

        //INotifyPropChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vaccine_App.Handler;
using Vaccine_App.Model;

namespace Vaccine_App.ViewModel
{
    class BrugerViewmodel : INotifyPropertyChanged
    {
        public BrugerSingleton BrugerSingleton { get; set; }
        public VaccineSingleton VaccineSingleton { get; set; }
        //Commands
        public ICommand CreateBarnCommand { get; set; }
        public ICommand DeleteBarnCommand { get; set; }


        //Handler

        private int barncpr;

        public int Barncpr
        {
            get { return barncpr; }
            set { barncpr = value; }
        }

        private string barnnavn;

        public string BarnNavn
        {
            get { return barnnavn; }
            set { barnnavn = value; }
        }

        public Handler.BrugerHandler BrugerHandler;

        //ViewModel
        public BrugerViewmodel()
        {
            BrugerHandler = new Handler.BrugerHandler(this);
            BrugerSingleton = BrugerSingleton.Instance;
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
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vaccine_App.Common;
using Vaccine_App.Handler;
using Vaccine_App.Model;

namespace Vaccine_App.ViewModel
{ 

   public class VaccineViewmodel : INotifyPropertyChanged
    {
       // Singletons
        public VaccineSingleton VaccineSingleton { get; set; }

        //ObservableColletions
        private ObservableCollection<Vaccine> vaccineCollection;
        public ObservableCollection<Vaccine> VaccineCollection
        {
            get { return vaccineCollection; }
            set { vaccineCollection = value; }
        }

        //Commands
        public ICommand CreateVaccineCommand { get; set; }
        public ICommand GetVaccineCommand { get; set; }

        //props
        private int vac_Id;

        public int Vac_Id
        {
            get { return vac_Id; }
            set { vac_Id = value; }
        }

        private string vac_Name;

        public string Vac_Name
        {
            get { return vac_Name; }
            set { vac_Name = value; }
        }

        private string vac_Info;
        public string Vac_Info
        {
            get { return vac_Info; }
            set { vac_Info = value; }
        }

        private Vaccine selectedVaccine;

        public Vaccine SelectedVaccine
        {
            get { return selectedVaccine; }
            set { selectedVaccine = value; }
        }

        //Handler
        public Handler.VaccineHandler VH;

        //ViewModel
        public VaccineViewmodel()
        {
            VaccineCollection = VaccineSingleton.Instance.VaccinesCollection;
            VH = new VaccineHandler(this);
            VaccineSingleton = VaccineSingleton.Instance;

            GetVaccineCommand = new RelayCommand(VH.VaccineGet, null);
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

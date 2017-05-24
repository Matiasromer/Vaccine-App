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
        //  public VaccineSingleton VaccineSingleton { get; set; }
        public VaccineViewSingleton VaccineViewSingleton { get; set; }
        //ObservableColletions
        //private ObservableCollection<Vaccine> vaccineCollection;
        //public ObservableCollection<Vaccine> VaccineCollection
        //{
        //    get { return vaccineCollection; }
        //    set { vaccineCollection = value; }
        //}

        private ObservableCollection<VaccineView> vaccineViewCollection;

        public ObservableCollection<VaccineView> VaccineViewCollection
        {
            get { return vaccineViewCollection; }
            set { vaccineViewCollection = value; }
        }

        private ObservableCollection<VaccinePlanView> vaccinePlanViewCollection;
        public ObservableCollection<VaccinePlanView>  VaccinePlanViewCollection
        {
            get { return vaccinePlanViewCollection; }
            set { vaccinePlanViewCollection = value; }
        }



        //Commands
        public ICommand CreateVaccineCommand { get; set; }
        public ICommand GetVaccineCommand { get; set; }
        public ICommand OpretKalenderCommand { get; set; }
        public ICommand SeInfoCommand { get; set; }
        public ICommand DeleteVaccineCommand { get; set; }

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

        // ændrede vaccine til vaccineview her - v er lille (før stort)
        private VaccineView selectedvaccine;

        public VaccineView Selectedvaccine
        {
            get { return selectedvaccine; }
            set { selectedvaccine = value; }
        }
        // Ændret VaccineView til VaccinePlanView - test fordi vacplan ikke viser en plan for hvert enkelt barn (var selectedBarn før)
        private VaccinePlanView selectedVaccine;
        public VaccinePlanView SelectedVaccine
        {
            get { return selectedVaccine; }
            set { selectedVaccine = value; }
        }

        
    
        //Handler
        public Handler.VaccineHandler VH;
        public Handler.BarnHandler BH;

        //ViewModel
        public VaccineViewmodel()
        {
            VaccineViewCollection = VaccineViewSingleton.Instance.VaccineViewCollection;
            VaccinePlanViewCollection = VaccineViewSingleton.Instance.VaccinePlanViewCollection;
            //  VaccineCollection = VaccineSingleton.Instance.VaccinesCollection;
            VH = new VaccineHandler(this);
            // VaccineSingleton = VaccineSingleton.Instance;
            VaccineViewSingleton = VaccineViewSingleton.Instance;

            GetVaccineCommand = new RelayCommand(VH.VaccineGet, null);
            OpretKalenderCommand = new RelayCommand(VH.KalenderOpret, null);
            DeleteVaccineCommand = new RelayCommand(VH.DeleteVaccine, null);
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

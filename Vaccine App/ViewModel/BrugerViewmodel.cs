﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel.UserDataAccounts.SystemAccess;
using Vaccine_App.Handler;
using Vaccine_App.Model;
using Vaccine_App.Common;
using Windows.UI.Xaml.Controls;
using Vaccine_App.Converter;
namespace Vaccine_App.ViewModel
{
    public class BrugerViewmodel : INotifyPropertyChanged
    {
        //ComboBox koden - Nødvendig for ComboBox til at virke.
        #region combobox code
        // hej
        //http://stackoverflow.com/questions/33821672/uwp-combobox-binding-to-selecteditem-property

        public ObservableCollection<ComboBoxItem> ComboBoxOptions { get; set; } = new ObservableCollection<ComboBoxItem>();

        private ComboBoxItem _SelectedComboBoxOption;

        public ComboBoxItem SelectedComboBoxOption
        {
            get
            {
                return _SelectedComboBoxOption;
            }
            set
            {
                if (_SelectedComboBoxOption != value)
                {
                    _SelectedComboBoxOption = value;
                    //Sets the Gender property when ComboBox item is selected/set
                    Gender = _SelectedComboBoxOption.Content.ToString();
                    OnPropertyChanged("SelectedComboBoxOption");
                }
            }
        }
        #endregion
 
        //Singletons
        public BarnSingleton BarnSingleton { get; set; }
        public VaccineViewSingleton VaccineViewSingleton { get; set; }        

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
        private DateTime fødselsdato;
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

        private String gender;
        public String Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        private int tlfnr;
        public int Tlfnr
        {
            get { return tlfnr; }
            set { tlfnr = value; }
        }

        private int deviceId;
        public int DeviceId
        {
            get { return deviceId; }
            set { deviceId = value; }
        }

        public static Barn selectedBarn;
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
            Fødselsdato = DateTime.Now;
            BarnCollection = BarnSingleton.Instance.BarnsCollection;
            Bh = new Handler.BarnHandler(this);
            BarnSingleton = BarnSingleton.Instance;
            VaccineViewSingleton = VaccineViewSingleton.Instance;

            CreateBarnCommand = new RelayCommand(Bh.CreateBarn, CanCreateBarnNavn);
            DeleteBarnCommand = new RelayCommand(Bh.DeleteBarn, CanDeleteBarn);
            GetBarnCommand = new RelayCommand(Bh.GetBarn, null);
        }

        //Fail-Safe; Kan ikke bruge slette knap hvis der intet er i listen.
        public bool CanDeleteBarn()
        {
            if (SelectedBarn != null)
                return true;
            else
            {
                return false;
            }
        }

        //Fail-Safe; Kan ikke skabe barn.objekt, hvis der ikke er angivet navn og køn.
        public bool CanCreateBarnNavn()
        {
            if (BarnNavn != null && Gender != null)
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
            {
                 PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }        
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Vaccine_App.Persistency;
using Vaccine_App.ViewModel;
using Windows.UI.Popups;

namespace Vaccine_App.Model
{
    // VaccineViewPlan ligger også her inde 
    public class VaccineViewSingleton
    {
        public Barn barn { get; set; }
        //observableCollections - Lister
        private ObservableCollection<VaccineView> _vaccineView;
        public ObservableCollection<VaccineView> VaccineViewCollection
        {
            get { return _vaccineView; }
            set { _vaccineView = value; }
        }

        private ObservableCollection<VaccinePlanView> _vaccinePlanView;
        public ObservableCollection<VaccinePlanView> VaccinePlanViewCollection
        {
            get { return _vaccinePlanView; }
            set { _vaccinePlanView = value; }
        }

        //Singleton Instances
        private static VaccineViewSingleton instance;
        public static VaccineViewSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VaccineViewSingleton();
                }
                return instance;
            }

        }

        public VaccineViewSingleton()
        {
            VaccineViewCollection = new ObservableCollection<VaccineView>();
            VaccinePlanViewCollection = new ObservableCollection<VaccinePlanView>();
            //GetVaccinePlanViewAsync();
            GetVaccineViewASync();
        }



        ////Add metode - ikke brugt for nu (fordi det ikke er needed)
        //public void AddVaccine(VaccineView VacAdd)
        //{
        //    VaccineViewCollection.Add(VacAdd);
        //    //  PersistencyService.PostVaccineAsync(VacAdd);
        //}

        //GetMetode - bruges samme måde som GetBarn. Henter vacciner fra Database, og tilføjer til Listen.
        public async Task GetVaccineViewASync()
        {
            foreach (var item in await PersistencyService.GetVaccineViewAsync())
            {
                this.VaccineViewCollection.Add(item);
            }
        }

        //public async Task GetVaccineInfo(int id)
        //{
        //    MessageDialog BarnAdded = new MessageDialog();
        //    BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
        //    BarnAdded.ShowAsync().AsTask();
        //}
        // problem med vaccplan atm
        public async Task GetVaccinePlanViewAsync(int selectedBarnId)
        {
            ObservableCollection<VaccinePlanView> listen = await PersistencyService.GetVaccinePlanViewAsync(selectedBarnId);
            this.VaccinePlanViewCollection.Clear();
            foreach (var item in listen)
            {
                this.VaccinePlanViewCollection.Add(item);
            }
        }
        public void OpretKalender(Barn kopret)
        {

            List<VaccineView> vacViewList = Instance.VaccineViewCollection.ToList();

            foreach (VaccineView v in vacViewList)
            {
                DateTime injDate = kopret.Barn_Foedsel.AddMonths(v.TidMdr);
                Kalender k = new Kalender(injDate, kopret.Barn_Id, v.Vac_Id);
                PersistencyService.PostKalenderAsync(k);

                ToastTemplateType toastTemplate = ToastTemplateType.ToastText02;
                XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);

                IXmlNode toasttextelements = toastXml.GetElementsByTagName("text").FirstOrDefault();
                toasttextelements.AppendChild(toastXml.CreateTextNode($"{kopret.Barn_Navn} skal have vaccine {v.Vac_Navn} den {k.Dato:dd-MM-yyyy} "));
                
                //Filler så jeg kan commit
                DateTime dueTime = k.Dato.AddMonths(-1);
                //DateTime dueTime = DateTime.Now.AddSeconds(10);

                ScheduledToastNotification scheduledToast = new ScheduledToastNotification(toastXml, dueTime);

                ToastNotificationManager.CreateToastNotifier().AddToSchedule(scheduledToast);
            }
        }

        public void RemoveVaccine(VaccinePlanView VaccRemove)
        {
            VaccinePlanViewCollection.Remove(VaccRemove);
            PersistencyService.DeleteVaccineAsync(VaccRemove);
        }
    }
}

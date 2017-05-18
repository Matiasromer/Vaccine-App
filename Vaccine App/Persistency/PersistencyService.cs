using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Vaccine_App.Model;
using Vaccine_App.ViewModel;

namespace Vaccine_App.Persistency
{
    class PersistencyService
    {
        //server Url
        const string serverURL = "http://vaccineapi.azurewebsites.net/";

        // Post, laver et barn og sender til db - 
        // date er det der viser hvilket barn har hvilken liste - det er det der skal kigges på i post
        public static void PostBarnAsync(Barn PostBarn)
        {


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                
                string urlStringCreate = "api/barn/";

                try
                {
                    var response = client.PostAsJsonAsync<Barn>(urlStringCreate, PostBarn).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog BarnAdded = new MessageDialog("Dit barn blev tilføjet");
                    BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
                    BarnAdded.ShowAsync().AsTask();
                }

            }
                catch (Exception e)
            {
                MessageDialog BarnAdded = new MessageDialog("Fejl, barn blev ikke tilføjet" + e);
                BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
                BarnAdded.ShowAsync().AsTask();
                throw;
            }
        }
        }

        public static void PostKalenderAsync(Kalender k)
        {
            //TODO implement
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();

                string urlStringCreate = "api/kalender/";

                var response = client.PostAsJsonAsync<Kalender>(urlStringCreate, k).Result;
                

            }



        }

        public static async Task<ObservableCollection<VaccineView>> GetVaccineViewAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlstring = "api/vaccineViews/";
                HttpResponseMessage response = await client.GetAsync(urlstring);
                if (response.IsSuccessStatusCode)
                {

                    var vaccineViewList = response.Content.ReadAsAsync<ObservableCollection<VaccineView>>().Result;
                    return vaccineViewList;
                }
                return null;
            }
        }

        // Delete Barn
        public static void DeleteBarnAsync(Barn DeleteBarn)
        {
            using (var client = new HttpClient())

            {

                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlString = "api/barn/" + DeleteBarn.Barn_Id.ToString();

                try
                {
                    var response = client.DeleteAsync(urlString).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageDialog barnDeleted = new MessageDialog("Barn er Slettet");
                        barnDeleted.Commands.Add(new UICommand {Label = "Ok"});
                        barnDeleted.ShowAsync().AsTask();
                    }

                }
                catch (Exception e)
                {
                    MessageDialog barnDeleted = new MessageDialog("Barn blev ikke Slettet" + e);
                    barnDeleted.Commands.Add(new UICommand {Label = "Ok"});
                    barnDeleted.ShowAsync().AsTask();
                }
            }
        }

        //Get Barn        
        public static async Task<ObservableCollection<Barn>> GetBarnAsync()
        {
             ObservableCollection<Barn> TempBarnCollection = new ObservableCollection<Barn>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlstring = "api/barn/";                                
                HttpResponseMessage response = await client.GetAsync(urlstring);
                if (response.IsSuccessStatusCode)
                {
                    TempBarnCollection = response.Content.ReadAsAsync<ObservableCollection<Barn>>().Result;                   
                }
                    return TempBarnCollection;               
            }                     
        }

        //public static async Task<ObservableCollection<Vaccine>> GetVaccineAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        client.BaseAddress = new Uri(serverURL);
        //        client.DefaultRequestHeaders.Clear();
        //        string urlstring = "api/vaccine/";
        //        HttpResponseMessage response = await client.GetAsync(urlstring);
        //        if (response.IsSuccessStatusCode)
        //        {
                   
        //            var VaccineListe = response.Content.ReadAsAsync<ObservableCollection<Vaccine>>().Result;
        //            return VaccineListe;
        //        }
        //        return null;
        //    }
        //}
        //Post-Vaccine metode, til eventuelle extra vacciner - Bruges dog ikke, da den ikke er nødvendig lige nu.
        //public static void PostVaccineAsync(Vaccine PostVac)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(serverURL);
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        string urlStringCreate = "api/Vaccine/";

        //        try
        //        {
        //            var response = client.PostAsJsonAsync<Vaccine>(urlStringCreate, PostVac).Result;
        //            if (response.IsSuccessStatusCode)
        //            {
        //                MessageDialog BarnAdded = new MessageDialog("Vaccinen blev tilføjet");
        //                BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
        //                BarnAdded.ShowAsync().AsTask();
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            MessageDialog BarnAdded = new MessageDialog("Fejl, Vaccinen blev ikke tilføjet" + e);
        //            BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
        //            BarnAdded.ShowAsync().AsTask();
        //            throw;
        //        }
        //    }
        //}
    }
}
    



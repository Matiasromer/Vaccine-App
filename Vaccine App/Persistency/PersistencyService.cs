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

namespace Vaccine_App.Persistency
{
    class PersistencyService
    {
        //server Url
        const string serverURL = "http://vaccineapi.azurewebsites.net/";

        //Message Dialog
        //public static async void ShowMessage(string content)
        //{
        //    MessageDialog messageDialog = new MessageDialog(content);
        //    await messageDialog.ShowAsync();
        //}

        // Post, laver et barn og sender til db - Error Message; Bad Request
        public static void PostBarnAsync(Barn PostBarn)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string urlStringCreate = "api/barn/";

                try
                {
                    var response = client.PostAsJsonAsync<Barn>(urlStringCreate, PostBarn).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageDialog BarnAdded = new MessageDialog("Dit barn blev tilføjet");
                        BarnAdded.Commands.Add(new UICommand {Label = "Ok"});
                        BarnAdded.ShowAsync().AsTask();
                    }

                }   
                catch (Exception e)
                {
                    MessageDialog BarnAdded = new MessageDialog("Fejl, barn blev ikke tilføjet" + e);
                    BarnAdded.Commands.Add(new UICommand {Label = "Ok"});
                    BarnAdded.ShowAsync().AsTask();
                    throw;
                }
            }
        }

        //egen metode, Virker ikke, arbejd på ovenstående
        //public static void PostBarnAsync(Barn PostBarn)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(serverURL);
        //        client.DefaultRequestHeaders.Clear();

        //        try
        //        {
        //            var response = client.PostAsJsonAsync<Barn>("api/børn", PostBarn).Result;
        //            if (response.IsSuccessStatusCode)
        //            {
        //                ShowMessage("Du har oprettet en ny guest");
        //            }
        //            else
        //            {
        //                ShowMessage("FEJL, Guest blev ikke oprettet: " + response.StatusCode);
        //            }
        //        }
        //        catch (Exception e)
        //        {

        //            ShowMessage("Der er sket en fejl: " + e.Message);
        //        }
        //    }
        //}


        // Delete

        public static void DeleteBarnAsync(Barn DeleteBarn)
        {
            using (var client = new HttpClient())

            {

                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlString = "api/barn/" + DeleteBarn.Barn_Id;

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

        //Get        
        public static async Task<ObservableCollection<Barn>> GetBarnAsync()
        {
            // ObservableCollection<Barn> TempBarnCollection = new ObservableCollection<Barn>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlstring = "api/barn/";                                
                HttpResponseMessage response = await client.GetAsync(urlstring);
                if (response.IsSuccessStatusCode)
                    {
                        var BarnListe = response.Content.ReadAsAsync<ObservableCollection<Barn>>().Result;
                        return BarnListe;
                    }
                    return null;               
            }
            //catch (Exception e)
            //{
            //    MessageDialog exception = new MessageDialog(e.Message);
            //    return TempBarnCollection = null;
            // }

            //public static ObservableCollection<Barn> GetBarn()
            //{
            //    using (var Client = new HttpClient())
            //    {
            //        Client.BaseAddress = new Uri(serverURL);
            //        Client.DefaultRequestHeaders.Clear();
            //        string urlStringGet = "api/barn/";

            //        var response = Client.GetAsync(urlStringGet).Result;

            //        if (response.IsSuccessStatusCode)
            //        {
            //            var BarnListe = response.Content.ReadAsAsync<ObservableCollection<Barn>>().Result;

            //            return BarnListe;
            //        }
            //        return null;
            //    }
            //}
        }

        //Post-Vaccine metode, til eventuelle extra vacciner
        public static void PostVaccineAsync(Vaccine PostVac)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string urlStringCreate = "api/Vaccine/";

                try
                {
                    var response = client.PostAsJsonAsync<Vaccine>(urlStringCreate, PostVac).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageDialog BarnAdded = new MessageDialog("Vaccinen blev tilføjet");
                        BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
                        BarnAdded.ShowAsync().AsTask();
                    }

                }
                catch (Exception e)
                {
                    MessageDialog BarnAdded = new MessageDialog("Fejl, Vaccinen blev ikke tilføjet" + e);
                    BarnAdded.Commands.Add(new UICommand { Label = "Ok" });
                    BarnAdded.ShowAsync().AsTask();
                    throw;
                }
            }
        }
    }
}
    



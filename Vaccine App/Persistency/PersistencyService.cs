using System;
using System.Collections.Generic;
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
        const string serverURL = "http://vaccinewebapi20170501110100.azurewebsites.net/";

        // Post, laver et barn og sender til db
        public static void PostGuestAsync(Barn PostBarn)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlStringCreate = "api/barn";

                try
                {
                    var Response = client.PostAsJsonAsync(urlStringCreate, PostBarn).Result;

                    if (Response.IsSuccessStatusCode)
                    {
                        MessageDialog barnCreated = new MessageDialog("Barn er tilføjet");
                        barnCreated.Commands.Add(new UICommand {Label = "Ok"});
                        barnCreated.ShowAsync().AsTask();
                    }
                    //else
                    //{
                    //    MessageDialog guestNotCreated = new MessageDialog("Create guest failed");
                    //}
                }
                catch (Exception e)
                {
                    MessageDialog barnCreated = new MessageDialog("Barn blev ikke tilføjet" + e);
                    barnCreated.Commands.Add(new UICommand {Label = "Ok"});
                    barnCreated.ShowAsync().AsTask();
                }
            }
        }

        // Delete
        //public static void DeleteGuestAsync(Guest DeleteGuest)
        //{
        //    using (var client = new HttpClient())
        //    {

        //        client.BaseAddress = new Uri(serverURL);
        //        client.DefaultRequestHeaders.Clear();
        //        string urlString = "api/guests/" + DeleteGuest.Guest_No.ToString();

        //        try
        //        {
        //            var Response = client.DeleteAsync(urlString).Result;

        //        }
        //        catch (Exception e)
        //        {
        //            MessageDialog guestNotCreated = new MessageDialog("Delete guest failed" + e);
        //        }
        //    }
        //}

        //Get        
        //public static async Task<ObservableCollection<Guest>> GetGuestAsync()
        //{
        //    ObservableCollection<Guest> TempGuestCollection = new ObservableCollection<Guest>();
        //    using (var client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        client.BaseAddress = new Uri(serverURL);
        //        client.DefaultRequestHeaders.Clear();
        //        string urlstring = "api/guests";
        //        try
        //        {
        //            HttpResponseMessage response = await client.GetAsync(urlstring);
        //            if (response.IsSuccessStatusCode)
        //            {
        //                TempGuestCollection = response.Content.ReadAsAsync<ObservableCollection<Guest>>().Result;

        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            MessageDialog exception = new MessageDialog(e.Message);
        //            return TempGuestCollection = null;
        //        }
        //        return TempGuestCollection;
        //    }
    }
    }


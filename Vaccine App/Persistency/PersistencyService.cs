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

        // Post, laver et barn og sender til db
        public static void PostBarnAsync(Barn PostBarn)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                string urlStringCreate = "api/Barn/";
                    
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
                        return TempBarnCollection;
                  }
                }
                //catch (Exception e)
                //{
                //    MessageDialog exception = new MessageDialog(e.Message);
                //    return TempBarnCollection = null;

                return null;
            }
            
        }
    }



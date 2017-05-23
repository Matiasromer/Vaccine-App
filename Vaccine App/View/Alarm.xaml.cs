using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Vaccine_App.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Alarm : Page
    {
        public Alarm()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Buttom_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.Forside), null);

        }
        private void Buttom_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.Påmindelse), null);

        }
        private void Buttom_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.Kalender), null);

        }
        private void Buttom_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.Historik), null);
        }

        private void Buttom_Click_7(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.VaccinationsInfo));
        }


        //Alarm knapper!
        private void Buttom_Click_10(object sender, RoutedEventArgs e)
        {
            MessageDialog AlarmAdded = new MessageDialog($"Dit barn skal Vaccineres: {DateTime.Now.AddDays(30)}");
            AlarmAdded.Commands.Add(new UICommand { Label = "Ok" });
            AlarmAdded.ShowAsync().AsTask();
        }
        private void Buttom_Click_11(object sender, RoutedEventArgs e)
        {
            MessageDialog AlarmAdded2 = new MessageDialog($"Dit barn skal Vaccineres: {DateTime.Now.AddDays(60)}");
            AlarmAdded2.Commands.Add(new UICommand { Label = "Ok" });
            AlarmAdded2.ShowAsync().AsTask();
        }
        private void Buttom_Click_12(object sender, RoutedEventArgs e)
        {
            MessageDialog AlarmAdded3 = new MessageDialog($"Dit barn skal Vaccineres: {DateTime.Now.AddDays(90)}");
            AlarmAdded3.Commands.Add(new UICommand { Label = "Ok" });
            AlarmAdded3.ShowAsync().AsTask();
        }
        private void Buttom_Click_13(object sender, RoutedEventArgs e)
        {
            MessageDialog AlarmAdded4 = new MessageDialog($"Dit barn skal Vaccineres: {DateTime.Now.AddDays(120)}");
            AlarmAdded4.Commands.Add(new UICommand { Label = "Ok" });
            AlarmAdded4.ShowAsync().AsTask();
        }
        private void Buttom_Click_14(object sender, RoutedEventArgs e)
        {
            MessageDialog AlarmAdded5 = new MessageDialog($"Dit barn skal Vaccineres: {DateTime.Now.AddDays(150)}");
            AlarmAdded5.Commands.Add(new UICommand { Label = "Ok" });
            AlarmAdded5.ShowAsync().AsTask();
        }
        private void Buttom_Click_15(object sender, RoutedEventArgs e)
        {
            MessageDialog AlarmAdded6 = new MessageDialog($"Dit barn skal Vaccineres: {DateTime.Now.AddDays(180)}");
            AlarmAdded6.Commands.Add(new UICommand { Label = "Ok" });
            AlarmAdded6.ShowAsync().AsTask();
        }

    }
}

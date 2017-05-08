using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Opret : Page
    {
        public Opret()
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
        private void Buttom_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View.Påmindelse), null);
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Dreng");
            comboBox.Items.Add("Pige");*/
        }
    }
}

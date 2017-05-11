﻿using System;
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
    public sealed partial class VaccinationsInfo : Page
    {
        public VaccinationsInfo()
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

        //Popup knapper!

        private void PopUp1(object sender, RoutedEventArgs e)
        {
            Info1.IsPaneOpen = !Info1.IsPaneOpen;
        }
        private void PopUp2(object sender, RoutedEventArgs e)
        {
            Info2.IsPaneOpen = !Info2.IsPaneOpen;
        }
        private void PopUp3(object sender, RoutedEventArgs e)
        {
            Info3.IsPaneOpen = !Info3.IsPaneOpen;
        }
        private void PopUp4(object sender, RoutedEventArgs e)
        {
            Info4.IsPaneOpen = !Info4.IsPaneOpen;
        }
        private void PopUp5(object sender, RoutedEventArgs e)
        {
            Info5.IsPaneOpen = !Info5.IsPaneOpen;
        }
    }
}
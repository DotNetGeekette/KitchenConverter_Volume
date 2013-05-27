using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using KitchenConverter_Volume.Resources;

namespace KitchenConverter_Volume
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            
            InitializeComponent();
            //this.UnitNames.ItemsSource = units;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        public void Recalculate(object sender, RoutedEventArgs e)
        {
            var x = 1;
        }
    }
}
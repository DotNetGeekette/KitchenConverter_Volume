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
        public MainPage()
        {
            InitializeComponent();

        }

        public void Recalculate(object sender, RoutedEventArgs e)
        {
            double number;
            if (Number != null)
            {
                if (String.IsNullOrEmpty(Number.Text))
                {
                    equalsTsp.Text = String.Empty;
                    equalsTbsp.Text = String.Empty;
                    equalsCup.Text = String.Empty;
                }
                else if (!Double.TryParse(Number.Text, out number))
                {
                    equalsTsp.Text = "Error";
                    equalsTbsp.Text = "Error";
                    equalsCup.Text = "Error";
                }
                else if (number > 100000)
                {
                    equalsTsp.Text = "Too many";
                    equalsTbsp.Text = "Too many";
                    equalsCup.Text = "Too many";
                }
                else
                {
                    switch (((ListPickerItem)Units.SelectedItem).Name)
                    {
                        case "tsp":
                            {
                                ConvertFromTeaspoons(number);
                                break;
                            }
                        case "tbsp":
                            {
                                ConvertFromTablespoons(number);
                                break;
                            }
                        case "cup":
                            {
                                ConvertFromCups(number);
                                break;
                            }

                    }
                }
            }
        }

        public void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void ConvertFromTeaspoons(double quantity)
        {
            equalsTsp.Text = FormatNumber(quantity);
            equalsTbsp.Text = FormatNumber(quantity / 3);
            equalsCup.Text = FormatNumber(quantity / 48);
        }

        private void ConvertFromTablespoons(double quantity)
        {
            equalsTsp.Text = FormatNumber(quantity * 3);
            equalsTbsp.Text = FormatNumber(quantity);
            equalsCup.Text = FormatNumber(quantity / 16);
        }

        private void ConvertFromCups(double quantity)
        {
            equalsTsp.Text = FormatNumber(quantity * 48);
            equalsTbsp.Text = FormatNumber(quantity * 16);
            equalsCup.Text = FormatNumber(quantity);
        }

        public string FormatNumber(double myNumber)
        {
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }
    }
}
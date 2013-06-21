using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace KitchenConverter_Volume
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
        }

        public void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        public void ReviewBtn_Click(object sender, RoutedEventArgs e)
        {
            var review = new MarketplaceReviewTask();
            review.Show();
        }

        public void OtherAppsBtn_Click(object sender, RoutedEventArgs e)
        {
            var search = new MarketplaceSearchTask();
            search.SearchTerms = "DotNetGeekette";
            search.Show();
        }

        public void EmailBtn_Click(object sender, RoutedEventArgs e)
        {
            var email = new EmailComposeTask();
            email.Subject = "Kitchen Converter - Volume Edition (v1.0)";
            email.Body = String.Empty;
            email.To = "jamie@dotnetgeekette.com";
            email.Show();
        }

        public void BlogBtn_Click(object sender, RoutedEventArgs e)
        {
            var webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://www.dotnetgeekette.com", UriKind.Absolute);
            webBrowserTask.Show();
        }

        public void TwitterBtn_Click(object sender, RoutedEventArgs e)
        {
            var webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://www.twitter.com/dotnetgeekette", UriKind.Absolute);
            webBrowserTask.Show();
        }

       
    }
}
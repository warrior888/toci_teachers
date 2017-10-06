using System;
using System.Windows;
using System.Windows.Input;
using CefSharp;

namespace TociApp.Views
{
    public partial class Browser : Window
    {
        public Browser(string urlAdres)
        {
            InitializeComponent();
            NavigateToUrl(urlAdres);
        }

        private void NavigateToUrl(string address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                WebBrowser.Address = new Uri(address).ToString();
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)

                NavigateToUrl(TxtUrl.Text);
        }

        private void BrowseBack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((WebBrowser != null) && (WebBrowser.CanGoBack));
        }

        private void BrowseBack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            WebBrowser.Back();
        }

        private void BrowseForward_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((WebBrowser != null) && (WebBrowser.CanGoForward));
        }

        private void BrowseForward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            WebBrowser.Forward();
        }

        private void GoToPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NavigateToUrl(TxtUrl.Text);
        }
    }
}

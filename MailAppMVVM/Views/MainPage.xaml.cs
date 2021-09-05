using MailAppMVVM.Models;
using MailAppMVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using MailAppMVVM.ViewModel;

namespace MailAppMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {   
        InitializeComponent();
          
        }
        
            private void NavigationBarButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewMailPage());
        }
        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            
        }
        private void MailSelected(Object sender, ItemTappedEventArgs e)
        {
         //  var Detail = e.Item as MailContent;
           Navigation.PushAsync(new MailDetailPage());
        }
    }
}

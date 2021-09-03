using MailAppMVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MailAppMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }
       

        private void NavigationBarButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewMailPage());
        }
    }
}

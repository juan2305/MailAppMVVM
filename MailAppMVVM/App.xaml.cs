using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MailAppMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#FF2E2E"), BarTextColor = Color.White,};
        }
     
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

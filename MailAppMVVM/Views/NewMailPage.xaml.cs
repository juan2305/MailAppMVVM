using MailAppMVVM.Models;
using MailAppMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MailAppMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMailPage : ContentPage
    {
        public NewMailPage()
        {
            InitializeComponent();
        }
        public void CreateNewMail(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

         private void SendButton_Clicked(object sender, EventArgs e)
        {
            MailContent mailContent = ((AddNewMailViewModel)BindingContext).mailContent;
            Navigation.PopAsync();
        }
    }
}
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
          
        }
     
        async void SendButtonClicked(System.Object sender, EventArgs e)
        {
            
          if(string.IsNullOrEmpty(fromEntry.Text) || string.IsNullOrEmpty(toEntry.Text) || 
             string.IsNullOrEmpty(subjectEntry.Text) || string.IsNullOrEmpty(bodyEntry.Text))
            {
                await DisplayAlert("Empty Fields", "You must fill all the fields", "Ok");
            }
            else
            {
                MailContent mailContent = ((AddNewMailViewModel)BindingContext).mailContent;
                MessagingCenter.Send(this, "NewMailPage", mailContent);
                _ = Navigation.PopAsync();
            }
         
        }
    }
}
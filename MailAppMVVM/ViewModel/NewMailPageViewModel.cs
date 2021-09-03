using MailAppMVVM.Models;
using MailAppMVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MailAppMVVM.ViewModel
{
   public class NewMailPageViewModel
    {
       public ICommand DeleteCommand { get; }
        public ObservableCollection<MailContent> MailList { get; set; }

       public NewMailPageViewModel()
        {
            MailList = new ObservableCollection<MailContent>();
            MailList.Add(new MailContent() { MailId = 1,FromMail = "From Juan", ToMail = "To: Mayelin", BodyMail="Esto es una prueba enviada por Juan", DateMail = DateTime.Now.ToShortTimeString(), IconMail="AccountLogo.png", SubjectMail= "Subject: Probando" });

            MessagingCenter.Subscribe<NewMailPage, MailContent>(this, "NewMailPage", (page, MailContent) =>
             {
                 if (MailContent.MailId ==0)
                 {
                     MailContent.MailId = MailList.Count + 1;
                     MailList.Add(MailContent);
                 }

             });
        }

        private Command refresh;

        public ICommand Refresh
        {
            get
            {
                if (refresh == null)
                {
                    refresh = new Command(PerformRefresh);
                }

                return refresh;
            }
        }

        private void PerformRefresh()
        {
        }
    }
}

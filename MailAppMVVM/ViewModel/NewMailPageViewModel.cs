using MailAppMVVM.Models;
using MailAppMVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
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
            MessagingCenter.Subscribe<NewMailPage, MailContent>(this, "NewMailPage", (page, MailContent) =>
            {
                if (MailContent.MailId == 0)
                {
                    MailContent.MailId = MailList.Count + 1;
                    MailContent.DateMail = DateTime.Now.ToShortTimeString();
                    MailList.Add(MailContent);
                }

            });
        }

    }
}
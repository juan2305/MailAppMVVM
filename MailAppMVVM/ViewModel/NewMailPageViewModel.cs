using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MailAppMVVM.ViewModel
{
   public class NewMailPageViewModel
    {
        public ObservableCollection<string> MailList { get; set; }

       public NewMailPageViewModel()
        {
            MailList = new ObservableCollection<string> ();
            MailList.Add("From Juan");
            MailList.Add("From Mayelin");
            MailList.Add("From John");

        }
    }
}

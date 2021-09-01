using System;
using System.Collections.Generic;
using System.Text;

namespace MailAppMVVM.ViewModel
{
   public class NewMailPageViewModel
    {
        public string[] MailList { get; set; }

       public NewMailPageViewModel()
        {
            MailList = new string[] { "From: John", "From: Mayelin", "From: Juan" };
        }
    }
}

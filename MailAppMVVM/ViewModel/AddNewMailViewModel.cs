using MailAppMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailAppMVVM.ViewModel
{
    
   public class AddNewMailViewModel
    {
        public MailContent mailContent { get; set; }
        public AddNewMailViewModel()
        {
            mailContent = new MailContent();
        }
    }
}

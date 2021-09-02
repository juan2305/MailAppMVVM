using MailAppMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MailAppMVVM.ViewModel
{
   public class NewMailPageViewModel
    {
       
        public ObservableCollection<MailContent> MailList { get; set; }

       public NewMailPageViewModel()
        {
            MailList = new ObservableCollection<MailContent>();
            MailList.Add(new MailContent() { FromMail = "From Juan", ToMail = "To: Mayelin", BodyMail="Esto es una prueba enviada por Juan", DateMail = DateTime.Now.ToShortTimeString(), IconMail="AccountLogo.png", SubjectMail= "Subject: Probando" });
            MailList.Add(new MailContent() { FromMail = "From Mayelin", ToMail = "To: Juan", BodyMail = " Esto es una prueba enviada por Mayelin", DateMail = DateTime.Now.ToShortTimeString(), IconMail = "AccountLogo.png", SubjectMail = "Subject: Probando" });

        }
    }
}

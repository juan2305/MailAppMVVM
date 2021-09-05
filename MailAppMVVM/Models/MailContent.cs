using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MailAppMVVM.Models
{
   public class MailContent
    {
        
        public static ObservableCollection<MailContent> ItemSource { get; internal set; }
        public int MailId { get; set; }
        public string FromMail { get; set; }
        public string ToMail { get; set; }
        public string BodyMail { get; set; }
        public string SubjectMail { get; set; }
        public string DateMail { get; set; }

}
}

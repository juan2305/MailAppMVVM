using MailAppMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace MailAppMVVM.ViewModel
{
    
   public class AddNewMailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SendButton { get; set; }
        public MailContent mailContent { get; set; }
        public AddNewMailViewModel()
        {
            mailContent = new MailContent();
        }
    }
}

//using ServiceTest.Models;
//using ServiceTest.Services;
using ServiceTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ServiceTest.ViewModels
{
    public class MainPageViewModel:ViewModel
    {
       private TriviaService service;
        private string message;
        public string Message
        {
            get { return message; } 
            set
            {
                message = value;
                OnPropertyChange(nameof(message));
            }
        }
        

        public MainPageViewModel(TriviaService triv)
        {
            service = triv;
        }

       


    }
}
